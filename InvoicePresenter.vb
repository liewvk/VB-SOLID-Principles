Public Class InvoicePresenter

    Public Function FormatTotal(total As Decimal) As String

        Return $"Invoice Total: {total:C2}"

    End Function

End Class
