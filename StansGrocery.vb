Option Strict On
Option Explicit On
Option Compare Text
Imports System.CodeDom.Compiler
Imports System.Diagnostics.Eventing.Reader
Imports System.Net.Security

Public Class StansGroceryForm

    Dim productsList As New List(Of String)
    Sub d()
        FilterByAisleRadioButton.Checked = True
    End Sub
    Sub ReadingProductsFile()
        Dim products As String
        Dim item() As String, aisle() As String, category() As String, temp() As String

        Try
            FileOpen(1, "..\..\Grocery.txt", OpenMode.Input)
        Catch ex As Exception
            MsgBox("Error!")
        End Try
        Do Until EOF(1)
            products = LineInput(1)
            temp = Split(products, Chr(34))
            item = Split(temp(1), "$$ITM")
            aisle = Split(temp(3), "LOC")
            category = Split(temp(5), "%%CAT")

            If item(1) <> "" Then
                If aisle(1) <> "" Then
                    If category(1) <> "" Then
                        Me.productsList.Add(($"{item(1)},").PadRight(28) & ($"{aisle(1)},").PadRight(6) & ($"{category(1)}"))
                    End If
                End If
            End If
        Loop

        FileClose(1)
        FillingListBox()
        FilteringComboBox()
    End Sub

    Sub FillingListBox()
        Dim temp() As String

        DisplayListBox.Items.Clear()
        DisplayListBox.Sorted = True
        For Each product In productsList
            temp = Split(product, ",")
            If DisplayListBox.Items.Contains(temp(0)) = False Then
                DisplayListBox.Items.Add(temp(0))
            End If
        Next
    End Sub
    Sub FilteringComboBox()
        Dim temp() As String
        Dim filterOption As Integer = 0

        If FilterByAisleRadioButton.Checked Then
            filterOption = 0
        ElseIf FilterByCategoryRadioButton.Checked Then
            filterOption = 1
        Else
            filterOption = 2
        End If

        Select Case filterOption
            Case 0
                FilterComboBox.Items.Clear()
                FilterComboBox.Sorted = False

                For aisle = 17 To 2 Step -1
                    FilterComboBox.Items.Add(CStr(aisle))
                Next
                FilterComboBox.Items.Add(CStr(0))
            Case 1
                FilterComboBox.Items.Clear()
                FilterComboBox.Sorted = True
                For Each item As String In productsList
                    temp = Split(item, ",")
                    If FilterComboBox.Items.Contains((temp(2)).TrimStart) = False Then
                        FilterComboBox.Items.Add((temp(2)).TrimStart)
                    End If
                Next
            Case 2
                For Each item In productsList
                    temp = Split(item, ",")
                    FilterComboBox.Items.Add(temp(0))
                Next
        End Select

    End Sub
    Sub searchingProduct()
        Dim temp() As String
        If SearchTextBox.Text = "" Then
            FillingListBox()
            FilteringComboBox()
            DisplayLabel.Text = "Please, enter the product name that you are looking for"
        Else
            For Each matchingItem As String In productsList
                temp = Split(matchingItem, ",")
                If temp(0).StartsWith(SearchTextBox.Text, StringComparison.CurrentCultureIgnoreCase) Then
                    DisplayListBox.Items.Add(temp(0))
                End If
            Next
        End If
    End Sub
    Sub DisplayingWFilteringOn()
        Dim temp() As String
        Dim filterOption As Integer

        If FilterByAisleRadioButton.Checked Then
            filterOption = 0
        ElseIf FilterByCategoryRadioButton.Checked Then
            filterOption = 1
        Else
            filterOption = 2
        End If

        Select Case filterOption
            Case 0
                DisplayListBox.Items.Clear()
                For Each filteringSelection As String In productsList
                    temp = Split(filteringSelection, ",")
                    If temp(1).TrimStart.StartsWith(CStr(FilterComboBox.SelectedItem)) Then
                        DisplayListBox.Items.Add(temp(0))
                    End If
                Next
            Case 1
                DisplayListBox.Items.Clear()
                For Each filteringSelection As String In productsList
                    temp = Split(filteringSelection, ",")
                    If temp(2).TrimStart.StartsWith(CStr(FilterComboBox.SelectedItem)) Then
                        DisplayListBox.Items.Add(temp(0))
                    End If
                Next
            Case 2
                DisplayListBox.Items.Clear()
                For Each filteringSelection As String In productsList
                    temp = Split(filteringSelection, ",")
                    If temp(0).TrimStart.StartsWith(CStr(FilterComboBox.SelectedItem)) Then
                        DisplayListBox.Items.Add(temp(0))
                    End If
                Next

        End Select

    End Sub
    Sub DisplayProductMessage()

        Dim temp() As String
        DisplayLabel.Visible = True
        DisplayLabel.Text = ""

        For Each matchingProduct As String In productsList
            temp = Split(matchingProduct, ",")
            Try
                If temp(0).StartsWith(CStr(DisplayListBox.SelectedItem)) Then
                    DisplayLabel.Text = $"{temp(0).TrimStart} is on Aisle #{temp(1).TrimStart}, in the {temp(2).TrimStart} section"
                End If
            Catch ex As Exception

            End Try
        Next

    End Sub
    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'd()
        DisplayLabel.Text = ""
        ReadingProductsFile()
    End Sub

    Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged
        FilteringComboBox()
    End Sub

    Private Sub FilterByCategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByCategoryRadioButton.CheckedChanged
        FilteringComboBox()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        DisplayListBox.Items.Clear()
        searchingProduct()
    End Sub

    Private Sub FilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterComboBox.SelectedIndexChanged
        If FilterByAisleRadioButton.Checked = False And FilterByCategoryRadioButton.Checked = False Then
            FillingListBox()
            DisplayListBox.SelectedIndex = FilterComboBox.SelectedIndex
        End If
        DisplayingWFilteringOn()

    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        DisplayProductMessage()

    End Sub
End Class
