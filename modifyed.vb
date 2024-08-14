Imports System.Data.OleDb
Public Class modifyed
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARCHI PRIYA\Desktop\pro\Database8.accdb")
        Dim cmd As New OleDbCommand("update regis set owner=v1,address=v2 where owner=v1", con)

        cmd.Parameters.AddWithValue("v1", TextBox1.Text)
        cmd.Parameters.AddWithValue("v2", TextBox2.Text)
        con.Open()
        ' Dim i As Integer
        cmd.ExecuteNonQuery()
        'cmd.ExecuteNonQuery()
        MsgBox("address updated")
        Me.Hide()
        con.Close()
    End Sub

    Private Sub modifyed_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class