Imports System.Data.OleDb
Public Class insu2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARCHI PRIYA\Desktop\pro\Database8.accdb")
        Dim cmd As New OleDbCommand("Insert into insur values(v1,v2,v3,v4,v5,v6,v7)", con)
        Dim g As String
        If RadioButton1.Checked = True Then
            g = " Third party insurence"
        End If
        cmd.Parameters.AddWithValue("v1", g)
        cmd.Parameters.AddWithValue("v2", ComboBox1.SelectedItem)
        cmd.Parameters.AddWithValue("v3", TextBox1.Text)
        cmd.Parameters.AddWithValue("v4", TextBox2.Text)
        cmd.Parameters.AddWithValue("v5", ComboBox2.SelectedItem)
        cmd.Parameters.AddWithValue("v6", DateTimePicker1)
        cmd.Parameters.AddWithValue("v7", DateTimePicker2)
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("your car is insured now!!!!!")
        Me.Hide()
        con.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class