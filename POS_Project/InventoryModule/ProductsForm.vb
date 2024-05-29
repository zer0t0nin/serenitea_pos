Imports System.Data.OleDb
Public Class ProductsMod
    Private Sub txtSearch_MouseLeave(sender As Object, e As EventArgs) Handles txtSearch.MouseLeave
        If txtSearch.Text = "" Then
            txtSearch.Text = "search here..."
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseClick
        If txtSearch.Text = "search here..." Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ProdBuilderForm.Show()
    End Sub

    Private Sub ProductsMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POS_databaseDataSet1.tblProduct' table. You can move, or remove it, as needed.
        Me.TblProductTableAdapter.Fill(Me.POS_databaseDataSet1.tblProduct)

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        DataGridView1.DataSource = New DataSet()
        DataGridView1.Refresh()
        DataGridView1.DataSource = opentblProduct().Tables("tblProduct")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = Nothing Or txtSearch.Text = "search here..." Then
            MessageBox.Show("Searchbox must be filled!")
        Else
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter

            da = New OleDbDataAdapter("SELECT * FROM tblProduct where ProductName like '%" & txtSearch.Text & "%' ", conn)
            da.Fill(dt)

            DataGridView1.DataSource = dt.DefaultView

        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        retrieveRecord("SELECT ProductID,ProductName,StockQuantity,Price FROM tblProduct")
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        txtProdID.Text = ds.Tables("a").Rows(i).ItemArray(0)
        txtProdName.Text = ds.Tables("a").Rows(i).ItemArray(1)
        txtQty.Text = ds.Tables("a").Rows(i).ItemArray(2)
        txtPrice.Text = ds.Tables("a").Rows(i).ItemArray(3)

    End Sub
End Class