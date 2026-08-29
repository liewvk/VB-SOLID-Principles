Imports Microsoft.Data.Sqlite

Public Class InvoiceRepository

    Private ReadOnly _connectionString As String

    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    ' Create the InvoiceLines table
    Public Sub CreateTable()

        Const sql As String =
            "CREATE TABLE IF NOT EXISTS InvoiceLines (" &
            "Id INTEGER PRIMARY KEY AUTOINCREMENT, " &
            "InvoiceId INTEGER NOT NULL, " &
            "Description TEXT NOT NULL, " &
            "Quantity INTEGER NOT NULL, " &
            "UnitPrice REAL NOT NULL)"

        Using conn As New SqliteConnection(_connectionString)

            conn.Open()

            Using cmd As New SqliteCommand(sql, conn)
                cmd.ExecuteNonQuery()
            End Using

        End Using

    End Sub

    ' Add sample records
    Public Sub AddSampleData()

        Const sql As String =
            "INSERT INTO InvoiceLines " &
            "(InvoiceId, Description, Quantity, UnitPrice) " &
            "VALUES " &
            "(1, 'Wireless Mouse', 2, 24.95), " &
            "(1, 'USB Keyboard', 1, 49.90), " &
            "(1, 'USB-C Cable', 3, 12.50)"

        Using conn As New SqliteConnection(_connectionString)

            conn.Open()

            Using cmd As New SqliteCommand(sql, conn)
                cmd.ExecuteNonQuery()
            End Using

        End Using

    End Sub

    ' Retrieve invoice lines
    Public Function GetLines(
        invoiceId As Integer) As List(Of InvoiceLine)

        Dim lines As New List(Of InvoiceLine)

        Const sql As String =
            "SELECT Description, Quantity, UnitPrice " &
            "FROM InvoiceLines " &
            "WHERE InvoiceId = @InvoiceId"

        Using conn As New SqliteConnection(_connectionString)

            conn.Open()

            Using cmd As New SqliteCommand(sql, conn)

                cmd.Parameters.AddWithValue(
                    "@InvoiceId", invoiceId)

                Using reader = cmd.ExecuteReader()

                    While reader.Read()

                        Dim line As New InvoiceLine With {
                            .Description =
                                reader("Description").ToString(),
                            .Quantity =
                                Convert.ToInt32(reader("Quantity")),
                            .UnitPrice =
                                Convert.ToDecimal(reader("UnitPrice"))
                        }

                        lines.Add(line)

                    End While

                End Using

            End Using

        End Using

        Return lines

    End Function

End Class