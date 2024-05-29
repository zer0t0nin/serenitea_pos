Imports System.Data.OleDb
Public Class POSMod



    Sub compute()

        If (DataGridView2.Rows.Count > 1) Then
            txtSubtotal.Text = Total().ToString("0.00")

        End If

    End Sub
    Public Function Total() As Double
        Dim tot As Double = 0
        Dim i As Integer = 0
        For i = 0 To (DataGridView2.Rows.Count - 1)
            tot = tot + Convert.ToDouble(DataGridView2.Rows(i).Cells(2).Value)
        Next i
        Return tot

    End Function
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        With formRefresh
            .TopLevel = False
            txtqty.Controls.Add(formRefresh)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnEnergize_Click(sender As Object, e As EventArgs) Handles btnEnergize.Click
        With formEnergize
            .TopLevel = False
            txtqty.Controls.Add(formEnergize)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnRelax_Click(sender As Object, e As EventArgs) Handles btnRelax.Click
        With formRelax
            .TopLevel = False
            txtqty.Controls.Add(formRelax)
            .BringToFront()
            .Show()
        End With


    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataGridView2.Rows.Clear()
        txtDiscount.Clear()
        txtSubtotal.Clear()
        txtTotal.Clear()
        txtCash.Clear()
        txtChange.Clear()

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim discc As Double = Val(txtSubtotal.Text) - Val(txtDiscount.Text)
        txtTotal.Text = Val(txtSubtotal.Text) - Val(txtDiscount.Text)
        If txtCash.Text = Nothing Then
            MessageBox.Show("Error: Enter CASH $_$ Please!")
        ElseIf Val(txtCash.Text) < txtTotal.Text Or Val(txtcash.Text) < discc Then
            MessageBox.Show("Insufficient Funds")
        Else
            ' txtTotal.Text = Val(txtSubtotal.Text) - Val(txtDiscount.Text)
            txtChange.Text = Val(txtCash.Text) - Val(txtTotal.Text)
        End If



    End Sub

    Private Sub btnToGo_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        openServer()
        ' Dim dateNow As DateTime = DateTime.Now


        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = Nothing Then
                Exit Sub
            End If

            ds = New DataSet
            da = New OleDbDataAdapter("SELECT StockQuantity,ProductName FROM tblProduct WHERE ProductName = '" & row.Cells(0).Value.ToString & "'", conn)
            da.Fill(ds, "StockQuantity")
            Dim quantity As Integer = ds.Tables("StockQuantity").Rows(0).ItemArray(0).ToString
            Dim DeducQuantity As Integer = row.Cells(1).Value
            Dim prodname As String = ds.Tables("StockQuantity").Rows(0).ItemArray(1).ToString
            Dim NewQuantity As Integer = quantity - DeducQuantity
            If quantity < DeducQuantity Then

                MessageBox.Show("      " + prodname + "  is out of stock! or Out of stock range! " + vbCrLf + "          Please reduce your quantity or select other product" + vbCrLf + "                                         Thankyou ! ")
                Exit Sub
            Else
                Call AddEditDeleteRecord("INSERT INTO tblPOS ([ItemName], [Quantity], [Total], [Vendor]) VALUES('" & row.Cells(0).Value.ToString & "', " & Integer.Parse(row.Cells(1).Value.ToString) & ", " & Integer.Parse(row.Cells(2).Value.ToString) & ",'" & txtEmployeeName.Text & "')")


                Call AddEditDeleteRecord("UPDATE tblProduct SET [StockQuantity] = '" & NewQuantity & "' WHERE ProductName = '" & row.Cells(0).Value.ToString & "'")
                MessageBox.Show("Transaction Complete!")
            End If

        Next


    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim index As Integer
        index = DataGridView2.CurrentCell.RowIndex

        'delete the selected row
        DataGridView2.Rows.RemoveAt(index)

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.TextChanged
        ' lblDate.Text = DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")
    End Sub

    Private Sub btnAddtoO_Click(sender As Object, e As EventArgs) Handles btnAddtoO.Click
        ds = New DataSet
        da = New OleDbDataAdapter("SELECT Price FROM tblProduct WHERE ProductName = '" & cmbProductList.Text & "'", conn)
        da.Fill(ds, "Price")
        Dim price As Integer = ds.Tables("Price").Rows(0).ItemArray(0).ToString
        Dim qty As Integer = txtqtyy.Text
        Dim fprice As Integer = price * qty


        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = cmbProductList.Text Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value + Val(txtqtyy.Text))
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price

                compute()
                Exit Sub

            End If

        Next
        DataGridView2.Rows.Add(cmbProductList.Text, txtqtyy.Text, fprice)
        compute()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginMod.Show()
        Me.Hide()
    End Sub

    Private Sub POSMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet
        da = New OleDbDataAdapter("SELECT FirstName,LastName FROM tblFileMaintenance WHERE AcctUsername = '" & LoginMod.txtUsername.Text & "'", conn)
        da.Fill(ds, "tblFileMaintenance")
        Dim name As String = ds.Tables("tblFileMaintenance").Rows(0).ItemArray(0).ToString & " " & ds.Tables("tblFileMaintenance").Rows(0).ItemArray(1).ToString

        txtEmployeeName.Text = name
        Timer1.Enabled = True


    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ReceiptForm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now.ToString("hh:mm:ss tt dddd, dd MMMM yyyy")
    End Sub
End Class
