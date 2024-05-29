Imports System.Data.OleDb
Public Class RawMaterialsForm
    Private Sub RawMaterialsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POS_databaseDataSet6.tblRawMat' table. You can move, or remove it, as needed.
        Me.TblRawMatTableAdapter.Fill(Me.POS_databaseDataSet6.tblRawMat)
    End Sub

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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = Nothing Or txtSearch.Text = "search here..." Then
            MessageBox.Show("Searchbox must be filled!")
        Else
            Dim search As String = txtSearch.Text
            Me.TblRawMatTableAdapter.FillBySearch(Me.POS_databaseDataSet6.tblRawMat, search, search)
        End If

    End Sub

    Private Sub btnReceiving_Click(sender As Object, e As EventArgs) Handles btnReceiving.Click
        ReceivingForm.Show()
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        DataGridView1.DataSource = New DataSet()
        DataGridView1.Refresh()
        DataGridView1.DataSource = opentblRawMat().Tables("tblRawMat")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        retrieveRecord("SELECT RawMatID,[Item Name],Quantity,Unit,Price FROM tblRawMat")
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        txtRawMatID.Text = ds.Tables("a").Rows(i).ItemArray(0)
        txtItemName.Text = ds.Tables("a").Rows(i).ItemArray(1)
        txtQuantity.Text = ds.Tables("a").Rows(i).ItemArray(2)
        txtUnit.Text = ds.Tables("a").Rows(i).ItemArray(3)
        txtPrice.Text = ds.Tables("a").Rows(i).ItemArray(4)
    End Sub
End Class