<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tonnage
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
        Me.ForceDisplay = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ForceDisplay
        '
        Me.ForceDisplay.AutoSize = True
        Me.ForceDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForceDisplay.Font = New System.Drawing.Font("Segoe UI Semibold", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForceDisplay.ForeColor = System.Drawing.Color.Lime
        Me.ForceDisplay.Location = New System.Drawing.Point(0, 0)
        Me.ForceDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ForceDisplay.Name = "ForceDisplay"
        Me.ForceDisplay.Size = New System.Drawing.Size(703, 222)
        Me.ForceDisplay.TabIndex = 0
        Me.ForceDisplay.Text = "1500 kN"
        Me.ForceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ForceDisplay)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 238)
        Me.Panel1.TabIndex = 1
        '
        'Tonnage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(693, 238)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Tonnage"
        Me.ShowIcon = False
        Me.Text = "Force Output Display"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ForceDisplay As Label
    Friend WithEvents Panel1 As Panel
End Class
