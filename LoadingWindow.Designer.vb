﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingWindow
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
        Me.PBExport = New System.Windows.Forms.ProgressBar()
        Me.LBInformation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PBExport
        '
        Me.PBExport.Location = New System.Drawing.Point(12, 43)
        Me.PBExport.Name = "PBExport"
        Me.PBExport.Size = New System.Drawing.Size(375, 48)
        Me.PBExport.TabIndex = 0
        '
        'LBInformation
        '
        Me.LBInformation.AutoSize = True
        Me.LBInformation.Location = New System.Drawing.Point(11, 10)
        Me.LBInformation.Name = "LBInformation"
        Me.LBInformation.Size = New System.Drawing.Size(0, 17)
        Me.LBInformation.TabIndex = 1
        '
        'LoadingWindow
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 104)
        Me.Controls.Add(Me.LBInformation)
        Me.Controls.Add(Me.PBExport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoadingWindow"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Exporting Data"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBExport As ProgressBar
    Friend WithEvents LBInformation As Label
End Class
