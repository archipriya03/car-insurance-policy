Imports System.Data.OleDb
Public Class iad
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARCHI PRIYA\Desktop\pro\Database8.accdb")
        Dim cmd As New OleDbCommand("Insert into insuram (ipolicy,iam,datee,paymode) values(v1,v2,v3,v4)", con)
        con.Open()
        Dim s As String
        If RadioButton1.Checked = True Then
            s = "BY UPI"
        End If
        If RadioButton2.Checked = True Then
            s = "BY CREDIT"
        End If
        cmd.Parameters.AddWithValue("v1", ComboBox1.SelectedItem)
        cmd.Parameters.AddWithValue("v2", TextBox1.Text)
        cmd.Parameters.AddWithValue("v3", DateTimePicker1)
        cmd.Parameters.AddWithValue("v4", s)
        cmd.ExecuteNonQuery()
        MsgBox("payment done !!! " & s)
        Form4.Show()
        Me.Hide()
        con.Close()
    End Sub

    Private Sub iad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class