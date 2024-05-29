Imports System.Data.OleDb
Public Class ProdBuilderForm
    Dim Code As String
    Dim item As String

    Private Sub ProdBuilerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openServer()
        Call BeverageType()

    End Sub
    Public Sub BeverageType()

        cmbCategory.Items.Add("Refresh")
        cmbCategory.Items.Add("Energize")
        cmbCategory.Items.Add("Relax")
    End Sub
    Public Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

        Select Case (cmbCategory.Text)
            Case "Refresh"
                Code = "F"


            Case "Energize"
                Code = "E"


            Case "Relax"
                Code = "R"


        End Select
        cmbItemName.Items.Clear()
        AddProduct()

    End Sub
    Public Sub AddProduct()
        datareader("SELECT ProductName FROM tblProduct Where [Code] = '" + Code + "' ")


        While dr.Read
            cmbItemName.Items.Add(dr.Item("ProductName"))
        End While

    End Sub
    Public Sub ShowTables()
        lvCompNeed.Items.Clear()
        Dim id As Integer = txtProdID.Text

        datareader("Select a.BuilderLineNumber,b.[Item Name],a.RawQty,a.Unit
        FROM tblProductBuilderDetails a
        INNER JOIN tblRawMat b ON a.RawMatID = b.RawMatID 
        WHERE a.BuilderID = " + id.ToString + "")

        While dr.Read()

            Dim item As New ListViewItem(dr.Item("BuilderLineNumber").ToString, 0)
            item.SubItems.Add(dr.Item("Item Name").ToString)
            item.SubItems.Add(dr.Item("RawQty").ToString)
            item.SubItems.Add(dr.Item("Unit").ToString)
            lvCompNeed.Items.Add(item)

        End While

        datareader("Select a.RawMatID, b.[Item Name], b.Quantity, a.Unit
        FROM tblProductBuilderDetails a
        INNER JOIN tblRawMat b ON a.RawMatID = b.RawMatID 
        WHERE a.BuilderID = " + id.ToString + "")

        lvRawMatsStock.Items.Clear()

        While dr.Read()

            Dim item As New ListViewItem(dr.Item("RawMatID").ToString, 0)
            item.SubItems.Add(dr.Item("Item Name").ToString)
            item.SubItems.Add(dr.Item("Quantity").ToString)
            item.SubItems.Add(dr.Item("Unit").ToString)
            lvRawMatsStock.Items.Add(item)

        End While

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtProdID.Text = Nothing Or cmbCategory.Text = Nothing Or cmbItemName.Text = Nothing Then
            MessageBox.Show("Error: Select a Product First!")
        Else
            Dim Stocks, Qty, Computed, Total As Double
            Dim History, Ready As String


            datareader("SELECT a.RawMatID, a.RawQty, b.Quantity 
        FROM tblProductBuilderDetails a
        INNER JOIN tblRawMat b ON a.RawMatID = b.RawMatID
        WHERE a.BuilderID = " + txtProdID.Text + "")

            Qty = nudProdQty.Value

            While dr.Read
                Stocks = dr.Item("RawQty")
                Computed = Stocks * Qty

                MsgBox(Computed.ToString + " > " + dr.Item("Quantity").ToString)

                If Computed > dr.Item("Quantity") Then

                End If
                History += dr.Item("RawMatID") + ": " + Computed.ToString + vbCrLf

            End While



            datareader("SELECT a.RawMatID, a.RawQty, b.Quantity 
        FROM tblProductBuilderDetails a
        INNER JOIN tblRawMat b ON a.RawMatID = b.RawMatID
        WHERE a.BuilderID = " + txtProdID.Text + "")


            While dr.Read

                Stocks = dr.Item("RawQty")
                Computed = Stocks * Qty
                Total = dr.Item("Quantity") - Computed
                AddEditDeleteRecord("UPDATE tblRawMat SET Quantity = '" + Total.ToString + "' WHERE RawMatID = '" + dr.Item("RawMatID") + "'")

            End While

            ds = New DataSet
            da = New OleDbDataAdapter("SELECT StockQuantity FROM tblProduct WHERE ProductName = '" & cmbItemName.Text & "'", conn)
            da.Fill(ds, "StockQuantity")
            Dim quantity As Integer = ds.Tables("StockQuantity").Rows(0).ItemArray(0).ToString
            Dim fqty As String = quantity - nudProdQty.Value
            AddEditDeleteRecord("UPDATE tblProduct SET StockQuantity = " + fqty + " WHERE Code = '" + txtProdID.Text + "'")

            ShowTables()

            MsgBox("Created Succesfully")
        End If


    End Sub

    Private Sub lvrawmaterials_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvRawMatsStock.SelectedIndexChanged
        For Each i As ListViewItem In lvRawMatsStock.SelectedItems
            txtProdID.Text = lvRawMatsStock.SelectedItems(0).Text
            cmbCategory.Text = lvRawMatsStock.SelectedItems(0).SubItems(1).Text
            cmbItemName.Text = lvRawMatsStock.SelectedItems(0).SubItems(2).Text
        Next
    End Sub

    Private Sub lvstocks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCompNeed.SelectedIndexChanged
        For Each i As ListViewItem In lvRawMatsStock.SelectedItems
            txtProdID.Text = lvRawMatsStock.SelectedItems(0).Text
            cmbCategory.Text = lvRawMatsStock.SelectedItems(0).SubItems(1).Text
            cmbItemName.Text = lvRawMatsStock.SelectedItems(0).SubItems(2).Text
        Next
    End Sub



    Private Sub cmbItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemName.SelectedIndexChanged

        Call datareader("Select ProductID From tblProduct WHERE [ProductName]  = '" + cmbItemName.Text + "'")

        While dr.Read
            txtProdID.Text = dr.Item("ProductID")
        End While

        ShowTables()
    End Sub

End Class