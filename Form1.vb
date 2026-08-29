Imports Microsoft.Data.Sqlite

Public Class Form1

    ' Database connection string
    Private Const connStr As String = "Data Source=invoices.db"

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) _
        Handles btnGenerate.Click

        Try
            Using conn As New SqliteConnection(connStr)
                conn.Open()

                ' VIOLATION:
                ' The form performs data access + business logic
                Dim total As Decimal = FetchAndSum(conn)

                ' The form also handles presentation formatting
                lblTotal.Text = $"Invoice Total: {total:C2}"
            End Using

        Catch ex As Exception
            MessageBox.Show(
                $"Unable to generate invoice.{Environment.NewLine}{ex.Message}",
                "Invoice Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try

    End Sub

    ' Data access and calculation are placed inside the Form class
    Private Function FetchAndSum(conn As SqliteConnection) As Decimal

        Const sql As String =
            "SELECT Quantity, UnitPrice FROM InvoiceItems"

        Dim total As Decimal = 0D

        Using cmd As New SqliteCommand(sql, conn)
            Using reader = cmd.ExecuteReader()

                While reader.Read()

                    Dim quantity As Integer =
                        Convert.ToInt32(reader("Quantity"))

                    Dim unitPrice As Decimal =
                        Convert.ToDecimal(reader("UnitPrice"))

                    ' Business logic mixed with database access
                    total += quantity * unitPrice

                End While

            End Using
        End Using

        Return total

    End Function

End Class
