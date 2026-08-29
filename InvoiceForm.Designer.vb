<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnGenerate = New Button()
        txtInvoiceId = New TextBox()
        Label1 = New Label()
        lblTotal = New Label()
        SuspendLayout()
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Location = New Point(210, 250)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(141, 31)
        btnGenerate.TabIndex = 0
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' txtInvoiceId
        ' 
        txtInvoiceId.Location = New Point(305, 122)
        txtInvoiceId.Name = "txtInvoiceId"
        txtInvoiceId.Size = New Size(112, 27)
        txtInvoiceId.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(195, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 20)
        Label1.TabIndex = 2
        Label1.Text = "Invoice Id:"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(226, 182)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(45, 20)
        lblTotal.TabIndex = 3
        lblTotal.Text = "Total:"
        ' 
        ' InvoiceForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(Label1)
        Controls.Add(txtInvoiceId)
        Controls.Add(btnGenerate)
        Name = "InvoiceForm"
        Text = "InvoiceForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents txtInvoiceId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
End Class
