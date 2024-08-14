Imports System.Data.OleDb
Public Class delete
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARCHI PRIYA\Desktop\pro\Database8.accdb")
        Dim cmd As New OleDbCommand("delete from regis where owner=v1", con)
        cmd.Parameters.AddWithValue("v1", TextBox1.Text)
        ' cmd.Parameters.AddWithValue("v2", TextBox2.Text)
        ' cmd.Parameters.AddWithValue("v2", TextBox3.Text)
        'cmd.Parameters.AddWithValue("v5", ComboBox1.SelectedItem)
        '  Dim i As Integer
        con.Open()
        cmd.ExecuteNonQuery()
        ' cmd.ExecuteNonQuery()
        MsgBox("registration cancled")
        Me.Hide()
        con.Close()
    End Sub

    Private Sub delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class