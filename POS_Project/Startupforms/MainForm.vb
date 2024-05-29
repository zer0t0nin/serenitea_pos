Imports System.Data.OleDb
Public Class MainMod
    Private Sub MainMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'for getting data
        ds = New DataSet
        da = New OleDbDataAdapter("SELECT [Position] FROM tblFileMaintenance WHERE AcctUsername = '" & LoginMod.txtUsername.Text & "'", conn)
        da.Fill(ds, "[Position]")
        Dim pos As String = ds.Tables("[Position]").Rows(0).ItemArray(0).ToString
        '-------------------------------------------------------------------------
        Select Case pos
            Case "Admin"
                'Ordering
                btnPOS.Enabled = True
                btnEmployee.Enabled = True
                btnFM.Enabled = True
                'Inventory
                btnStocks.Enabled = True
                btnProducts.Enabled = True
                btnRM.Enabled = True
                'Sales
                btnPO.Enabled = True
                btnSI.Enabled = True
                btnVendor.Enabled = True
                'Delivery
                btnReceiving.Enabled = True
                btnReturns.Enabled = True
                'button
                POSMod.btnLogout.Visible = False

            Case "Cashier"
                POSMod.Show()
                Me.Close()

            Case "HR"
                FileMaintenanceMod.Show()
                Me.Close()


        End Select

    End Sub
    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        POSMod.Show()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        EmployeeMod.Show()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        ProductsMod.Show()
    End Sub

    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        StocksMod.Show()
    End Sub

    Public Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginMod.Show()
        Me.Hide()
    End Sub

    Private Sub btnFM_Click(sender As Object, e As EventArgs) Handles btnFM.Click
        FileMaintenanceMod.Show()
    End Sub

    Private Sub btnRM_Click(sender As Object, e As EventArgs) Handles btnRM.Click
        RawMaterialsForm.Show()
    End Sub

    Private Sub btnPO_Click(sender As Object, e As EventArgs) Handles btnPO.Click
        PurchaseOrderForm.Show()
    End Sub

    Private Sub btnSI_Click(sender As Object, e As EventArgs) Handles btnSI.Click
        SalesInvoiceForm.Show()
    End Sub

    Private Sub btnVendor_Click(sender As Object, e As EventArgs) Handles btnVendor.Click
        VendorForm.Show()
    End Sub

    Private Sub btnReceiving_Click(sender As Object, e As EventArgs) Handles btnReceiving.Click
        ReceivingForm.Show()
    End Sub

    Private Sub btnReturns_Click(sender As Object, e As EventArgs) Handles btnReturns.Click
        ReturnForm.Show()
    End Sub
End Class