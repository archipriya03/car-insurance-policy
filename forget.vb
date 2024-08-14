Imports System.Data.OleDb
Public Class forget
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' If TextBox2.Text = TextBox3.Text Then
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARCHI PRIYA\Desktop\pro\Database8.accdb ")
        'Dim cmd As New OleDbCommand("UPDATE abc set Email=v1 ,password=v2 where Email=v1", con)
        Dim cmd As New OleDbCommand("UPDATE abc SET [password]=? WHERE Email=?", con)
        cmd.Parameters.AddWithValue("Email", TextBox1.Text)
        cmd.Parameters.AddWithValue("password", TextBox2.Text)

        ' cmd.Parameters.AddWithValue("username", TextBox3.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("password updated")
        Me.Hide()
        con.Close()
        'cmd.Parameters.AddWithValue("v1", TextBox1.Text)
        'cmd.Parameters.AddWithValue("v2", TextBox2.Text)
        'con.Open()
        'cmd.ExecuteNonQuery()
        'MsgBox("record update")
        'con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
        Me.Hide()
    End Sub
End Class