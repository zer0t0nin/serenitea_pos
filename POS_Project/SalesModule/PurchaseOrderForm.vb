Imports System.Data.OleDb
Public Class PurchaseOrderForm

    Sub PopulateSupplier()
        Call retrieveRecord("SELECT * FROM tblVendor")

        For x As Integer = 0 To ds.Tables("a").Rows.Count - 1
            cmbSupplier.Items.Add(ds.Tables("a").Rows(x).ItemArray(4).ToString)
        Next

    End Sub
    Sub showxd()
        Call datareader("Select * FROM tblPurchaseOrder")

        ListView1.Items.Clear()
        While dr.Read

            Dim item As New ListViewItem(dr.Item("OrderID").ToString, 0)
            item.SubItems.Add(dr.Item("SupplierName"))
            item.SubItems.Add(dr.Item("Item Name"))
            item.SubItems.Add(dr.Item("Quantity"))
            item.SubItems.Add(dr.Item("Unit"))
            item.SubItems.Add(dr.Item("Price"))
            item.SubItems.Add(dr.Item("Recieved"))
            item.SubItems.Add(dr.Item("DateBought"))
            item.SubItems.Add(dr.Item("RawMatID"))
            item.SubItems.Add(dr.Item("Return"))
            ListView1.Items.Add(item)

        End While
    End Sub

    Private Sub PurchaseOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openServer()
        Call PopulateSupplier()
        Call showxd()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtItemName.Text = Nothing Or txtPrice.Text = Nothing Or txtQty.Text = Nothing Or txtRawMatID.Text = Nothing Or cmbSupplier.Text = Nothing Or cmbUnit.Text = Nothing Then
            MessageBox.Show("All Fields Must Be Properly Filled!")
        Else
            Dim InsertQuery As String
            conn = New OleDbConnection(OpenConnectString)
            InsertQuery = "INSERT INTO tblPurchaseOrder (SupplierName,[Item Name],Quantity,Unit,Price,[Recieved],DateBought,RawMatID,Return)" & "VALUES (@supname,@itemname,@qty,@unit,@price,'No',@date,@rmid,'No')"

            Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery)
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@supname", cmbSupplier.Text)
            cmd.Parameters.AddWithValue("@itemname", txtItemName.Text)
            cmd.Parameters.AddWithValue("@qty", txtQty.Text)
            cmd.Parameters.AddWithValue("@unit", cmbUnit.Text)
            cmd.Parameters.AddWithValue("@price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@date", dtpDateBought.Value.ToShortDateString)
            cmd.Parameters.AddWithValue("@rmid", txtRawMatID.Text)

            conn.Open()

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Added.")
            DataGridView1.DataSource = New DataSet()
            DataGridView1.Refresh()
            DataGridView1.DataSource = opentblPurchaseOrder().Tables("tblPurchaseOrder")
            Call showxd()
        End If


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtItemName.Text = Nothing Or txtPrice.Text = Nothing Or txtQty.Text = Nothing Or txtRawMatID.Text = Nothing Or cmbSupplier.Text = Nothing Or cmbUnit.Text = Nothing Then
            MessageBox.Show("All Fields Must Be Properly Filled!")
        Else
            Call AddEditDeleteRecord("UPDATE tblPurchaseOrder SET [SupplierName]='" & cmbSupplier.Text & "', [Quantity]='" & txtQty.Text & "', [Unit]='" & cmbUnit.Text & "', [Price]='" & txtPrice.Text & "', [DateBought]='" & dtpDateBought.Value.ToShortDateString & "', [RawMatID]='" & txtRawMatID.Text & "' WHERE [Item Name]='" & txtItemName.Text & "' ")

            MessageBox.Show("Record Updated.")

            DataGridView1.DataSource = New DataSet()
            DataGridView1.Refresh()
            DataGridView1.DataSource = opentblPurchaseOrder().Tables("tblPurchaseOrder")
            showxd()

        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtItemName.Text = Nothing Then
            MessageBox.Show("Error Select Item First!")
        Else

            Call AddEditDeleteRecord("DELETE FROM tblPurchaseOrder WHERE [Item Name]='" & txtItemName.Text & "' ")

            MessageBox.Show("Record Deleted.")
            DataGridView1.DataSource = New DataSet()
            DataGridView1.Refresh()
            DataGridView1.DataSource = opentblPurchaseOrder().Tables("tblPurchaseOrder")
            Call showxd()

        End If
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItemName.Clear()
        txtQty.Clear()
        txtPrice.Clear()
        txtItemName.Focus()

    End Sub
    Private Sub btnAll_Click(sender As Object, e As EventArgs)
        DataGridView1.DataSource = New DataSet()
        DataGridView1.Refresh()
        DataGridView1.DataSource = opentblPurchaseOrder().Tables("tblPurchaseOrder")
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        For Each i As ListViewItem In ListView1.SelectedItems
            txtoid.Text = ListView1.SelectedItems(0).SubItems(0).Text
            cmbSupplier.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtItemName.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtQty.Text = ListView1.SelectedItems(0).SubItems(3).Text
            cmbUnit.Text = ListView1.SelectedItems(0).SubItems(4).Text
            txtPrice.Text = ListView1.SelectedItems(0).SubItems(5).Text
            dtpDateBought.Text = ListView1.SelectedItems(0).SubItems(7).Text
            txtRawMatID.Text = ListView1.SelectedItems(0).SubItems(8).Text

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        showxd()
    End Sub

