Imports System.Data.OleDb
Public Class view
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARCHI PRIYA\Desktop\pro\Database8.accdb")
        Dim cmd As New OleDbCommand("select owner,gender,address, model, fuel,engine from regis where regno=v1 ", con)
        cmd.Parameters.AddWithValue("v1", TextBox1.Text)
        con.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        ' Dim i As Integer = 0
        ' While (dr.Read())
        While dr.Read()
            '  TextBox1.Text = dr.GetString(0)
            ' If Not dr.IsDBNull(0) Then
            'TextBox1.Text = dr.GetValue(0).ToString()
            '  Else
            'TextBox1.Text = String.Empty
            ' End If
            TextBox2.Text = dr.GetString(0)
            'TextBox3.Text = dr.GetString(2)
            Dim gender As String = dr.GetString(1)
            If gender = "male" Then
                RadioButton1.Checked = True
            ElseIf gender = "female" Then
                RadioButton2.Checked = True
            End If

            TextBox3.Text = dr.GetString(2)
            ComboBox1.SelectedItem = dr.GetString(3)
            ComboBox2.SelectedItem = dr.GetString(4)

            Dim engineType As String = dr.GetString(5)
            'MsgBox(engineType)
            Select Case engineType
                Case "Internal combustion engine"
                    CheckBox1.Checked = True
                Case "Hybrid engine"
                    CheckBox2.Checked = True
                Case "Electric engine"
                    CheckBox3.Checked = True
            End Select
        End While
        ' MsgBox("No record found")


        'dr.Close()
        con.Close()
    ' If dr.GetString(3) = "male" Then
        'RadioButton1.Checked = True
        'End If
        'If dr.GetString(3) = "female" Then
        'RadioButton2.Checked = True
        'End If


        'TextBox3.Text = dr.GetString(4)
        'ComboBox1.SelectedItem = dr.GetString(5)
        'ComboBox2.SelectedItem = dr.GetString(6)
        'If dr.GetString(7) = "Internal combustion engines" Then
        'CheckBox1.Checked = True
        'End If
        'If dr.GetString(7) = "Hybrid engine" Then
        'CheckBox2.Checked = True

        'End If
        'If dr.GetString(7) = "Electric engine" Then
        'CheckBox3.Checked = True

        'End If
        'i = 1
        ' End While
        'If i = 0 Then
        'MsgBox("no record found")
        'End If
        'con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        modifyed.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        delete.Show()
    End Sub
End Class