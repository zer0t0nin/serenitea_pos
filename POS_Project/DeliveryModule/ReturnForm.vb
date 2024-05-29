Imports System.Data.OleDb
Public Class ReturnForm
    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call showxd()
    End Sub
    Sub showxd()
        Call datareader("Select * FROM tblPurchaseOrder Where  Recieved = 'Yes' AND Return = 'No'")

        ListView1.Items.Clear()
        While dr.Read
            Dim item As New ListViewItem(dr.Item("OrderID").ToString, 0)
            item.SubItems.Add(dr.Item("SupplierName"))
            item.SubItems.Add(dr.Item("Item Name"))
            item.SubItems.Add(dr.Item("Quantity"))
            item.SubItems.Add(dr.Item("Unit"))
            item.SubItems.Add(dr.Item("Recieved"))
            ListView1.Items.Add(item)
        End While
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        For Each i As ListViewItem In ListView1.SelectedItems
            txtoid.Text = ListView1.SelectedItems(0).SubItems(0).Text
            cmbSupplier.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtItemName.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtQty.Text = ListView1.SelectedItems(0).SubItems(3).Text
            cmbUnit.Text = ListView1.SelectedItems(0).SubItems(4).Text
            txtqty1.Text = ListView1.SelectedItems(0).SubItems(3).Text
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Call AddEditDeleteRecord("UPDATE tblPurchaseOrder SET [Return] = 'No'
                                 WHERE [Item Name]= '" & txtoid.Text & "' ")

        Call showxd()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'subtracting stock from raw mats
        ds = New DataSet
        da = New OleDbDataAdapter("SELECT Quantity FROM tblRawMat WHERE [Item Name] = '" & txtItemName.Text & "'", conn)
        da.Fill(ds, "Quantity")
        Dim quantity As Integer = ds.Tables("Quantity").Rows(0).ItemArray(0).ToString
        Dim addQuantity As Integer = txtQty.Text
        Dim NewQuantity As Integer = quantity - addQuantity

        Dim newqty As Integer = txtqty1.Text - addQuantity

        If txtQty.Text < txtqty1.Text Then

            Call AddEditDeleteRecord("UPDATE tblRawMat SET Quantity= " & NewQuantity & " WHERE [Item Name] = '" & txtItemName.Text & "'")
            AddEditDeleteRecord("UPDATE tblPurchaseOrder SET [Quantity]= '" & newqty.ToString & "' WHERE OrderID=" & txtoid.Text & " ")
            showxd()
            cmbSupplier.Text = ""
            txtItemName.Text = ""
            txtoid.Text = ""
            txtQty.Text = ""
            txtqty1.Text = ""
        Else
            AddEditDeleteRecord("UPDATE tblRawMat SET Quantity= " & NewQuantity & " WHERE [Item Name] = '" & txtItemName.Text & "'")
            AddEditDeleteRecord("UPDATE tblPurchaseOrder SET [Return]= 'Yes' WHERE OrderID=" & txtoid.Text & " ")
            showxd()
            cmbSupplier.Text = ""
            txtItemName.Text = ""
            txtoid.Text = ""
            txtQty.Text = ""
            txtqty1.Text = ""
        End If


    End Sub

End Class