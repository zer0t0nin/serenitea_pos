Public Class formRefresh
    Public Sub btnMangYak_Click(sender As Object, e As EventArgs) Handles btnMangYak.Click

        Dim price As Integer = 110

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Mango Yakult" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()
                Exit Sub

            End If

        Next
        POSMod.DataGridView2.Rows.Add("Mango Yakult", "1", price)
        POSMod.compute()

    End Sub

    Private Sub btnLycYak_Click(sender As Object, e As EventArgs) Handles btnLycYak.Click

        Dim price As Integer = 110

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Lychee Yakult" Then

                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price

                POSMod.compute()
                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Lychee Yakult", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnGFYak_Click(sender As Object, e As EventArgs) Handles btnGFYak.Click

        Dim price As Integer = 110

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Grapefruit Yakult" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Grapefruit Yakult", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnGAYak_Click(sender As Object, e As EventArgs) Handles btnGAYak.Click

        Dim price As Integer = 110

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Green Apple Yakult" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Green Apple Yakult", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnCalYak_Click(sender As Object, e As EventArgs) Handles btnCalYak.Click

        Dim price As Integer = 110

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Calamansi Yakult" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Calamansi Yakult", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnManFru_Click(sender As Object, e As EventArgs) Handles btnManFru.Click

        Dim price As Integer = 95

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Mango Fruitea" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Mango Fruitea", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnLycFru_Click(sender As Object, e As EventArgs) Handles btnLycFru.Click

        Dim price As Integer = 95

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Lychee Fruitea" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Lychee Fruitea", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnGAFru_Click(sender As Object, e As EventArgs) Handles btnGAFru.Click

        Dim price As Integer = 95

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Green Apple Fruitea" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Green Apple Fruitea", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnGFFru_Click(sender As Object, e As EventArgs) Handles btnGFFru.Click

        Dim price As Integer = 95

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Grapefruit Fruitea" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Grapefruit Fruitea", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnCranFru_Click(sender As Object, e As EventArgs) Handles btnCranFru.Click

        Dim price As Integer = 95

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Cranberry Fruitea" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price

                POSMod.compute()
                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Cranberry Fruitea", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnCalFru_Click(sender As Object, e As EventArgs) Handles btnCalFru.Click

        Dim price As Integer = 95

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Calamansi Fruitea" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Calamansi Fruitea", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnWinSwe_Click(sender As Object, e As EventArgs) Handles btnWinSwe.Click

        Dim price As Integer = 80

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Wintermelon Sweet" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Wintermelon Sweet", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnHonCal_Click(sender As Object, e As EventArgs) Handles btnHonCal.Click

        Dim price As Integer = 100

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Honey Calamansi" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price

                POSMod.compute()
                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Honey Calamansi", "1", price)
        POSMod.compute()
    End Sub
End Class