Imports System.IO.Ports

Public Class OptionsWindow

    Private Sub OptionsWindow_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Set com port number
        ds_comport_cb.Text = DisplacementPortConfig.port_name
        CBPressurePort.Text = PressurePortConfig.port_name

        ' Baud rate
        dp_baudrate_tb.Text = DisplacementPortConfig.baud
        TBBaudPressure.Text = PressurePortConfig.baud

        ' Data bts
        dp_databits_cb.Text = DisplacementPortConfig.databits
        CBDataBitsPressure.Text = PressurePortConfig.databits

        ' Stop bits

        Select Case PressurePortConfig.stopbits
            Case StopBits.None : CBStopBitsPressure.Text = "0"
            Case StopBits.One : CBStopBitsPressure.Text = "1"
            Case StopBits.OnePointFive : CBStopBitsPressure.Text = "1.5"
            Case StopBits.Two : CBStopBitsPressure.Text = "2"
        End Select

        Select Case DisplacementPortConfig.stopbits
            Case StopBits.None : dp_stopbits_cb.Text = "0"
            Case StopBits.One : dp_stopbits_cb.Text = "1"
            Case StopBits.OnePointFive : dp_stopbits_cb.Text = "1.5"
            Case StopBits.Two : dp_stopbits_cb.Text = "2"
        End Select

        ' Set parity
        Select Case DisplacementPortConfig.parity
            Case Parity.None : dp_parity_cb.Text = "None"
            Case Parity.Even : dp_parity_cb.Text = "Even"
            Case Parity.Mark : dp_parity_cb.Text = "Mark"
            Case Parity.Odd : dp_parity_cb.Text = "Odd"
            Case Parity.Space : dp_parity_cb.Text = "Space"
        End Select

        Select Case PressurePortConfig.parity
            Case Parity.None : CBParityPressure.Text = "None"
            Case Parity.Even : CBParityPressure.Text = "Even"
            Case Parity.Mark : CBParityPressure.Text = "Mark"
            Case Parity.Odd : CBParityPressure.Text = "Odd"
            Case Parity.Space : CBParityPressure.Text = "Space"
        End Select

        ' Hand shake
        Select Case DisplacementPortConfig.handshake
            Case Handshake.None : dp_handshake_cb.Text = "None"
            Case Handshake.RequestToSend : dp_handshake_cb.Text = "RequestToSend"
            Case Handshake.RequestToSendXOnXOff : dp_handshake_cb.Text = "RequestToSendXOnXOff"
            Case Handshake.XOnXOff : dp_handshake_cb.Text = "XOnXOff"
        End Select

        Select Case PressurePortConfig.handshake
            Case Handshake.None : CBHandShakePressure.Text = "None"
            Case Handshake.RequestToSend : CBHandShakePressure.Text = "RequestToSend"
            Case Handshake.RequestToSendXOnXOff : CBHandShakePressure.Text = "RequestToSendXOnXOff"
            Case Handshake.XOnXOff : CBHandShakePressure.Text = "XOnXOff"
        End Select

        ' Terminator
        Select Case DisplacementPortConfig.terminator
            Case vbLf : dg_lineterm_cb.Text = "Lf"
            Case vbCr : dg_lineterm_cb.Text = "Cr"
            Case vbCrLf : dg_lineterm_cb.Text = "CrLf"
        End Select

        Select Case PressurePortConfig.terminator
            Case vbLf : CBTermPressure.Text = "Lf"
            Case vbCr : CBTermPressure.Text = "Cr"
            Case vbCrLf : CBTermPressure.Text = "CrLf"
            Case vbNullChar : CBTermPressure.Text = "NullChar"
        End Select

        If MainWindow.PressureMax = 1 Then
            CBPressureMax.Checked = True
        Else
            CBPressureMax.Checked = False
        End If

        tb_default_path.Text = DefaultSavePath

    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click

        ' Set com port number
        DisplacementPortConfig.port_name = ds_comport_cb.Text
        PressurePortConfig.port_name = CBPressurePort.Text

        ' Baud rate
        DisplacementPortConfig.baud = dp_baudrate_tb.Text
        PressurePortConfig.baud = TBBaudPressure.Text

        ' Data bts
        DisplacementPortConfig.databits = dp_databits_cb.Text
        PressurePortConfig.databits = CBDataBitsPressure.Text

        ' Stop bits

        Select Case dp_stopbits_cb.Text
            Case "0" : DisplacementPortConfig.stopbits = StopBits.None
            Case "1" : DisplacementPortConfig.stopbits = StopBits.One
            Case "1.5" : DisplacementPortConfig.stopbits = StopBits.OnePointFive
            Case "2" : DisplacementPortConfig.stopbits = StopBits.Two
        End Select

        Select Case CBStopBitsPressure.Text
            Case "0" : PressurePortConfig.stopbits = StopBits.None
            Case "1" : PressurePortConfig.stopbits = StopBits.One
            Case "1.5" : PressurePortConfig.stopbits = StopBits.OnePointFive
            Case "2" : PressurePortConfig.stopbits = StopBits.Two
        End Select

        ' Set parity

        Select Case dp_parity_cb.Text
            Case "None" : DisplacementPortConfig.parity = Parity.None
            Case "Even" : DisplacementPortConfig.parity = Parity.Even
            Case "Mark" : DisplacementPortConfig.parity = Parity.Mark
            Case "Odd" : DisplacementPortConfig.parity = Parity.Odd
            Case "Space" : DisplacementPortConfig.parity = Parity.Space
        End Select

        Select Case CBParityPressure.Text
            Case "None" : PressurePortConfig.parity = Parity.None
            Case "Even" : PressurePortConfig.parity = Parity.Even
            Case "Mark" : PressurePortConfig.parity = Parity.Mark
            Case "Odd" : PressurePortConfig.parity = Parity.Odd
            Case "Space" : PressurePortConfig.parity = Parity.Space
        End Select

        ' Hand shake
        Select Case dp_handshake_cb.Text
            Case "None" : DisplacementPortConfig.handshake = Handshake.None
            Case "RequestToSend" : DisplacementPortConfig.handshake = Handshake.RequestToSend
            Case "RequestToSendXOnXOff" : DisplacementPortConfig.handshake = Handshake.RequestToSendXOnXOff
            Case "XOnXOff" : DisplacementPortConfig.handshake = Handshake.XOnXOff
        End Select

        Select Case CBHandShakePressure.Text
            Case "None" : PressurePortConfig.handshake = Handshake.None
            Case "RequestToSend" : PressurePortConfig.handshake = Handshake.RequestToSend
            Case "RequestToSendXOnXOff" : PressurePortConfig.handshake = Handshake.RequestToSendXOnXOff
            Case "XOnXOff" : PressurePortConfig.handshake = Handshake.XOnXOff
        End Select

        Select Case dg_lineterm_cb.Text
            Case "Lf" : DisplacementPortConfig.terminator = vbLf
            Case "Cr" : DisplacementPortConfig.terminator = vbCr
            Case "CrLf" : DisplacementPortConfig.terminator = vbCrLf
        End Select

        Select Case CBTermPressure.Text
            Case "Lf" : PressurePortConfig.terminator = vbLf
            Case "Cr" : PressurePortConfig.terminator = vbCr
            Case "CrLf" : PressurePortConfig.terminator = vbCrLf
            Case "NullChar" : PressurePortConfig.terminator = vbNullChar
        End Select

        If CBPressureMax.Checked Then
            MainWindow.PressureMax = 1
        Else
            MainWindow.PressureMax = 0
        End If

        DefaultSavePath = tb_default_path.Text
        SaveSettings()
        Me.Hide()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
    End Sub

    Private Sub set_path_btn_Click(sender As Object, e As EventArgs) Handles set_path_btn.Click
        select_folder_diag.ShowDialog()

        tb_default_path.Text = select_folder_diag.SelectedPath
    End Sub
End Class