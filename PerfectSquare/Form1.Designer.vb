<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnPerfectSquare = New System.Windows.Forms.Button()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 24)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(82, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a number:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(100, 21)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(70, 20)
        Me.txtNum.TabIndex = 1
        '
        'btnPerfectSquare
        '
        Me.btnPerfectSquare.Location = New System.Drawing.Point(190, 19)
        Me.btnPerfectSquare.Name = "btnPerfectSquare"
        Me.btnPerfectSquare.Size = New System.Drawing.Size(90, 23)
        Me.btnPerfectSquare.TabIndex = 2
        Me.btnPerfectSquare.Text = "Perfect Square"
        Me.btnPerfectSquare.UseVisualStyleBackColor = True
        '
        'lblAns
        '
        Me.lblAns.Location = New System.Drawing.Point(12, 55)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(268, 30)
        Me.lblAns.TabIndex = 3
        Me.lblAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 94)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.btnPerfectSquare)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Perfect Square"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents btnPerfectSquare As System.Windows.Forms.Button
    Friend WithEvents lblAns As System.Windows.Forms.Label

End Class