End Class

'Private Sub Button1_Click(sender As Object, e As EventArgs)
'    Call AddEditDeleteRecord("UPDATE tblPurchaseOrder SET [SupplierName]='" & cmbSupplier.Text &
'                             "', [Quantity]='" & txtQty.Text & "', [Unit]='" & cmbUnit.Text &
'                             "', [Price]='" & txtPrice.Text & "', [DateBought]='" &
'                             dtpDateBought.Value.ToShortDateString &
'                             "', [RawMatID]='" & txtRawMatID.Text & "', [Return]= 'Yes'
'                             WHERE [Item Name]='" & txtItemName.Text & "' ")



'    'adding stock to raw mats

'    ds = New DataSet
'    da = New OleDbDataAdapter("SELECT Quantity FROM tblRawMat WHERE [Item Name] = '" & txtItemName.Text & "'", conn)
'    da.Fill(ds, "Quantity")

'    Dim quantity As Integer = ds.Tables("Quantity").Rows(0).ItemArray(0).ToString

'    Dim addQuantity As Integer = txtQty.Text


'    Dim NewQuantity As Integer = quantity - addQuantity
'    Call AddEditDeleteRecord("UPDATE tblRawMat SET Quantity= " & NewQuantity & " WHERE [Item Name] = '" & txtItemName.Text & "'")
'    Call showxd()
'End Sub

'Private Sub txtrecieved_Click(sender As Object, e As EventArgs) Handles txtReceive.Click

'    Call AddEditDeleteRecord("UPDATE tblPurchaseOrder SET [Recieved] = 'Yes' Where [OrderID] = " & txtoid.Text & "")



'    'adding stock to raw mats

'    ds = New DataSet
'    da = New OleDbDataAdapter("SELECT Quantity FROM tblRawMat WHERE [Item Name] = '" & txtItemName.Text & "'", conn)
'    da.Fill(ds, "Quantity")

'    Dim quantity As Integer = ds.Tables("Quantity").Rows(0).ItemArray(0).ToString

'    Dim addQuantity As Integer = txtQty.Text


'    Dim NewQuantity As Integer = quantity + addQuantity
'    Call AddEditDeleteRecord("UPDATE tblRawMat SET Quantity= " & NewQuantity & " WHERE [Item Name] = '" & txtItemName.Text & "'")
'    Call showxd()
'End Sub