<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptionsWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsWindow))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dg_lineterm_cb = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dp_stopbits_cb = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dp_handshake_cb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dp_databits_cb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dp_parity_cb = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ds_comport_cb = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dp_baudrate_tb = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBPressureMax = New System.Windows.Forms.CheckBox()
        Me.set_path_btn = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tb_default_path = New System.Windows.Forms.TextBox()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.select_folder_diag = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CBTermPressure = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CBStopBitsPressure = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CBHandShakePressure = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CBDataBitsPressure = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CBParityPressure = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CBPressurePort = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TBBaudPressure = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.dg_lineterm_cb)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.dp_stopbits_cb)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dp_handshake_cb)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dp_databits_cb)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dp_parity_cb)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ds_comport_cb)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dp_baudrate_tb)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 204)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Displacement Gauge"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(63, 179)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Line Terminator:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dg_lineterm_cb
        '
        Me.dg_lineterm_cb.AutoCompleteCustomSource.AddRange(New String() {"5", "8"})
        Me.dg_lineterm_cb.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_lineterm_cb.FormattingEnabled = True
        Me.dg_lineterm_cb.Items.AddRange(New Object() {"Cr", "Lf", "CrLF"})
        Me.dg_lineterm_cb.Location = New System.Drawing.Point(149, 174)
        Me.dg_lineterm_cb.Name = "dg_lineterm_cb"
        Me.dg_lineterm_cb.Size = New System.Drawing.Size(129, 23)
        Me.dg_lineterm_cb.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(98, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Stop Bits:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dp_stopbits_cb
        '
        Me.dp_stopbits_cb.AutoCompleteCustomSource.AddRange(New String() {"5", "8"})
        Me.dp_stopbits_cb.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp_stopbits_cb.FormattingEnabled = True
        Me.dp_stopbits_cb.Items.AddRange(New Object() {"0", "1", "1.5", "2"})
        Me.dp_stopbits_cb.Location = New System.Drawing.Point(149, 122)
        Me.dp_stopbits_cb.Name = "dp_stopbits_cb"
        Me.dp_stopbits_cb.Size = New System.Drawing.Size(129, 23)
        Me.dp_stopbits_cb.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(86, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Handshake:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dp_handshake_cb
        '
        Me.dp_handshake_cb.AutoCompleteCustomSource.AddRange(New String() {"5", "8"})
        Me.dp_handshake_cb.FormattingEnabled = True
        Me.dp_handshake_cb.Items.AddRange(New Object() {"None", "RequestToSend", "RequestToSendXOnXOff", "XOnXOff"})
        Me.dp_handshake_cb.Location = New System.Drawing.Point(149, 148)
        Me.dp_handshake_cb.Name = "dp_handshake_cb"
        Me.dp_handshake_cb.Size = New System.Drawing.Size(129, 23)
        Me.dp_handshake_cb.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(96, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Data Bits:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dp_databits_cb
        '
        Me.dp_databits_cb.AutoCompleteCustomSource.AddRange(New String() {"5", "8"})
        Me.dp_databits_cb.FormattingEnabled = True
        Me.dp_databits_cb.Items.AddRange(New Object() {"5", "8"})
        Me.dp_databits_cb.Location = New System.Drawing.Point(149, 96)
        Me.dp_databits_cb.Name = "dp_databits_cb"
        Me.dp_databits_cb.Size = New System.Drawing.Size(129, 23)
        Me.dp_databits_cb.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(111, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Parity:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dp_parity_cb
        '
        Me.dp_parity_cb.FormattingEnabled = True
        Me.dp_parity_cb.Items.AddRange(New Object() {"None", "Even", "Mark", "Odd", "Space"})
        Me.dp_parity_cb.Location = New System.Drawing.Point(149, 70)
        Me.dp_parity_cb.Name = "dp_parity_cb"
        Me.dp_parity_cb.Size = New System.Drawing.Size(129, 23)
        Me.dp_parity_cb.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "COM Port Number:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ds_comport_cb
        '
        Me.ds_comport_cb.FormattingEnabled = True
        Me.ds_comport_cb.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15"})
        Me.ds_comport_cb.Location = New System.Drawing.Point(149, 18)
        Me.ds_comport_cb.Name = "ds_comport_cb"
        Me.ds_comport_cb.Size = New System.Drawing.Size(129, 23)
        Me.ds_comport_cb.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(38, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Baud Rate (bits per/s):"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dp_baudrate_tb
        '
        Me.dp_baudrate_tb.Location = New System.Drawing.Point(149, 44)
        Me.dp_baudrate_tb.Name = "dp_baudrate_tb"
        Me.dp_baudrate_tb.Size = New System.Drawing.Size(129, 23)
        Me.dp_baudrate_tb.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBPressureMax)
        Me.GroupBox3.Controls.Add(Me.set_path_btn)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.tb_default_path)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(317, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(292, 414)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Logging"
        '
        'CBPressureMax
        '
        Me.CBPressureMax.AutoSize = True
        Me.CBPressureMax.Location = New System.Drawing.Point(6, 68)
        Me.CBPressureMax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBPressureMax.Name = "CBPressureMax"
        Me.CBPressureMax.Size = New System.Drawing.Size(166, 19)
        Me.CBPressureMax.TabIndex = 14
        Me.CBPressureMax.Text = "Pressure Gauge MAX only"
        Me.CBPressureMax.UseVisualStyleBackColor = True
        '
        'set_path_btn
        '
        Me.set_path_btn.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_path_btn.Location = New System.Drawing.Point(233, 38)
        Me.set_path_btn.Name = "set_path_btn"
        Me.set_path_btn.Size = New System.Drawing.Size(50, 23)
        Me.set_path_btn.TabIndex = 13
        Me.set_path_btn.Text = "Set"
        Me.set_path_btn.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Default Save Path:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tb_default_path
        '
        Me.tb_default_path.Location = New System.Drawing.Point(6, 38)
        Me.tb_default_path.Name = "tb_default_path"
        Me.tb_default_path.Size = New System.Drawing.Size(221, 23)
        Me.tb_default_path.TabIndex = 7
        '
        'btn_apply
        '
        Me.btn_apply.Location = New System.Drawing.Point(160, 441)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(144, 26)
        Me.btn_apply.TabIndex = 12
        Me.btn_apply.Text = "Apply"
        Me.btn_apply.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(316, 441)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(144, 26)
        Me.btn_cancel.TabIndex = 12
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.CBTermPressure)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.CBStopBitsPressure)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.CBHandShakePressure)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.CBDataBitsPressure)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.CBParityPressure)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.CBPressurePort)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.TBBaudPressure)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(293, 204)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Force Gauge (Pressure)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(63, 179)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 13)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Line Terminator:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CBTermPressure
        '
        Me.CBTermPressure.AutoCompleteCustomSource.AddRange(New String() {"5", "8"})
        Me.CBTermPressure.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTermPressure.FormattingEnabled = True
        Me.CBTermPressure.Items.AddRange(New Object() {"Cr", "Lf", "CrLF"})
        Me.CBTermPressure.Location = New System.Drawing.Point(149, 174)
        Me.CBTermPressure.Name = "CBTermPressure"
        Me.CBTermPressure.Size = New System.Drawing.Size(129, 23)
        Me.CBTermPressure.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(98, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Stop Bits:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CBStopBitsPressure
        '
        Me.CBStopBitsPressure.AutoCompleteCustomSource.AddRange(New String() {"5", "8"})
        Me.CBStopBitsPressure.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBStopBitsPressure.FormattingEnabled = True
        Me.CBStopBitsPressure.Items.AddRange(New Object() {"0", "1", "1.5", "2"})
        Me.CBStopBitsPressure.Location = New System.Drawing.Point(149, 122)
        Me.CBStopBitsPressure.Name = "CBStopBitsPressure"
        Me.CBStopBitsPressure.Size = New System.Drawing.Size(129, 23)
        Me.CBStopBitsPressure.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(86, 153)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Handshake:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CBHandShakePressure
        '
        Me.CBHandShakePressure.AutoCompleteCustomSource.AddRange(New String() {"5", "8"})
        Me.CBHandShakePressure.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBHandShakePressure.FormattingEnabled = True
        Me.CBHandShakePressure.Items.AddRange(New Object() {"None", "RequestToSend", "RequestToSendXOnXOff", "XOnXOff"})
        Me.CBHandShakePressure.Location = New System.Drawing.Point(149, 148)
        Me.CBHandShakePressure.Name = "CBHandShakePressure"
        Me.CBHandShakePressure.Size = New System.Drawing.Size(129, 23)
        Me.CBHandShakePressure.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(96, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Data Bits:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CBDataBitsPressure
        '
        Me.CBDataBitsPressure.AutoCompleteCustomSource.AddRange(New String() {"5", "8"})
        Me.CBDataBitsPressure.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDataBitsPressure.FormattingEnabled = True
        Me.CBDataBitsPressure.Items.AddRange(New Object() {"8", "5"})
        Me.CBDataBitsPressure.Location = New System.Drawing.Point(149, 96)
        Me.CBDataBitsPressure.Name = "CBDataBitsPressure"
        Me.CBDataBitsPressure.Size = New System.Drawing.Size(129, 23)
        Me.CBDataBitsPressure.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(111, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Parity:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CBParityPressure
        '
        Me.CBParityPressure.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBParityPressure.FormattingEnabled = True
        Me.CBParityPressure.Items.AddRange(New Object() {"None", "Even", "Mark", "Odd", "Space"})
        Me.CBParityPressure.Location = New System.Drawing.Point(149, 70)
        Me.CBParityPressure.Name = "CBParityPressure"
        Me.CBParityPressure.Size = New System.Drawing.Size(129, 23)
        Me.CBParityPressure.TabIndex = 4
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(55, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 13)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "COM Port Number:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CBPressurePort
        '
        Me.CBPressurePort.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPressurePort.FormattingEnabled = True
        Me.CBPressurePort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15"})
        Me.CBPressurePort.Location = New System.Drawing.Point(149, 18)
        Me.CBPressurePort.Name = "CBPressurePort"
        Me.CBPressurePort.Size = New System.Drawing.Size(129, 23)
        Me.CBPressurePort.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(38, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Baud Rate (bits per/s):"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TBBaudPressure
        '
        Me.TBBaudPressure.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBaudPressure.Location = New System.Drawing.Point(149, 44)
        Me.TBBaudPressure.Name = "TBBaudPressure"
        Me.TBBaudPressure.Size = New System.Drawing.Size(129, 23)
        Me.TBBaudPressure.TabIndex = 0
        '
        'OptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 481)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_apply)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OptionsWindow"
        Me.Text = "Options"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dp_handshake_cb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dp_databits_cb As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dp_parity_cb As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ds_comport_cb As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dp_baudrate_tb As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dp_stopbits_cb As ComboBox
    Friend WithEvents btn_apply As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents dg_lineterm_cb As ComboBox
    Friend WithEvents tb_default_path As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents set_path_btn As Button
    Friend WithEvents select_folder_diag As FolderBrowserDialog
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CBTermPressure As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CBStopBitsPressure As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents CBHandShakePressure As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents CBDataBitsPressure As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents CBParityPressure As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents CBPressurePort As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TBBaudPressure As TextBox
    Friend WithEvents CBPressureMax As CheckBox
End Class
