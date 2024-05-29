Public Class formRelax
    Private Sub btnABT_Click(sender As Object, e As EventArgs) Handles btnABT.Click

        Dim price As Integer = 110

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Assam Black Tea" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()
                Exit Sub

            End If

        Next
        POSMod.DataGridView2.Rows.Add("Assam Black Tea", "1", price)
        POSMod.compute()

    End Sub

    Private Sub btnEGBT_Click(sender As Object, e As EventArgs) Handles btnEGBT.Click

        Dim price As Integer = 110

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Earl Grey Black Tea" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Earl Grey Black Tea", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnOOT_Click(sender As Object, e As EventArgs) Handles btnOOT.Click

        Dim price As Integer = 110

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Osmanthus Oolong Tea" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price

                POSMod.compute()
                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Osmanthus Oolong Tea", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnJGT_Click(sender As Object, e As EventArgs) Handles btnJGT.Click

        Dim price As Integer = 110

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Jasmine Green Tea" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Jasmine Green Tea", "1", price)
        POSMod.compute()
    End Sub
End Class