Imports System.IO.Ports
Imports System.IO.FileStream
Imports System.Text

Module Settings

    Public SampleRate As Integer
    Public DefaultSavePath As String
    Public ConsoleLine As String
    Public DDA() As Double = Array.CreateInstance(GetType(Double), 500)
    Public DynamicDA As Boolean = True

    Public Sub SaveSettings()

        On Error GoTo SaveSettings_Error

        Dim SaveIni As New IniFile(My.Application.Info.DirectoryPath + "\Settings\Settings.ini")

        With SaveIni

            ' Write pressure port information
            .WriteString("PRESSUREPORT", "PortName", PressurePortConfig.port_name)
            .WriteInteger("PRESSUREPORT", "BaudRate", PressurePortConfig.baud)
            .WriteInteger("PRESSUREPORT", "DataBits", PressurePortConfig.databits)
            .WriteInteger("PRESSUREPORT", "StopBits", PressurePortConfig.stopbits)
            .WriteInteger("PRESSUREPORT", "Parity", PressurePortConfig.parity)
            .WriteInteger("PRESSUREPORT", "Handshake", PressurePortConfig.handshake)
            .WriteString("PRESSUREPORT", "Terminator", PressurePortConfig.terminator)

            ' Write displacement port information
            .WriteString("DISPLACEMENTPORT", "PortName", DisplacementPortConfig.port_name)
            .WriteInteger("DISPLACEMENTPORT", "BaudRate", DisplacementPortConfig.baud)
            .WriteInteger("DISPLACEMENTPORT", "DataBits", DisplacementPortConfig.databits)
            .WriteInteger("DISPLACEMENTPORT", "StopBits", DisplacementPortConfig.stopbits)
            .WriteInteger("DISPLACEMENTPORT", "Parity", DisplacementPortConfig.parity)
            .WriteInteger("DISPLACEMENTPORT", "Handshake", DisplacementPortConfig.handshake)
            .WriteString("DISPLACEMENTPORT", "Terminator", DisplacementPortConfig.terminator)

            ' Misc options
            .WriteString("MISC", "DefaultSavePath", DefaultSavePath)
            .WriteInteger("MISC", "SampleRate", SampleRate)
            .WriteInteger("MISC", "PressureMax", MainWindow.PressureMax)
            .WriteInteger("MISC", "DynamicDDA", DynamicDA)

            SaveAdminSettings()

        End With

        SaveIni = Nothing

        Exit Sub

SaveSettings_Error:

        MsgBox("Error saving settings file, the Application will now close", vbCritical)
        SaveIni = Nothing
        End

    End Sub

    Public Sub LoadSettings()

        On Error GoTo LoadSettings_Error

        Dim SaveIni As New IniFile(My.Application.Info.DirectoryPath + "\Settings\Settings.ini")

        With SaveIni

            ' Get pressure gauge data
            PressurePortConfig.port_name = .GetString("PRESSUREPORT", "PortName", "COM7")
            PressurePortConfig.baud = .GetInteger("PRESSUREPORT", "BaudRate", 9600)
            PressurePortConfig.databits = .GetInteger("PRESSUREPORT", "DataBits", 8)
            PressurePortConfig.stopbits = .GetInteger("PRESSUREPORT", "StopBits", 2)
            PressurePortConfig.parity = .GetInteger("PRESSUREPORT", "Parity", Parity.None)
            PressurePortConfig.handshake = .GetInteger("PRESSUREPORT", "Handshake", Handshake.None)
            PressurePortConfig.terminator = vbNullChar

            ' Get displacement port information
            DisplacementPortConfig.port_name = .GetString("DISPLACEMENTPORT", "PortName", "COM9")
            DisplacementPortConfig.baud = .GetInteger("DISPLACEMENTPORT", "BaudRate", 9600)
            DisplacementPortConfig.databits = .GetInteger("DISPLACEMENTPORT", "DataBits", 8)
            DisplacementPortConfig.stopbits = .GetInteger("DISPLACEMENTPORT", "StopBits", 2)
            DisplacementPortConfig.parity = .GetInteger("DISPLACEMENTPORT", "Parity", Parity.None)
            DisplacementPortConfig.handshake = .GetInteger("DISPLACEMENTPORT", "Handshake", Handshake.None)
            DisplacementPortConfig.terminator = vbCrLf

            ' Misc options
            DefaultSavePath = .GetString("MISC", "DefaultSavePath", "")
            SampleRate = .GetInteger("MISC", "SampleRate", 100)
            MainWindow.PressureMax = .GetInteger("MISC", "PressureMax", 1)
            DynamicDA = .GetInteger("MISC", "DynamicDDA", 1)

            LoadAdminSettings()
            LoadDDA() ' Load dynamic data adjustment file

        End With

        SaveIni = Nothing

        Exit Sub

LoadSettings_Error:

        MsgBox("Error loading settings file, the Application will now close", vbCritical)
        SaveIni = Nothing
        End

    End Sub

    ' Load dynamic data adjustments
    Sub LoadDDA()

        Dim File As IO.StreamReader
        Dim i As Integer = 0

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Settings\DDA") Then
            File = My.Computer.FileSystem.OpenTextFileReader(My.Application.Info.DirectoryPath + "\Settings\DDA")

            While File.EndOfStream = False

                DDA(i) = CDbl(File.ReadLine())
                i += 1

            End While
        Else

            If DynamicDA Then
                MsgBox("Dynamic Data Adjustment master record missing, contact administrator", vbExclamation)
            End If
        End If

    End Sub

    Sub SaveAdminSettings()

        Dim AF As IO.StreamWriter

        ' Check if the file exists and if not then create it
        If Not My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Settings\OtherSettings") Then
            Dim fs As IO.FileStream = IO.File.Create(My.Application.Info.DirectoryPath + "\Settings\OtherSettings")
            fs.Close()
            fs.Dispose()
            fs = Nothing
        End If

        ' Write to setttings file
        AF = My.Computer.FileSystem.OpenTextFileWriter(My.Application.Info.DirectoryPath + "\Settings\OtherSettings", False)
        AF.WriteLine(MainWindow.RamDia)
        AF.WriteLine(MainWindow.RamMax)
        AF.Close()
        AF.Dispose()

        ' Freee memory
        AF = Nothing

    End Sub

    Sub LoadAdminSettings()

        Dim File As IO.StreamReader

        ' If file exists then LOAD it heheehehehe
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Settings\OtherSettings") Then

            File = My.Computer.FileSystem.OpenTextFileReader(My.Application.Info.DirectoryPath + "\Settings\OtherSettings")
            MainWindow.RamDia = CDbl(File.ReadLine())
            MainWindow.RamMax = CDbl(File.ReadLine())
            File.Close()
            File.Dispose()

            File = Nothing
        End If
    End Sub

End Module
