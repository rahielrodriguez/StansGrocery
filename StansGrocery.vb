﻿Option Strict On
Option Explicit On
Option Compare Text
Imports System.Diagnostics.Eventing.Reader
Imports System.Net.Security

Public Class StansGroceryForm

    Dim productsList As New List(Of String)
    Sub d()
        FilterByCategoryRadioButton.Checked = True
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

        If filterOption = 0 Then
            FilterComboBox.Items.Clear()
            FilterComboBox.Sorted = False

            For aisle = 17 To 2 Step -1
                FilterComboBox.Items.Add(CStr(aisle))
            Next
            FilterComboBox.Items.Add(CStr(0))

        ElseIf filterOption = 1 Then
            FilterComboBox.Items.Clear()
            FilterComboBox.Sorted = True
            For Each item As String In productsList
                temp = Split(item, ",")
                If Not FilterComboBox.Items.Contains((temp(filterOption)).TrimStart) Then
                    FilterComboBox.Items.Add((temp(filterOption)).TrimStart)
                End If
            Next

        ElseIf filterOption = 2 Then
                    For Each item In productsList
                temp = Split(item, ",")
                FilterComboBox.Items.Add(temp(0))
            Next
        End If
    End Sub
    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'd()
        ReadingProductsFile()
    End Sub

    Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged
        FilteringComboBox()
    End Sub

    Private Sub FilterByCategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByCategoryRadioButton.CheckedChanged
        FilteringComboBox()
    End Sub
End Class
