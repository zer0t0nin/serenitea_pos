Public Class formEnergize


    Private Sub btnMatcha_Click(sender As Object, e As EventArgs) Handles btnMatcha.Click


        Dim price As Integer = 160

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Matcha Espresso Chaffee" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Matcha Espresso Chaffee", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnOkinawa_Click(sender As Object, e As EventArgs) Handles btnOkinawa.Click

        Dim price As Integer = 140

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Okinawa Espresso Chaffee" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Okinawa Espresso Chaffee", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnHokkaido_Click(sender As Object, e As EventArgs) Handles btnHokkaido.Click

        Dim price As Integer = 140

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Hokkaido Espresso Chaffee" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price

                POSMod.compute()
                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Hokkaido Espresso Chaffee", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnAmericano_Click(sender As Object, e As EventArgs) Handles btnAmericano.Click

        Dim price As Integer = 120

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Americano Espresso" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price

                POSMod.compute()
                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Americano Espresso", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnCafLat_Click(sender As Object, e As EventArgs) Handles btnCafLat.Click

        Dim price As Integer = 125

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Cafe Latte Espresso" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Cafe Latte Espresso", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnCoffeeFro_Click(sender As Object, e As EventArgs) Handles btnCoffeeFro.Click

        Dim price As Integer = 140

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Coffee Frost Espresso" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price

                POSMod.compute()
                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Coffee Frost Espresso", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnMochLa_Click(sender As Object, e As EventArgs) Handles btnMochLa.Click

        Dim price As Integer = 140

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Mocha Latte Espresso" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Mocha Latte Espresso", "1", price)
        POSMod.compute()
    End Sub

    Private Sub btnTofLat_Click(sender As Object, e As EventArgs) Handles btnTofLat.Click

        Dim price As Integer = 150

        For Each row As DataGridViewRow In POSMod.DataGridView2.Rows
            If row.Cells(0).Value = "Toffee Latte Espresso" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                POSMod.compute()

                Exit Sub
            End If

        Next
        POSMod.DataGridView2.Rows.Add("Toffee Latte Espresso", "1", price)
        POSMod.compute()
    End Sub
End Class