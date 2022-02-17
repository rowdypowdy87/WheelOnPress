Imports System.IO.Ports
Imports System.Threading

Module Serial

    Public Structure SerialPortConfig

        Dim port_name As String
        Dim baud As Integer
        Dim parity As Parity
        Dim databits As Integer
        Dim stopbits As StopBits
        Dim handshake As Handshake
        Dim terminator As Char

    End Structure

    Public DisplacementPortConfig As SerialPortConfig
    Public PressurePortConfig As SerialPortConfig
    Public DispacementPort As SerialPort
    Public PressurePort As SerialPort


    ' Initialize port connections
    Public Sub SerialConnect()

        ' Create new instance of serialport - displacement
        If DispacementPort Is Nothing Then

            DispacementPort = New SerialPort()

            With DispacementPort

                .PortName = DisplacementPortConfig.port_name
                .BaudRate = DisplacementPortConfig.baud
                .Parity = DisplacementPortConfig.parity
                .DataBits = DisplacementPortConfig.databits
                .StopBits = DisplacementPortConfig.stopbits
                .Handshake = DisplacementPortConfig.handshake
                .Encoding = System.Text.Encoding.Default
                .NewLine = vbCr

            End With

            ' Try to open displacement COM port
            Try
                DispacementPort.Open()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
                DispacementPort.Close()
            End Try

        Else

            If Not DispacementPort.IsOpen Then

                ' Initialize displacement port
                With DispacementPort

                    .PortName = DisplacementPortConfig.port_name
                    .BaudRate = DisplacementPortConfig.baud
                    .Parity = DisplacementPortConfig.parity
                    .DataBits = DisplacementPortConfig.databits
                    .StopBits = DisplacementPortConfig.stopbits
                    .Handshake = DisplacementPortConfig.handshake
                    .Encoding = System.Text.Encoding.Default
                    .NewLine = vbCr

                End With

                ' Try to open displacement COM port
                Try
                    DispacementPort.Open()
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical)
                    DispacementPort.Close()
                End Try

            End If

        End If

        ' Create new instance of serialport - pressure gauge
        If PressurePort Is Nothing Then

            PressurePort = New SerialPort()

            With PressurePort

                .PortName = PressurePortConfig.port_name
                .BaudRate = PressurePortConfig.baud
                .Parity = PressurePortConfig.parity
                .DataBits = PressurePortConfig.databits
                .StopBits = PressurePortConfig.stopbits
                .Handshake = PressurePortConfig.handshake
                .Encoding = System.Text.Encoding.Default
                .NewLine = vbNullChar

            End With

            ' Try to open pressure gauge COM port
            Try
                PressurePort.Open()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
                PressurePort.Close()
            End Try

        Else

            If Not PressurePort.IsOpen Then

                ' Initialize pressure gauge port
                With PressurePort

                    .PortName = PressurePortConfig.port_name
                    .BaudRate = PressurePortConfig.baud
                    .Parity = PressurePortConfig.parity
                    .DataBits = PressurePortConfig.databits
                    .StopBits = PressurePortConfig.stopbits
                    .Handshake = PressurePortConfig.handshake
                    .Encoding = System.Text.Encoding.Default
                    .NewLine = vbNullChar

                End With

                ' Try to open pressure gauge COM port
                Try
                    PressurePort.Open()
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical)
                    PressurePort.Close()
                End Try

            End If

        End If


    End Sub


    ' Close connections and free memory
    Public Sub SerialEnd()

        If Not DispacementPort Is Nothing Then '
            If DispacementPort.IsOpen Then
                DispacementPort.Close()
                DispacementPort = Nothing
            End If
        End If

        If Not PressurePort Is Nothing Then
            If PressurePort.IsOpen Then
                PressurePort.Close()
                PressurePort = Nothing
            End If
        End If

    End Sub

End Module
