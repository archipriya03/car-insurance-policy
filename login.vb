Imports System.Data.OleDb
Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("NULL!!! enter the username and password to login")
        End If
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARCHI PRIYA\Desktop\pro\Database8.accdb")
        'con.Open()
        Dim cmd As New OleDbCommand("select* from abc where username=@v1 and password=@v2", con)
        cmd.Parameters.AddWithValue("@v1", TextBox1.Text)
        cmd.Parameters.AddWithValue("@v2", TextBox2.Text)
        con.Open()

        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Dim f As Integer = 0
        While (dr.Read())
            f = 1
        End While
        If f = 0 Then
            MsgBox("Unauthorized user")
        Else
            ' registration.Show()
            mdi.Show()
            Me.Hide()
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        reg.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        forget.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' If the checkbox is checked, show the password
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            ' Otherwise, hide the password
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    '    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Set the default PasswordChar property for the TextBox
    '       TextBox1.PasswordChar = "*"
    '   End Sub


End Class
