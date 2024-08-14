Imports System.Data.OleDb
Public Class viewall
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ARCHI PRIYA\Desktop\pro\Database8.accdb")
        Dim da As New OleDbDataAdapter("select *from regis", con)
        con.Open()
        Dim ds As New DataSet
        ' Dim dt As New DataTable()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        '  If dt.Rows.Count() > 0 Then
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class