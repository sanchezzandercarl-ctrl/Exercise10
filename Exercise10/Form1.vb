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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using writer As New StreamWriter(filePath)
            For Each n In numbers
                writer.WriteLine(n)
            Next
        End Using
        MessageBox.Show("Numbers saved to file: " & filePath)
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnReadSort.Click
        If Not File.Exists(filePath) Then
            MessageBox.Show("File not found. Please save numbers first.")
            Return
        End If

        Dim fileNumbers As New List(Of Integer)
        Using reader As New StreamReader(filePath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim num As Integer
                If Integer.TryParse(line, num) Then
                    fileNumbers.Add(num)
                End If
            End While
        End Using

        Dim sortedNumbers = fileNumbers.OrderBy(Function(x) x).ToList()
        lstNumbers.Items.Clear()
        For Each n In sortedNumbers
            lstNumbers.Items.Add(n)
        Next

        MessageBox.Show("Numbers are Loaded!! Listing the numbers to Ascending Order")
    End Sub
End Class
