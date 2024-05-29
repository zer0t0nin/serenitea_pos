Imports System.Data.OleDb
Public Class VendorForm
    Private Sub VendorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'POS_databaseDataSet8.tblVendor' table. You can move, or remove it, as needed.
        Me.TblVendorTableAdapter.Fill(Me.POS_databaseDataSet8.tblVendor)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtVendorID.Text = Nothing Or txtVendorID.Text = "VD-" Or txtCompanyName.Text = Nothing Or txtContactPerson.Text = Nothing Or txtContactPersPos.Text = Nothing Or cmbSupTitle.Text = Nothing Or txtContactPerson.Text = Nothing Or txtContactPersPos.Text = Nothing Or txtComAddress.Text = Nothing Then
            MessageBox.Show("All Fields Must Be Properly Filled!")

        Else

            Dim InsertQuery As String
            conn = New OleDbConnection(OpenConnectString)
            InsertQuery = "INSERT INTO tblVendor (VendorID,CompanyName,ContactPerson,ContactPersonPosition,SupplierTitle,ContactNumber,CompanyAddress)" & "VALUES (@vendID,@comname,@contactpers,@conperspos,@suptitle,@contactno,@companyadd)"

            Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery)
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@vendID", txtVendorID.Text)
            cmd.Parameters.AddWithValue("@comname", txtCompanyName.Text)
            cmd.Parameters.AddWithValue("@contactpers", txtContactPerson.Text)
            cmd.Parameters.AddWithValue("@conperspos", txtContactPersPos.Text)
            cmd.Parameters.AddWithValue("@suptitle", cmbSupTitle.Text)
            cmd.Parameters.AddWithValue("@contactno", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@companyadd", txtComAddress.Text)
            conn.Open()

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Added.")
            DataGridView1.DataSource = New DataSet()
            DataGridView1.Refresh()
            DataGridView1.DataSource = opentblVendor().Tables("tblVendor")

        End If


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtVendorID.Text = Nothing Or txtVendorID.Text = "VD-" Or txtCompanyName.Text = Nothing Or txtContactPerson.Text = Nothing Or txtContactPersPos.Text = Nothing Or cmbSupTitle.Text = Nothing Or txtContactPerson.Text = Nothing Or txtContactPersPos.Text = Nothing Or txtComAddress.Text = Nothing Then
            MessageBox.Show("All Fields Must Be Properly Filled!")
        Else
            Call AddEditDeleteRecord("UPDATE tblVendor SET [CompanyName]='" & txtCompanyName.Text & "', [ContactPerson]='" & txtContactPerson.Text & "', [ContactPersonPosition]='" & txtContactPersPos.Text & "', [SupplierTitle]='" & cmbSupTitle.Text & "', [ContactNumber]='" & txtContactNo.Text & "', [CompanyAddress]='" & txtComAddress.Text & "' WHERE [VendorID]='" & txtVendorID.Text & "'")
            MessageBox.Show("Record Updated.")
            DataGridView1.DataSource = New DataSet()
            DataGridView1.Refresh()
            DataGridView1.DataSource = opentblVendor().Tables("tblVendor")
        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtVendorID.Text = Nothing Or txtVendorID.Text = "VD-" Or txtCompanyName.Text = Nothing Or txtContactPerson.Text = Nothing Or txtContactPersPos.Text = Nothing Or cmbSupTitle.Text = Nothing Or txtContactPerson.Text = Nothing Or txtContactPersPos.Text = Nothing Or txtComAddress.Text = Nothing Then
            MessageBox.Show("Select Vendor First!")
        Else

            Call AddEditDeleteRecord("DELETE FROM tblVendor WHERE VendorID='" & txtVendorID.Text & "' ")

            MessageBox.Show("Record Deleted.")
            DataGridView1.DataSource = New DataSet()
            DataGridView1.Refresh()
            DataGridView1.DataSource = opentblVendor().Tables("tblVendor")

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtVendorID.Clear()
        txtCompanyName.Clear()
        txtContactPerson.Clear()
        txtContactPersPos.Clear()
        txtContactNo.Clear()
        txtComAddress.Clear()
        txtVendorID.Focus()
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

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        DataGridView1.DataSource = New DataSet()
        DataGridView1.Refresh()
        DataGridView1.DataSource = opentblVendor().Tables("tblVendor")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = Nothing Or txtSearch.Text = "search here..." Then
            MessageBox.Show("Error! Enter Text First!")
        Else

            Dim search As String = txtSearch.Text

            Me.TblVendorTableAdapter.FillBySearch(Me.POS_databaseDataSet8.tblVendor, search, search, search, search, search, search, search)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        retrieveRecord("SELECT VendorID,CompanyName,ContactPerson,ContactPersonPosition,SupplierTitle,ContactNumber,CompanyAddress FROM tblVendor")
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        txtVendorID.Text = ds.Tables("a").Rows(i).ItemArray(0)
        txtCompanyName.Text = ds.Tables("a").Rows(i).ItemArray(1)
        txtContactPerson.Text = ds.Tables("a").Rows(i).ItemArray(2)
        txtContactPersPos.Text = ds.Tables("a").Rows(i).ItemArray(3)
        cmbSupTitle.Text = ds.Tables("a").Rows(i).ItemArray(4)
        txtContactNo.Text = ds.Tables("a").Rows(i).ItemArray(5)
        txtComAddress.Text = ds.Tables("a").Rows(i).ItemArray(6)
    End Sub
End Class