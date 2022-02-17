<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        SerialEnd()
        SaveSettings()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelSpreadsheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AdminOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReinitializeSerialConnectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndSerialConnectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GBControls = New System.Windows.Forms.GroupBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnStopLogging = New System.Windows.Forms.Button()
        Me.BtnStartLogging = New System.Windows.Forms.Button()
        Me.GBStatus = New System.Windows.Forms.GroupBox()
        Me.LoggingLb = New System.Windows.Forms.Label()
        Me.GBOutput = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBPressure = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbCurDisplacement = New System.Windows.Forms.TextBox()
        Me.GBClass = New System.Windows.Forms.GroupBox()
        Me.CBWheelsetClass = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbMinForce = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbMaxForce = New System.Windows.Forms.TextBox()
        Me.GbSOInfo = New System.Windows.Forms.GroupBox()
        Me.CBCustomer = New System.Windows.Forms.ComboBox()
        Me.CBAxlePos = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbAxleSerial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbServiceOrder = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FDBChoosePath = New System.Windows.Forms.FolderBrowserDialog()
        Me.ExportBGWorker = New System.ComponentModel.BackgroundWorker()
        Me.GraphBGWorker = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MainGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MenuStrip1.SuspendLayout()
        Me.GBControls.SuspendLayout()
        Me.GBStatus.SuspendLayout()
        Me.GBOutput.SuspendLayout()
        Me.GBClass.SuspendLayout()
        Me.GbSOInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuSettings, Me.ConnectionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(1876, 26)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuFile
        '
        Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem1, Me.ToolStripSeparator1, Me.QuitToolStripMenuItem})
        Me.MenuFile.Name = "MenuFile"
        Me.MenuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.MenuFile.Size = New System.Drawing.Size(46, 24)
        Me.MenuFile.Text = "File"
        '
        'ExportToolStripMenuItem1
        '
        Me.ExportToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextFileToolStripMenuItem, Me.ExcelSpreadsheetToolStripMenuItem, Me.GraphToolStripMenuItem})
        Me.ExportToolStripMenuItem1.Name = "ExportToolStripMenuItem1"
        Me.ExportToolStripMenuItem1.Size = New System.Drawing.Size(155, 26)
        Me.ExportToolStripMenuItem1.Text = "Export As"
        '
        'TextFileToolStripMenuItem
        '
        Me.TextFileToolStripMenuItem.Name = "TextFileToolStripMenuItem"
        Me.TextFileToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.TextFileToolStripMenuItem.Text = "Text File"
        '
        'ExcelSpreadsheetToolStripMenuItem
        '
        Me.ExcelSpreadsheetToolStripMenuItem.Name = "ExcelSpreadsheetToolStripMenuItem"
        Me.ExcelSpreadsheetToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.ExcelSpreadsheetToolStripMenuItem.Text = "Excel Spreadsheet"
        '
        'GraphToolStripMenuItem
        '
        Me.GraphToolStripMenuItem.Name = "GraphToolStripMenuItem"
        Me.GraphToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.GraphToolStripMenuItem.Text = "Graph"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'MenuSettings
        '
        Me.MenuSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOptions, Me.ToolStripSeparator3, Me.AdminOptionsToolStripMenuItem})
        Me.MenuSettings.Name = "MenuSettings"
        Me.MenuSettings.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MenuSettings.Size = New System.Drawing.Size(76, 24)
        Me.MenuSettings.Text = "Settings"
        '
        'MenuOptions
        '
        Me.MenuOptions.Name = "MenuOptions"
        Me.MenuOptions.Size = New System.Drawing.Size(192, 26)
        Me.MenuOptions.Text = "Options"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(189, 6)
        '
        'AdminOptionsToolStripMenuItem
        '
        Me.AdminOptionsToolStripMenuItem.Name = "AdminOptionsToolStripMenuItem"
        Me.AdminOptionsToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.AdminOptionsToolStripMenuItem.Text = "Admin Options"
        '
        'ConnectionsToolStripMenuItem
        '
        Me.ConnectionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReinitializeSerialConnectionsToolStripMenuItem, Me.EndSerialConnectionsToolStripMenuItem})
        Me.ConnectionsToolStripMenuItem.Name = "ConnectionsToolStripMenuItem"
        Me.ConnectionsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConnectionsToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.ConnectionsToolStripMenuItem.Text = "Connections"
        '
        'ReinitializeSerialConnectionsToolStripMenuItem
        '
        Me.ReinitializeSerialConnectionsToolStripMenuItem.Name = "ReinitializeSerialConnectionsToolStripMenuItem"
        Me.ReinitializeSerialConnectionsToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.ReinitializeSerialConnectionsToolStripMenuItem.Text = "Connect"
        '
        'EndSerialConnectionsToolStripMenuItem
        '
        Me.EndSerialConnectionsToolStripMenuItem.Name = "EndSerialConnectionsToolStripMenuItem"
        Me.EndSerialConnectionsToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.EndSerialConnectionsToolStripMenuItem.Text = "Disconnect"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpfileToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpfileToolStripMenuItem
        '
        Me.HelpfileToolStripMenuItem.Name = "HelpfileToolStripMenuItem"
        Me.HelpfileToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.HelpfileToolStripMenuItem.Text = "Help File"
        '
        'GBControls
        '
        Me.GBControls.Controls.Add(Me.BtnReset)
        Me.GBControls.Controls.Add(Me.BtnStopLogging)
        Me.GBControls.Controls.Add(Me.BtnStartLogging)
        Me.GBControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBControls.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBControls.Location = New System.Drawing.Point(1592, 92)
        Me.GBControls.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBControls.Name = "GBControls"
        Me.GBControls.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBControls.Size = New System.Drawing.Size(208, 222)
        Me.GBControls.TabIndex = 3
        Me.GBControls.TabStop = False
        Me.GBControls.Text = "Controls"
        '
        'BtnReset
        '
        Me.BtnReset.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnReset.Location = New System.Drawing.Point(15, 91)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(185, 71)
        Me.BtnReset.TabIndex = 3
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnStopLogging
        '
        Me.BtnStopLogging.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnStopLogging.Location = New System.Drawing.Point(15, 57)
        Me.BtnStopLogging.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnStopLogging.Name = "BtnStopLogging"
        Me.BtnStopLogging.Size = New System.Drawing.Size(185, 30)
        Me.BtnStopLogging.TabIndex = 2
        Me.BtnStopLogging.Text = "Stop Logging"
        Me.BtnStopLogging.UseVisualStyleBackColor = True
        '
        'BtnStartLogging
        '
        Me.BtnStartLogging.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnStartLogging.Location = New System.Drawing.Point(15, 22)
        Me.BtnStartLogging.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnStartLogging.Name = "BtnStartLogging"
        Me.BtnStartLogging.Size = New System.Drawing.Size(185, 30)
        Me.BtnStartLogging.TabIndex = 1
        Me.BtnStartLogging.Text = "Start Logging"
        Me.BtnStartLogging.UseVisualStyleBackColor = True
        '
        'GBStatus
        '
        Me.GBStatus.Controls.Add(Me.LoggingLb)
        Me.GBStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBStatus.Location = New System.Drawing.Point(1592, 33)
        Me.GBStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBStatus.Name = "GBStatus"
        Me.GBStatus.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBStatus.Size = New System.Drawing.Size(208, 60)
        Me.GBStatus.TabIndex = 11
        Me.GBStatus.TabStop = False
        Me.GBStatus.Text = "Status"
        '
        'LoggingLb
        '
        Me.LoggingLb.AutoSize = True
        Me.LoggingLb.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoggingLb.ForeColor = System.Drawing.Color.DarkRed
        Me.LoggingLb.Location = New System.Drawing.Point(25, 22)
        Me.LoggingLb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LoggingLb.Name = "LoggingLb"
        Me.LoggingLb.Size = New System.Drawing.Size(171, 24)
        Me.LoggingLb.TabIndex = 10
        Me.LoggingLb.Text = "LOGGING STOPPED"
        Me.LoggingLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GBOutput
        '
        Me.GBOutput.Controls.Add(Me.Label9)
        Me.GBOutput.Controls.Add(Me.TBPressure)
        Me.GBOutput.Controls.Add(Me.Label2)
        Me.GBOutput.Controls.Add(Me.TbCurDisplacement)
        Me.GBOutput.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBOutput.Location = New System.Drawing.Point(1592, 767)
        Me.GBOutput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBOutput.Name = "GBOutput"
        Me.GBOutput.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBOutput.Size = New System.Drawing.Size(208, 148)
        Me.GBOutput.TabIndex = 4
        Me.GBOutput.TabStop = False
        Me.GBOutput.Text = "Output"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 28)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Current Force (Gauge)"
        '
        'TBPressure
        '
        Me.TBPressure.BackColor = System.Drawing.SystemColors.MenuText
        Me.TBPressure.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPressure.ForeColor = System.Drawing.Color.LawnGreen
        Me.TBPressure.Location = New System.Drawing.Point(16, 49)
        Me.TBPressure.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBPressure.Name = "TBPressure"
        Me.TBPressure.ReadOnly = True
        Me.TBPressure.Size = New System.Drawing.Size(184, 27)
        Me.TBPressure.TabIndex = 4
        Me.TBPressure.TabStop = False
        Me.TBPressure.Text = "Not Connected"
        Me.TBPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Current Displacement"
        '
        'TbCurDisplacement
        '
        Me.TbCurDisplacement.BackColor = System.Drawing.SystemColors.MenuText
        Me.TbCurDisplacement.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCurDisplacement.ForeColor = System.Drawing.Color.LawnGreen
        Me.TbCurDisplacement.Location = New System.Drawing.Point(13, 102)
        Me.TbCurDisplacement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbCurDisplacement.Name = "TbCurDisplacement"
        Me.TbCurDisplacement.ReadOnly = True
        Me.TbCurDisplacement.Size = New System.Drawing.Size(184, 27)
        Me.TbCurDisplacement.TabIndex = 0
        Me.TbCurDisplacement.TabStop = False
        Me.TbCurDisplacement.Text = "Not Connected"
        Me.TbCurDisplacement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GBClass
        '
        Me.GBClass.Controls.Add(Me.CBWheelsetClass)
        Me.GBClass.Controls.Add(Me.Label3)
        Me.GBClass.Controls.Add(Me.TbMinForce)
        Me.GBClass.Controls.Add(Me.Label4)
        Me.GBClass.Controls.Add(Me.TbMaxForce)
        Me.GBClass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBClass.Location = New System.Drawing.Point(1589, 583)
        Me.GBClass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBClass.Name = "GBClass"
        Me.GBClass.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBClass.Size = New System.Drawing.Size(209, 178)
        Me.GBClass.TabIndex = 5
        Me.GBClass.TabStop = False
        Me.GBClass.Text = "Wheelset Class"
        '
        'CBWheelsetClass
        '
        Me.CBWheelsetClass.BackColor = System.Drawing.SystemColors.HighlightText
        Me.CBWheelsetClass.ForeColor = System.Drawing.Color.Black
        Me.CBWheelsetClass.FormattingEnabled = True
        Me.CBWheelsetClass.Location = New System.Drawing.Point(16, 22)
        Me.CBWheelsetClass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBWheelsetClass.Name = "CBWheelsetClass"
        Me.CBWheelsetClass.Size = New System.Drawing.Size(183, 25)
        Me.CBWheelsetClass.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Minimum Force"
        '
        'TbMinForce
        '
        Me.TbMinForce.BackColor = System.Drawing.SystemColors.MenuText
        Me.TbMinForce.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbMinForce.ForeColor = System.Drawing.Color.LawnGreen
        Me.TbMinForce.Location = New System.Drawing.Point(13, 135)
        Me.TbMinForce.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbMinForce.Name = "TbMinForce"
        Me.TbMinForce.ReadOnly = True
        Me.TbMinForce.Size = New System.Drawing.Size(184, 27)
        Me.TbMinForce.TabIndex = 0
        Me.TbMinForce.TabStop = False
        Me.TbMinForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Maximum Force"
        '
        'TbMaxForce
        '
        Me.TbMaxForce.BackColor = System.Drawing.SystemColors.MenuText
        Me.TbMaxForce.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbMaxForce.ForeColor = System.Drawing.Color.LawnGreen
        Me.TbMaxForce.Location = New System.Drawing.Point(13, 84)
        Me.TbMaxForce.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbMaxForce.Name = "TbMaxForce"
        Me.TbMaxForce.ReadOnly = True
        Me.TbMaxForce.Size = New System.Drawing.Size(184, 27)
        Me.TbMaxForce.TabIndex = 0
        Me.TbMaxForce.TabStop = False
        Me.TbMaxForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GbSOInfo
        '
        Me.GbSOInfo.Controls.Add(Me.CBCustomer)
        Me.GbSOInfo.Controls.Add(Me.CBAxlePos)
        Me.GbSOInfo.Controls.Add(Me.Label8)
        Me.GbSOInfo.Controls.Add(Me.Label7)
        Me.GbSOInfo.Controls.Add(Me.TbAxleSerial)
        Me.GbSOInfo.Controls.Add(Me.Label6)
        Me.GbSOInfo.Controls.Add(Me.TbServiceOrder)
        Me.GbSOInfo.Controls.Add(Me.Label5)
        Me.GbSOInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbSOInfo.Location = New System.Drawing.Point(1591, 319)
        Me.GbSOInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbSOInfo.Name = "GbSOInfo"
        Me.GbSOInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbSOInfo.Size = New System.Drawing.Size(208, 260)
        Me.GbSOInfo.TabIndex = 6
        Me.GbSOInfo.TabStop = False
        Me.GbSOInfo.Text = "Service Order Info"
        '
        'CBCustomer
        '
        Me.CBCustomer.FormattingEnabled = True
        Me.CBCustomer.Items.AddRange(New Object() {"IME (GE)", "FMG", "WATCO", "PTA", "EDI", "AURIZON", "LORAM", "CFCLA", "MRL"})
        Me.CBCustomer.Location = New System.Drawing.Point(13, 138)
        Me.CBCustomer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBCustomer.Name = "CBCustomer"
        Me.CBCustomer.Size = New System.Drawing.Size(176, 25)
        Me.CBCustomer.TabIndex = 9
        '
        'CBAxlePos
        '
        Me.CBAxlePos.FormattingEnabled = True
        Me.CBAxlePos.Items.AddRange(New Object() {"GEAR END", "FREE END", "A SIDE", "B SIDE", "GEAR ONLY"})
        Me.CBAxlePos.Location = New System.Drawing.Point(13, 187)
        Me.CBAxlePos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBAxlePos.Name = "CBAxlePos"
        Me.CBAxlePos.Size = New System.Drawing.Size(176, 25)
        Me.CBAxlePos.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 167)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Axle Position"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 118)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Customer Name"
        '
        'TbAxleSerial
        '
        Me.TbAxleSerial.Location = New System.Drawing.Point(13, 89)
        Me.TbAxleSerial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbAxleSerial.Name = "TbAxleSerial"
        Me.TbAxleSerial.Size = New System.Drawing.Size(177, 24)
        Me.TbAxleSerial.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Axle Serial"
        '
        'TbServiceOrder
        '
        Me.TbServiceOrder.Location = New System.Drawing.Point(13, 39)
        Me.TbServiceOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbServiceOrder.Name = "TbServiceOrder"
        Me.TbServiceOrder.Size = New System.Drawing.Size(177, 24)
        Me.TbServiceOrder.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Order Number"
        '
        'ExportBGWorker
        '
        '
        'GraphBGWorker
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(32, 63)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 86)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'MainGraph
        '
        Me.MainGraph.BorderlineColor = System.Drawing.Color.Black
        Me.MainGraph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.BackColor = System.Drawing.SystemColors.Info
        ChartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal
        ChartArea1.Name = "ChartArea1"
        Me.MainGraph.ChartAreas.Add(ChartArea1)
        Me.MainGraph.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MainGraph.Location = New System.Drawing.Point(8, 38)
        Me.MainGraph.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MainGraph.Name = "MainGraph"
        Series1.BorderColor = System.Drawing.SystemColors.HotTrack
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.SystemColors.HotTrack
        Series1.Name = "Envelope"
        Series2.BorderColor = System.Drawing.Color.DarkRed
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.DarkRed
        Series2.Name = "DispPressure"
        Me.MainGraph.Series.Add(Series1)
        Me.MainGraph.Series.Add(Series2)
        Me.MainGraph.Size = New System.Drawing.Size(1568, 922)
        Me.MainGraph.TabIndex = 8
        Me.MainGraph.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left
        Title1.BorderColor = System.Drawing.Color.Transparent
        Title1.DockingOffset = 1
        Title1.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "MainTitle"
        Title1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Title1.Text = "WHEEL PRESS ON TONNAGE CHART"
        Title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Embed
        Title2.BorderColor = System.Drawing.Color.Black
        Title2.DockedToChartArea = "ChartArea1"
        Title2.Font = New System.Drawing.Font("Trebuchet MS", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "SubTitle"
        Me.MainGraph.Titles.Add(Title1)
        Me.MainGraph.Titles.Add(Title2)
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1876, 1199)
        Me.Controls.Add(Me.GBStatus)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MainGraph)
        Me.Controls.Add(Me.GBClass)
        Me.Controls.Add(Me.GbSOInfo)
        Me.Controls.Add(Me.GBOutput)
        Me.Controls.Add(Me.GBControls)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MainWindow"
        Me.Text = "Wheel Press On - UGL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GBControls.ResumeLayout(False)
        Me.GBStatus.ResumeLayout(False)
        Me.GBStatus.PerformLayout()
        Me.GBOutput.ResumeLayout(False)
        Me.GBOutput.PerformLayout()
        Me.GBClass.ResumeLayout(False)
        Me.GBClass.PerformLayout()
        Me.GbSOInfo.ResumeLayout(False)
        Me.GbSOInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuFile As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetChartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GBControls As GroupBox
    Friend WithEvents GBOutput As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnStartLogging As Button
    Friend WithEvents GBClass As GroupBox
    Friend WithEvents CBWheelsetClass As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbMinForce As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbMaxForce As TextBox
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReinitializeSerialConnectionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndSerialConnectionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnStopLogging As Button
    Friend WithEvents GbSOInfo As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbAxleSerial As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbServiceOrder As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FDBChoosePath As FolderBrowserDialog
    Friend WithEvents ExportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TextFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcelSpreadsheetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraphToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportBGWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents GraphBGWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents CBAxlePos As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MainGraph As DataVisualization.Charting.Chart
    Friend WithEvents MenuSettings As ToolStripMenuItem
    Friend WithEvents MenuOptions As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents LoggingLb As Label
    Friend WithEvents GBStatus As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CBCustomer As ComboBox
    Friend WithEvents BtnReset As Button
    Friend WithEvents AdminOptionsToolStripMenuItem As ToolStripMenuItem
    Public WithEvents TbCurDisplacement As TextBox
    Public WithEvents TBPressure As TextBox
End Class
