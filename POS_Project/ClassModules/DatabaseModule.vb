Imports System.Data.OleDb
Module DatabaseModule

    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dr As OleDbDataReader



    Sub openServer()
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jenny\source\repos\POS_Project\databases\POS_database.mdb"
        conn.Open()

    End Sub


    Public Function OpenConnectString() As String
        Dim connectionstring As String
        connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jenny\source\repos\POS_Project\databases\POS_database.mdb"
        Return connectionstring
    End Function
    Sub datareader(ByVal sql As String)
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
    End Sub

    Sub AddEditDeleteRecord(ByVal sql As String)
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
    End Sub



    Sub retrieveRecord(ByVal sql As String)

        ds = New DataSet
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(ds, "a")
    End Sub



    Public Function openStockQuery() As DataSet
        ds.Reset()
        Dim query As String
        query = "SELECT * " &
                "FROM StockQuery"
        Try
            Using conn = New OleDbConnection
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jenny\source\repos\POS_Project\databases\POS_database.mdb"
                conn.Open()
                da = New OleDbDataAdapter(query, conn)
                da.Fill(ds, "StockQuery")
                da.Dispose()
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ds
    End Function

    Public Function openEmployeeQuery() As DataSet
        ds.Reset()
        Dim query As String
        query = "SELECT * " &
                "FROM EmployeeQuery"
        Try
            Using conn = New OleDbConnection
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jenny\source\repos\POS_Project\databases\POS_database.mdb"
                conn.Open()
                da = New OleDbDataAdapter(query, conn)
                da.Fill(ds, "EmployeeQuery")
                da.Dispose()
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ds
    End Function

    Public Function openReceivingQuery() As DataSet
        ds.Reset()
        Dim query As String
        query = "SELECT * " &
                "FROM ReceivingQuery"
        Try
            Using conn = New OleDbConnection
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jenny\source\repos\POS_Project\databases\POS_database.mdb"
                conn.Open()
                da = New OleDbDataAdapter(query, conn)
                da.Fill(ds, "ReceivingQuery")
                da.Dispose()
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ds
    End Function

    Public Function openSalesInvoiceQuery() As DataSet
        ds.Reset()
        Dim query As String
        query = "SELECT * " &
                "FROM SalesInvoiceQUery"
        Try
            Using conn = New OleDbConnection
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jenny\source\repos\POS_Project\databases\POS_database.mdb"
                conn.Open()
                da = New OleDbDataAdapter(query, conn)
                da.Fill(ds, "SalesInvoiceQuery")
                da.Dispose()
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ds
    End Function

    Public Function opentblVendor() As DataSet
        ds.Reset()
        Dim query As String
        query = "SELECT * " &
                "FROM tblVendor"
        Try
            Using conn = New OleDbConnection
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jenny\source\repos\POS_Project\databases\POS_database.mdb"
                conn.Open()
                da = New OleDbDataAdapter(query, conn)
                da.Fill(ds, "tblVendor")
                da.Dispose()
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ds
    End Function

    Public Function opentblProduct() As DataSet
        ds.Reset()
        Dim query As String
        query = "SELECT * " &
                "FROM tblProduct"
        Try
            Using conn = New OleDbConnection
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jenny\source\repos\POS_Project\databases\POS_database.mdb"
                conn.Open()
                da = New OleDbDataAdapter(query, conn)
                da.Fill(ds, "tblProduct")
                da.Dispose()
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ds
    End Function

    Public Function opentblFileMaintenance() As DataSet
        ds.Reset()
        Dim query As String
        query = "SELECT * " &
                "FROM tblFileMaintenance"
        Try
            Using conn = New OleDbConnection
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jenny\source\repos\POS_Project\databases\POS_database.mdb"
                conn.Open()
                da = New OleDbDataAdapter(query, conn)
                da.Fill(ds, "tblFileMaintenance")
                da.Dispose()
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ds
    End Function

    Public Function opentblPurchaseOrder() As DataSet
        ds.Reset()
        Dim query As String
        query = "SELECT * " &
                "FROM tblPurchaseOrder"
        Try
            Using conn = New OleDbConnection
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jenny\source\repos\POS_Project\databases\POS_database.mdb"
                conn.Open()
                da = New OleDbDataAdapter(query, conn)
                da.Fill(ds, "tblPurchaseOrder")
                da.Dispose()
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ds
    End Function

    Public Function opentblRawMat() As DataSet
        ds.Reset()
        Dim query As String
        query = "SELECT * " &
                "FROM tblRawMat"
        Try
            Using conn = New OleDbConnection
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jenny\source\repos\POS_Project\databases\POS_database.mdb"
                conn.Open()
                da = New OleDbDataAdapter(query, conn)
                da.Fill(ds, "tblRawMat")
                da.Dispose()
                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ds
    End Function

End Module
