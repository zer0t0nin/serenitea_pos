Imports System.Data.OleDb

Public Class EmployeeMod
    Private Sub EmployeeMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openServer()
        'TODO: This line of code loads data into the 'POS_databaseDataSet.EmployeeQuery' table. You can move, or remove it, as needed.
        Me.EmployeeQueryTableAdapter.Fill(Me.POS_databaseDataSet.EmployeeQuery)

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        DataGridView1.DataSource = New DataSet()
        DataGridView1.Refresh()
        DataGridView1.DataSource = openEmployeeQuery().Tables("EmployeeQuery")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If (cmbSearchBy.SelectedItem = Nothing) Then
            MessageBox.Show("Fields must be properly be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DataGridView1.DataSource = New DataSet()
            DataGridView1.Refresh()
            DataGridView1.DataSource = openEmployeeQuery().Tables("EmployeeQuery")
        Else
            DataGridView1.DataSource = New DataSet()
            DataGridView1.Refresh()
            Dim day As Date
            Dim grd As DataTable = openEmployeeQuery().Tables("EmployeeQuery")
            Dim Filter As String
            If IsNumeric(txtSearch.Text) Then
                Filter = String.Format("{0} = {1}", cmbSearchBy.SelectedItem, txtSearch.Text)
            ElseIf (Date.TryParse(txtSearch.Text, day) = True) Then
                Filter = String.Format("{0} = '{1}'", cmbSearchBy.SelectedItem, Date.Parse(txtSearch.Text).ToShortDateString())
            Else
                Filter = String.Format("{0} like '%{1}%'", cmbSearchBy.SelectedItem, txtSearch.Text)
            End If
            grd.DefaultView.RowFilter = Filter
            DataGridView1.DataSource = grd

        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        retrieveRecord("SELECT [EmployeeID],FirstName,LastName,Address,Contact,Gender,Outlet,[Position],AcctUsername,PhotoDirectory FROM EmployeeQuery")
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtIDNum.Text = ds.Tables("a").Rows(i).ItemArray(0)
        lblFName.Text = ds.Tables("a").Rows(i).ItemArray(1)
        lblLName.Text = ds.Tables("a").Rows(i).ItemArray(2)
        lblAddress.Text = ds.Tables("a").Rows(i).ItemArray(3)
        lblContact.Text = ds.Tables("a").Rows(i).ItemArray(4)
        lblGender.Text = ds.Tables("a").Rows(i).ItemArray(5)
        lblOutlet.Text = ds.Tables("a").Rows(i).ItemArray(6)
        lblPosition.Text = ds.Tables("a").Rows(i).ItemArray(7)
        txtuserappear.Text = ds.Tables("a").Rows(i).ItemArray(8)
        pbEmployee.ImageLocation = ds.Tables("a").Rows(i).ItemArray(9)
    End Sub
End Class