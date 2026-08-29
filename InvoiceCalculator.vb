Public Class InvoiceCalculator

    Public Function Total(
        lines As List(Of InvoiceLine)) As Decimal

        Dim grandTotal As Decimal = 0D

        For Each line In lines

            Dim lineTotal As Decimal =
                line.Quantity * line.UnitPrice

            grandTotal += lineTotal

        Next

        Return grandTotal

    End Function

End Class
