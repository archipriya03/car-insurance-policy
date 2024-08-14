Imports System.Data.OleDb
Public Class reg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARCHI PRIYA\Desktop\pro\Database8.accdb")
        Dim cmd As New OleDbCommand("insert into abc values(v1,v2,v3,v4)", con)
        ' cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("v1", TextBox1.Text)
        cmd.Parameters.AddWithValue("v2", TextBox2.Text)
        cmd.Parameters.AddWithValue("v3", TextBox3.Text)
        cmd.Parameters.AddWithValue("v4", TextBox4.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("registration done successfully")
        mdi.Show()
        Me.Hide()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
        Me.Hide()
    End Sub
End Class