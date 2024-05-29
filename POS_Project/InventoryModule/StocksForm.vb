Imports System.Data.OleDb

Public Class StocksMod

    Private Sub StocksMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openServer()
        'TODO: This line of code loads data into the 'POS_databaseDataSet4.StockQuery' table. You can move, or remove it, as needed.
        Me.StockQueryTableAdapter.Fill(Me.POS_databaseDataSet4.StockQuery)

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtProdSearch.Text = Nothing Then
            MessageBox.Show("Field must be filled!")
        Else
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter

            da = New OleDbDataAdapter("SELECT * FROM StockQuery where ProductName like '%" & txtProdSearch.Text & "%' ", conn)
            da.Fill(dt)

            DataGridView1.DataSource = dt.DefaultView

            conn.Close()

        End If

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click

        DataGridView1.DataSource = New DataSet()
        DataGridView1.Refresh()
        DataGridView1.DataSource = openStockQuery().Tables("StockQuery")

    End Sub
End Class
