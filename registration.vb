Imports System.IO
Imports System.Data.OleDb

Public Class registration
    Dim opfd As New OpenFileDialog
    ' Dim opfd As New OpenFileDialog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARCHI PRIYA\Desktop\pro\Database8.accdb")
        Dim cmd As New OleDbCommand("Insert into regis values(v1,v2,v3,v4,v5,v6,v7,v8)", con)
        Dim g As String
        Dim f As String
        If CheckBox1.Checked Then
            f = f + "Internal combustion engine"
        End If
        If CheckBox2.Checked Then
            f = f + "Hybrid engine"
        End If
        If CheckBox3.Checked Then
            f = f + "Electric engine"
        End If
        If RadioButton1.Checked = True Then
            g = "male"
        End If
        If RadioButton2.Checked = True Then
            g = "female"
        End If
        cmd.Parameters.AddWithValue("v1", TextBox1.Text)
        cmd.Parameters.AddWithValue("v2", TextBox2.Text)
        cmd.Parameters.AddWithValue("v3", g)
        cmd.Parameters.AddWithValue("v4", TextBox3.Text)
        cmd.Parameters.AddWithValue("v5", ComboBox1.SelectedItem)
        cmd.Parameters.AddWithValue("v6", ComboBox2.SelectedItem)
        cmd.Parameters.AddWithValue("v7", f)
        cmd.Parameters.AddWithValue("v8", Button7)
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("registration done successfully")
        mdi.Show()
        Me.Hide()
        '  Me.Hide()
        MsgBox("select the type of insurance")
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)



    End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    'End Sub

    'Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    ' End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        opfd.ShowDialog()
        TextBox4.Text = opfd.FileName
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Dim opfd As New OpenFileDialog
        Dim s1 As String = Path.GetFileName(opfd.FileName)
        Dim s2 As String = Path.GetExtension(opfd.FileName)
        If s2 = ".jpg" Or s2 = ".jpeg" Or s2 = ".JPG" Or s2 = ".JPEG" Or s2 = ".png" Then
            File.Copy(opfd.FileName, "C:\Users\ARCHI PRIYA\Desktop\" + s1)
            MsgBox("file uploaded")
        Else
            MsgBox("uploaded jpg or jpeg or png types only")
        End If
    End Sub

    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        mdi.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class