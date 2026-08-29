Public Class InvoiceForm

    Private ReadOnly _repository As InvoiceRepository
    Private ReadOnly _calculator As InvoiceCalculator
    Private ReadOnly _presenter As InvoicePresenter

    Public Sub New()

        InitializeComponent()

        Dim connectionString As String =
            "Data Source=invoices.db"

        _repository =
            New InvoiceRepository(connectionString)

        _calculator =
            New InvoiceCalculator()

        _presenter =
            New InvoicePresenter()

        ' Create database table
        _repository.CreateTable()

        ' Add test data
        _repository.AddSampleData()

    End Sub

    Private Sub btnGenerate_Click(
        sender As Object,
        e As EventArgs) Handles btnGenerate.Click

        Try

            Dim invoiceId As Integer

            If Not Integer.TryParse(
                txtInvoiceId.Text, invoiceId) Then

                MessageBox.Show(
                    "Please enter a valid Invoice ID.")

                Return
            End If

            Dim lines =
                _repository.GetLines(invoiceId)

            Dim total =
                _calculator.Total(lines)

            lblTotal.Text =
                _presenter.FormatTotal(total)

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Invoice Error")

        End Try

    End Sub

End Class