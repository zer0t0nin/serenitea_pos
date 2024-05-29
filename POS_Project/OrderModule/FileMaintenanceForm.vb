Imports System.Data.OleDb
Public Class FileMaintenanceMod

    Private Sub FileMaintenanceMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POS_databaseDataSet3.tblFileMaintenance' table. You can move, or remove it, as needed.
        Me.TblFileMaintenanceTableAdapter.Fill(Me.POS_databaseDataSet3.tblFileMaintenance)
        Call openServer()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtFirstName.Text = Nothing Or txtLastName.Text = Nothing Or txtMiddleName.Text = Nothing Or txtAddress.Text = Nothing Or txtContact.Text = Nothing Or cmbGender.Text = Nothing Or cmbOutlet.Text = Nothing Or cmbPosition.Text = Nothing Or cmbMaritalStat.Text = Nothing Or cmbEmploymentStat.Text = Nothing Or txtAcctUser.Text = Nothing Or txtAcctPass.Text = Nothing Then
            MessageBox.Show("All Fields Must Be Properly Filled!")
        Else
            Dim InsertQuery As String
            conn = New OleDbConnection(OpenConnectString)
            InsertQuery = "INSERT INTO tblFileMaintenance (FirstName,LastName,MiddleName,Address,[Contact],Birthday,Gender,Outlet,[Position],MaritalStatus,EmploymentStatus,AcctUsername,AcctPassword,PhotoDirectory)" & "VALUES (@fname,@lname,@middlename,@address,@cont,@bday,@gend,@outlet,@pos,@maritalstat,@employmentstat,@acctuser,@acctpass,@photod)"

            Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery)
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@lname", txtLastName.Text)
            cmd.Parameters.AddWithValue("@middlename", txtMiddleName.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@cont", txtContact.Text)
            cmd.Parameters.AddWithValue("@bday", dtpBirthday.Value.ToShortDateString)
            cmd.Parameters.AddWithValue("@gend", cmbGender.Text)
            cmd.Parameters.AddWithValue("@outlet", cmbOutlet.Text)
            cmd.Parameters.AddWithValue("@pos", cmbPosition.Text)
            cmd.Parameters.AddWithValue("@maritalstat", cmbMaritalStat.Text)
            cmd.Parameters.AddWithValue("@employmentstat", cmbEmploymentStat.Text)
            cmd.Parameters.AddWithValue("@acctuser", txtAcctUser.Text)
            cmd.Parameters.AddWithValue("@acctpass", txtAcctPass.Text)
            cmd.Parameters.AddWithValue("@photod", OpenFD.FileName.ToString)

            conn.Open()

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Added.")
            DataGridView1.DataSource = New DataSet()
            DataGridView1.Refresh()
            DataGridView1.DataSource = opentblFileMaintenance().Tables("tblFileMaintenance")
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtFirstName.Text = Nothing Or txtLastName.Text = Nothing Or txtMiddleName.Text = Nothing Or txtAddress.Text = Nothing Or txtContact.Text = Nothing Or cmbGender.Text = Nothing Or cmbOutlet.Text = Nothing Or cmbPosition.Text = Nothing Or cmbMaritalStat.Text = Nothing Or cmbEmploymentStat.Text = Nothing Or txtAcctUser.Text = Nothing Or txtAcctPass.Text = Nothing Then
            MessageBox.Show("All Fields Must Be Properly Filled!")
        Else
            Call AddEditDeleteRecord("UPDATE tblFileMaintenance SET [LastName]='" & txtLastName.Text & "', [MiddleName]='" & txtMiddleName.Text & "', [Address]='" & txtAddress.Text & "', [Contact]='" & txtContact.Text & "', [Birthday]='" & dtpBirthday.Value.ToShortDateString & "', [Gender]='" & cmbGender.Text & "', [Outlet]='" & cmbOutlet.Text & "', [Position]='" & cmbPosition.Text & "', [MaritalStatus]='" & cmbMaritalStat.Text & "', [EmploymentStatus]='" & cmbEmploymentStat.Text & "', [AcctUsername]='" & txtAcctUser.Text & "', [AcctPassword]='" & txtAcctPass.Text & "', [PhotoDirectory]='" & OpenFD.FileName.ToString & "' WHERE [FirstName]='" & txtFirstName.Text & "'")

            MessageBox.Show("Record Updated.")
            DataGridView1.DataSource = New DataSet()
            DataGridView1.Refresh()
            DataGridView1.DataSource = opentblFileMaintenance().Tables("tblFileMaintenance")
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtFirstName.Text = Nothing Or txtLastName.Text = Nothing Or txtMiddleName.Text = Nothing Or txtAddress.Text = Nothing Or txtContact.Text = Nothing Or cmbGender.Text = Nothing Or cmbOutlet.Text = Nothing Or cmbPosition.Text = Nothing Or cmbMaritalStat.Text = Nothing Or cmbEmploymentStat.Text = Nothing Or txtAcctUser.Text = Nothing Or txtAcctPass.Text = Nothing Then
            MessageBox.Show("Please fill up the Fields First")
        Else

            Call AddEditDeleteRecord("DELETE FROM tblFileMaintenance WHERE FirstName = '" & txtFirstName.Text & "' ")

            MessageBox.Show("Record Deleted.")
            DataGridView1.DataSource = New DataSet()
            DataGridView1.Refresh()
            DataGridView1.DataSource = opentblFileMaintenance().Tables("tblFileMaintenance")

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleName.Clear()
        txtAddress.Clear()
        txtContact.Clear()
        txtAcctUser.Clear()
        txtAcctPass.Clear()
        txtFirstName.Focus()
    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.TextChanged
        lblDate.Text = DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")
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
            MessageBox.Show("Please fill in The Searchbox")
        Else
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter

            da = New OleDbDataAdapter("SELECT * FROM tblFileMaintenance where FirstName like '%" & txtSearch.Text & "%' ", conn)
            da.Fill(dt)

            DataGridView1.DataSource = dt.DefaultView

            conn.Close()
        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'Dim search As String = txtSearch.Text
        ' Me.TblFileMaintenanceTableAdapter.FillBySearch(Me.POS_databaseDataSet3.tblFileMaintenance, search, search, search, search, search, search, search, search, search, search, search)
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        DataGridView1.DataSource = New DataSet()
        DataGridView1.Refresh()
        DataGridView1.DataSource = opentblFileMaintenance().Tables("tblFilemaintenance")
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click

        With OpenFD
            .InitialDirectory = "C:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 4
        End With
        If OpenFD.ShowDialog() = DialogResult.OK Then
            pbEmployee.Image = Image.FromFile(OpenFD.FileName)
            pbEmployee.SizeMode = PictureBoxSizeMode.StretchImage
            pbEmployee.BorderStyle = BorderStyle.Fixed3D

        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        retrieveRecord("SELECT [EmployeeID],FirstName,LastName,MiddleName,Address,Contact,Birthday,Gender,Outlet,[Position],MaritalStatus,EmploymentStatus,AcctUsername,AcctPassword,PhotoDirectory FROM tblFileMaintenance")
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        'If DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value Is Nothing OrElse
        '    DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString = "" Then
        '    '(DataGridView1.CurrentRow.Index == dataGridView1.Rows.Count -1)
        '    MsgBox("Please Select Employee From The List!")
        'Else

        'for panel
        txtIDNum.Text = ds.Tables("a").Rows(i).ItemArray(0)
            lblFName.Text = ds.Tables("a").Rows(i).ItemArray(1)
            lblLName.Text = ds.Tables("a").Rows(i).ItemArray(2)
            lblMName.Text = ds.Tables("a").Rows(i).ItemArray(3)
            lblAddress.Text = ds.Tables("a").Rows(i).ItemArray(4)
            lblContact.Text = ds.Tables("a").Rows(i).ItemArray(5)
            lblBirthday.Text = ds.Tables("a").Rows(i).ItemArray(6)
            lblGender.Text = ds.Tables("a").Rows(i).ItemArray(7)
            lblOutlet.Text = ds.Tables("a").Rows(i).ItemArray(8)
            lblPosition.Text = ds.Tables("a").Rows(i).ItemArray(9)
            lblMaritStat.Text = ds.Tables("a").Rows(i).ItemArray(10)
            lblEmpStat.Text = ds.Tables("a").Rows(i).ItemArray(11)
            txtuserappear.Text = ds.Tables("a").Rows(i).ItemArray(12)
            txtpassappear.Text = ds.Tables("a").Rows(i).ItemArray(13)
            pbEmployee.ImageLocation = ds.Tables("a").Rows(i).ItemArray(14)

            'for textbox
            txtFirstName.Text = ds.Tables("a").Rows(i).ItemArray(1)
            txtLastName.Text = ds.Tables("a").Rows(i).ItemArray(2)
            txtMiddleName.Text = ds.Tables("a").Rows(i).ItemArray(3)
            txtAddress.Text = ds.Tables("a").Rows(i).ItemArray(4)
            txtContact.Text = ds.Tables("a").Rows(i).ItemArray(5)
            dtpBirthday.Text = ds.Tables("a").Rows(i).ItemArray(6)
            cmbGender.Text = ds.Tables("a").Rows(i).ItemArray(7)
            cmbOutlet.Text = ds.Tables("a").Rows(i).ItemArray(8)
            cmbPosition.Text = ds.Tables("a").Rows(i).ItemArray(9)
            cmbMaritalStat.Text = ds.Tables("a").Rows(i).ItemArray(10)
            cmbEmploymentStat.Text = ds.Tables("a").Rows(i).ItemArray(11)
            txtAcctUser.Text = ds.Tables("a").Rows(i).ItemArray(12)
            txtAcctPass.Text = ds.Tables("a").Rows(i).ItemArray(13)
        'End If
    End Sub

End Class