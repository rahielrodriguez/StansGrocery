Option Strict On
Option Explicit On
Option Compare Text
Public Class StansGroceryForm

    Dim productsList As New List(Of String)
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
        Filtering()
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
    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadingProductsFile()
    End Sub
End Class
