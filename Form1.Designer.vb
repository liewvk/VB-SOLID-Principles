<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGenerate = New Button()
        lblTotal = New Label()
        SuspendLayout()
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Location = New Point(263, 264)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(212, 46)
        btnGenerate.TabIndex = 0
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(258, 147)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(45, 20)
        lblTotal.TabIndex = 1
        lblTotal.Text = "Total:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(btnGenerate)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblTotal As Label

End Class
