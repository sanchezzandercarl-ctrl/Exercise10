Imports System.IO
Imports System.Linq

Public Class Form1
    Dim numbers As New List(Of Integer)
    Dim filePath As String = "numbers.txt"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim num As Integer
        If Integer.TryParse(txtNumber.Text, num) Then
            numbers.Add(num)
            txtNumber.Clear()
            txtNumber.Focus()
            MessageBox.Show("Number added successfully!")
        Else
            MessageBox.Show("Please enter a valid number.")
        End If
    End Sub

End Class
