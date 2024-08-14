Imports System.Data.OleDb
Public Class feedb
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARCHI PRIYA\Desktop\pro\Database8.accdb")
        Dim cmd As New OleDbCommand("Insert into feed values(v1,v2,v3,v4,v5)", con)
        ' Dim g As String
        Dim s As String

        If RadioButton3.Checked = True Then
            s = "satisfied"
        End If
        If RadioButton4.Checked = True Then
            s = "neutral"
        End If
        If RadioButton5.Checked = True Then
            s = "unsatisfied"
        End If
        cmd.Parameters.AddWithValue("v1", TextBox1.Text)
        cmd.Parameters.AddWithValue("v2", DateTimePicker1.Value)
        cmd.Parameters.AddWithValue("v3", ComboBox1.SelectedItem)
        cmd.Parameters.AddWithValue("v4", s)
        cmd.Parameters.AddWithValue("v5", TextBox2.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("thank you for your feedback")
        Me.Hide()
        con.Close()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

    End Sub


End Class