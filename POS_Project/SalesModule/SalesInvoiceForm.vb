Imports System.Data.OleDb
Public Class SalesInvoiceForm

    Private Sub SalesInvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openServer()
        'TODO: This line of code loads data into the 'POS_databaseDataSet2.SalesInvoiceQuery' table. You can move, or remove it, as needed.
        Me.SalesInvoiceQueryTableAdapter.Fill(Me.POS_databaseDataSet2.SalesInvoiceQuery)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search As String = txtInvoiceNo.Text
        If txtInvoiceNo.Text = Nothing Then
            MessageBox.Show("You must Enter Invoice No. First!")


        Else

            Me.SalesInvoiceQueryTableAdapter.FillBySearch(Me.POS_databaseDataSet2.SalesInvoiceQuery, search)
        End If

    End Sub

    Private Sub dtpSaleDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSaleDate.ValueChanged
        Dim dt As New DataTable

        Using da As New OleDbDataAdapter("SELECT * FROM SalesInvoiceQuery where DateBought = ?", conn)
            da.SelectCommand.Parameters.AddWithValue("?", dtpSaleDate.Value.Date)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End Using
        conn.Close()
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        DataGridView1.DataSource = New DataSet()
        DataGridView1.Refresh()
        DataGridView1.DataSource = openSalesInvoiceQuery().Tables("SalesInvoiceQuery")
    End Sub
End Class