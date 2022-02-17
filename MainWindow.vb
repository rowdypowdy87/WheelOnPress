Imports System.IO.Ports
Imports System.Threading
Imports System.Drawing
Imports System.IO.StreamWriter
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Office.Interop
Imports System.ComponentModel
Imports outlook = Microsoft.Office.Interop.Outlook

Public Class MainWindow

    ' Global variables
    Public DisplacementData As ArrayList
    Public PressureData As ArrayList
    Public PressForceData As ArrayList
    Public TimeData As ArrayList
    Public DoLog As Boolean
    Public HighLimit As ArrayList
    Public LowLimit As ArrayList
    Public WheelsetName As ArrayList
    Public DispLimit As ArrayList
    Public DoUpdate As Boolean
    Public StartDisp As Double
    Public GetStartDisp As Boolean
    Public CurrentDisp As Double
    Public CurrentPressForce As Double
    Public CurrentPressure As Double
    Public RamDia, RamArea, RamMax As Double
    Public AdminMode As Boolean
    Public ForceGauge As Integer
    Public CanLog As Boolean
    Public PressureMax As Integer
    Public HasSent As Boolean
    Public envelope_region As Region
    Public Tonne As Tonnage

    ' //
    ' // FUNCTIONS
    ' //

    ' Resize all forms
    Private Sub ResizeForms()

        ' Resize controls
        With GBControls
            .Left = ClientSize.Width - 180
            .Top = 80
            .Width = 175
            .Height = 300
        End With

        With GbSOInfo
            .Left = ClientSize.Width - 180
            .Top = 390
            .Width = 175
            .Height = 190
        End With

        With GBOutput
            .Left = ClientSize.Width - 180
            .Top = 590
            .Width = 175
            .Height = 170
        End With

        With GBClass
            .Left = ClientSize.Width - 180
            .Top = 770
            .Width = 175
            .Height = 180
        End With

        With GBStatus
            .Left = ClientSize.Width - 180
            .Width = 175
        End With

        ' Resize graph/chart
        GraphResize(10, 40, ClientSize.Width - 200, ClientSize.Height - 45, MainGraph)

        ' Resize buttons
        TbCurDisplacement.Width = 155
        TbMaxForce.Width = 155
        TbMinForce.Width = 155
        TbServiceOrder.Width = 155
        CBCustomer.Width = 155
        TbAxleSerial.Width = 155
        BtnStartLogging.Width = 155
        BtnStopLogging.Width = 155
        CBWheelsetClass.Width = 155
        BtnReset.Width = 155
        CBAxlePos.Width = 155
        TBPressure.Width = 155

    End Sub

    ' Load wheel class information
    Private Sub LoadClasses()

        Dim Ini As New IniFile(My.Application.Info.DirectoryPath + "\Settings\WheelClasses.ini")
        Dim Count, i As Integer
        Dim Name As String

        WheelsetName = New ArrayList(100)
        HighLimit = New ArrayList(100)
        LowLimit = New ArrayList(100)
        DispLimit = New ArrayList(100)

        ' Load wheelset classes.ini
        With Ini

            Count = .GetString("SLOTS", "Count", 0)

            For i = 1 To Count

                Name = .GetString("SLOTS", "Name" + CStr(i), "")
                WheelsetName.Add(Name)
                HighLimit.Add(.GetInteger("SLOTS", "High" + CStr(i), 0))
                LowLimit.Add(.GetInteger("SLOTS", "Low" + CStr(i), 0))
                DispLimit.Add(.GetInteger("SLOTS", "DMAX" + CStr(i), 250))

                CBWheelsetClass.Items.Add(Name)

            Next i

            ' Verify the file has loaded
            If CBWheelsetClass.Items.Count = 0 Then

                Exit Sub

            End If

            CBWheelsetClass.SelectedIndex = 0

        End With

        Ini = Nothing

    End Sub

    ' Read data from force input
    Private Sub ReadPressureData()

        Dim PressureString As String
        Dim TPress As Double

        If PressurePort IsNot Nothing Then

            If PressurePort.IsOpen() Then

                PressurePort.Write("255:R:MRMD" + vbNullChar)

                PressureString = PressurePort.ReadLine()

                PressureString = Replace(PressureString, "001:F:MRMD:", "")
                PressureString = Replace(PressureString, ":KPA[00]", "")
                TPress = Val(PressureString)

                If TPress < 0 Then TPress = 0

                If PressureMax = 1 And DoLog Then
                    If TPress > CurrentPressure Then
                        CurrentPressure = TPress
                        CurrentPressForce = CInt(PressureToForce(CurrentPressure))
                    End If
                Else
                    CurrentPressure = TPress
                    CurrentPressForce = CInt(PressureToForce(CurrentPressure))
                End If

            Else
                CurrentPressure = -1
            End If
        Else
            CurrentPressure = -1
        End If

    End Sub

    ' Read data from displacement data
    Private Sub ReadDisplacementData()

        Dim DisplacementString As String

        If DispacementPort IsNot Nothing Then

            If DispacementPort.IsOpen Then

                ' Receive incomming data
                DisplacementString = DispacementPort.ReadLine()
                DisplacementString = DisplacementString.Replace("*001", "")
                DisplacementString = DisplacementString.Replace("+", "")
                DisplacementString = DisplacementString.Replace("-", "")

                CurrentDisp = Val(DisplacementString)

            Else
                CurrentDisp = -1
            End If
        Else
            CurrentDisp = -1
        End If

    End Sub

    ' Add to force array list
    Private Sub LogForcePressure(NewData As Double, NewForce As Double)

        PressForceData.Add(NewForce)
        PressureData.Add(NewData)
    End Sub

    ' Add to force array list
    Private Sub LogTime()
        TimeData.Add(DateTime.Now.ToString())
    End Sub

    ' Add to displacement array list
    Private Sub LogDisplacement(NewData As Double)
        DisplacementData.Add(NewData)
    End Sub

    ' Save data as text
    Private Sub SaveAsText()

        Dim TextFile As System.IO.StreamWriter
        Dim i As Integer

        ' Open text file
        TextFile = My.Computer.FileSystem.OpenTextFileWriter(DefaultSavePath + "\DataLog.txt", False)

        ' Write data to text file
        For i = 1 To DisplacementData.Count - 1 : TextFile.WriteLine(CStr(PressForceData.Item(i)) + " " + CStr(DisplacementData.Item(i))) : Next i

        ' Close text file

    End Sub

    ' Clear array lists and notes
    Private Sub LogClear()

        DisplacementData.Clear()
        'ForceData.Clear()
        PressureData.Clear()
        TimeData.Clear()
        PressForceData.Clear()

    End Sub

    ' Resize event for main window
    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ' Resize graph to window client
        GraphResize(10, 40, ClientSize.Width - 200, ClientSize.Height - 65, MainGraph)

        ' Resize forms to window client
        ResizeForms()

        ' Redraw as resizing
        ResizeRedraw = True

    End Sub

    ' Open options
    Private Sub MenuOptions_Click(sender As Object, e As EventArgs) Handles MenuOptions.Click

        Dim Options As New OptionsWindow
        Options.Show()

    End Sub

    Private Sub CBWheelsetClass_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBWheelsetClass.SelectedValueChanged

        Dim ForceHigh, ForceLow, DispMax As Integer

        ForceHigh = HighLimit.Item(CBWheelsetClass.SelectedIndex)
        ForceLow = LowLimit.Item(CBWheelsetClass.SelectedIndex)
        DispMax = DispLimit.Item(CBWheelsetClass.SelectedIndex)

        TbMaxForce.Text = CStr(ForceHigh)
        TbMinForce.Text = CStr(ForceLow)

        MainGraph.Titles("SubTitle").Text = CStr(CBWheelsetClass.Text) & " - " & CBAxlePos.Text & " - " & TbServiceOrder.Text & " - " & TbAxleSerial.Text

        GraphSetEnvelope(Val(TbMaxForce.Text), Val(TbMinForce.Text), DispMax)
        SetMinMax(ForceLow, ForceHigh, DispMax, MainGraph)

    End Sub

    Private Sub ReinitializeSerialConnectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReinitializeSerialConnectionsToolStripMenuItem.Click
        SerialConnect()
    End Sub

    Private Sub EndSerialConnectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndSerialConnectionsToolStripMenuItem.Click
        SerialEnd()
    End Sub

    Private Sub ExportToSpreadsheet()

RetryExport_Label:

        Dim ExcelApp As Excel.Application
        Dim ExportBook As Excel.Workbook
        Dim ExportSheet As Excel.Worksheet
        Dim ExportLoader As New LoadingWindow
        Dim I As Integer
        Dim SavePath As String

        On Error GoTo ExportSpreadSheet_Error

        ExportLoader.Show()
        ExportLoader.LBInformation.Text = "Determining File Path.."
        ExportLoader.PBExport.Value = 0

        ' Test if directory exists
        If Not System.IO.Directory.Exists(DefaultSavePath & "\") Then

            SavePath = Environment.GetEnvironmentVariable("USERPROFILE") + "\Desktop"
            MsgBox("Cannot connect to server folder, files will be saved on Desktop.", vbExclamation)
        Else
            SavePath = DefaultSavePath
        End If

        ExportLoader.LBInformation.Text = "Exporting Data.."
        ExportLoader.PBExport.Value = 10

        ExcelApp = New Excel.Application()
        ExportBook = ExcelApp.Workbooks.Add()
        ExportSheet = ExportBook.Sheets(1)

        ExcelApp.Visible = True

        Dim PStep As Double

        PStep = 85 / PressForceData.Count

        ' Create titles
        With ExportSheet

            .Name = "Data"
            .Range("A1").Value = "Gauge Pressure (kPA)"
            .Range("B1").Value = "Gauge Force (kN - Converted)"
            .Range("C1").Value = "Displacement (mm)"
            .Range("D1").Value = "Time"

            For I = 1 To PressForceData.Count

                .Range("A" + CStr(I + 1)).Value = PressureData.Item(I - 1)
                .Range("B" + CStr(I + 1)).Value = PressForceData.Item(I - 1)
                .Range("C" + CStr(I + 1)).Value = DisplacementData.Item(I - 1)
                .Range("D" + CStr(I + 1)).Value = TimeData.Item(I - 1)

                ExportLoader.PBExport.Value = 10 + (I * PStep)

            Next

            ' Convert to table
            .ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange, .UsedRange, XlListObjectHasHeaders:=Excel.XlYesNoGuess.xlYes)

            ExportLoader.LBInformation.Text = "Exporting Graph.."
            ExportLoader.PBExport.Value = 90

            MainGraph.SaveImage(Environment.GetEnvironmentVariable("TEMP") + "\chart.bmp", ChartImageFormat.Bmp)

            .Shapes.AddPicture(Environment.GetEnvironmentVariable("TEMP") + "\chart.bmp", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 350, 10, 600, 400)

        End With

        Dim SONum, AXNum, CustName, AxleEnd As String

        SONum = TbServiceOrder.Text
        AXNum = TbAxleSerial.Text
        CustName = CBCustomer.Text
        AxleEnd = CBAxlePos.Text

        ExportLoader.LBInformation.Text = "Saving File.."
        ExportLoader.PBExport.Value = 95

        ' Save to default folder
        With ExcelApp

            .DisplayAlerts = False
            ExportBook.SaveAs(DefaultSavePath + "\Wheel Press On - " + SONum + " - " + AxleEnd + " - " + AXNum + " - " + CustName + ".xlsx")
            ExportBook.Close()
            .DisplayAlerts = True
            .Quit()

            ' release object from memory
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelApp)

        End With

        ExportLoader.Close()


        MsgBox("File saved to " + DefaultSavePath + "\Wheel Press On - " + SONum + " - " + AxleEnd + " - " + AXNum + " - " + CustName + ".xlsx", vbInformation)

        ExportSheet = Nothing
        ExportBook = Nothing
        ExcelApp = Nothing
        ExportLoader = Nothing

        Exit Sub

ExportSpreadSheet_Error:

        If MsgBox("There was an error saving the file, do you want to try again", vbYesNo + vbCritical) = vbYes Then

            ' Close the application
            If ExcelApp IsNot Nothing Then
                ExcelApp.Quit()
            End If

            GoTo RetryExport_Label

        End If

    End Sub

    ' Set force text box text
    Private Sub SetPressureText(NewText As String)
        If TBPressure.InvokeRequired Then
            TBPressure.Invoke(New Action(Of Object)(AddressOf SetPressureText), NewText)
        End If
        TBPressure.Text = NewText
    End Sub

    Private Sub SetPressureTextHUD(NewText As String)
        If Tonne.ForceDisplay.InvokeRequired Then
            Tonne.ForceDisplay.Invoke(New Action(Of Object)(AddressOf SetPressureTextHUD), NewText)
        End If
        Tonne.ForceDisplay.Text = NewText
    End Sub

    ' Set displacement text box text
    Private Sub SetDispText(NewText As String)
        If TbCurDisplacement.InvokeRequired Then
            TbCurDisplacement.Invoke(New Action(Of Object)(AddressOf SetDispText), NewText)
        Else
            TbCurDisplacement.Text = NewText
        End If
    End Sub

    Private Delegate Sub GraphAddPoint_D(force As Integer, disp As Integer)

    Private Sub GraphAddPointP(force As Integer, disp As Integer)

        ' Invoke 
        If MainGraph.InvokeRequired Then

            Dim Del As New GraphAddPoint_D(AddressOf GraphAddPointP)

            MainGraph.Invoke(Del, force, disp)

        Else

            If Not first_log Then

                If disp < 10 Then
                    first_log = True
                End If

            Else

                MainGraph.Series("DispPressure").Points.AddXY(disp, force)

            End If

        End If


    End Sub

    ' //
    ' // EVENT FUNCTIONS
    ' //

    ' Form load event
    Private Sub PressOn_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Set minimum form size
        MinimumSize = New System.Drawing.Size(1600, 1024)

        ' Initialize graph
        GraphInit()

        ' Initial positions
        ResizeForms()

        Tonne = New Tonnage()
        Tonne.Show()

        ' Set logging off
        DoLog = False
        DisplacementData = New ArrayList()
        PressureData = New ArrayList()
        TimeData = New ArrayList()
        PressForceData = New ArrayList()
        StartDisp = 0
        GetStartDisp = False
        CurrentDisp = -1.0
        CurrentPressForce = -1.0
        CurrentPressure = 0
        CanLog = False
        PressureMax = False
        HasSent = False
        RamDia = 558.8

        ' Set default save path
        DefaultSavePath = Environment.GetEnvironmentVariable("USERPROFILE") + "\Desktop"

        ' Load settings
        LoadSettings()

        ' Load wheel classes
        LoadClasses()

        AdminMode = True
        MenuSettings.Enabled = AdminMode
        MenuFile.Enabled = AdminMode
        BtnStopLogging.Enabled = AdminMode

        ' Start the background update process
        GraphBGWorker.RunWorkerAsync()

    End Sub

    Function PressureToForce(CP As Double) As Double

        Dim InputPressure, OutputForce, Test As Double

        Test = (Math.PI * ((550 / 2) ^ 2)) / 1000

        InputPressure = CP * 1000               ' Convert to pA
        OutputForce = (InputPressure * 0.225)   ' Calculate force in N
        Return OutputForce / 1000               ' Convert force to kN (decimel place filtered)

    End Function

    ' Reset application
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

        If MsgBox("Are you sure you want to reset the data?", vbQuestion + vbYesNo) = vbYes Then

            ' Stop logging
            DoLog = False
            GetStartDisp = False
            CurrentDisp = 0.0
            CurrentPressure = 0.0
            CurrentPressForce = 0.0
            StartDisp = 0.0
            HasSent = False

            ' Clear chart
            GraphClear()

            ' Clear log
            LogClear()

            MsgBox("Data reset!", vbInformation)

        End If

    End Sub

    ' Start logging
    Private Sub BtnStartLogging_Click(sender As Object, e As EventArgs) Handles BtnStartLogging.Click

        ' Verify inputs
        If TbServiceOrder.Text = "" Or CBCustomer.Text = "" Or TbAxleSerial.Text = "" Or CBAxlePos.Text = "" Then

            MsgBox("Please fill in all fields in Service Order Info section, logging will not start until this is filled.", vbExclamation)
            Exit Sub
        Else

            ' Start logging
            DoLog = True
            StartDisp = CurrentDisp

            ' Update logging timer
            With LoggingLb

                .Text = "LOGGING STARTED"
                .ForeColor = Color.DarkGreen

            End With

        End If

    End Sub

    ' Stop logging
    Private Sub BtnStopLogging_Click(sender As Object, e As EventArgs) Handles BtnStopLogging.Click

        If DoLog Then

            ' Export to spreadsheet
            ExportToSpreadsheet()

            If HasSent Then

                MsgBox("THIS SESSION HAS GONE OUT OF ALLOWED ENVELOPE, PLEASE REPORT THIS TO SUPERVISOR FOR FURTHER INVESTIGATION", MsgBoxStyle.Critical, "WHEEL PRESS ON FAILURE")
                ' SendMeMail(CBAxlePos.Text & " - " & TbServiceOrder.Text) ' Send me an email saying BAD! >.<
                HasSent = False

            End If

            ' Update variables
            DoLog = False
            GetStartDisp = False
            CanLog = False
            HasSent = False

            ' Update logging timer
            With LoggingLb

                .Text = "LOGGING STOPPED"
                .ForeColor = Color.DarkRed

            End With

        End If

    End Sub

    Private Sub TextFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextFileToolStripMenuItem.Click
        SaveAsText()
    End Sub

    Private Sub ExcelSpreadsheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelSpreadsheetToolStripMenuItem.Click
        ExportBGWorker.RunWorkerAsync()
    End Sub

    ' Export chart
    Private Sub GraphToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraphToolStripMenuItem.Click

        Dim Path As String

        If MsgBox("Do you want to specify the save location?", vbYesNo + vbInformation) = vbNo Then

            MainGraph.SaveImage(DefaultSavePath + "\chart.png", ChartImageFormat.Png)
            MsgBox("Saved Chart to " + DefaultSavePath + "\Chart.png")

        Else

            FDBChoosePath.ShowDialog()

            Path = FDBChoosePath.SelectedPath

            If Path <> "" Then

                MainGraph.SaveImage(Path + "\chart.png", ChartImageFormat.Png)
                MsgBox("Saved Chart to " + Path + "\Chart.png")

            End If

        End If

    End Sub


    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click

        GraphBGWorker.CancelAsync()
        ExportBGWorker.CancelAsync()
        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Dim AboutWindow As About

        AboutWindow = New About

        AboutWindow.Show()

    End Sub

    ' Export to spreadsheet
    Private Sub ExportBGWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles ExportBGWorker.DoWork

        Try
            ExportToSpreadsheet()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            ExportBGWorker.CancelAsync()
        End Try

    End Sub


    ' Update graph and read serial connections
    Private Sub GraphBGWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles GraphBGWorker.DoWork

        ' Connect Serial
        SerialConnect()

        Do While True

            ReadPressureData()
            ReadDisplacementData()

            ' If we are receiving data
            If CurrentDisp <> -1 Then

                ' If data if coming through add to graph
                If DoLog Then

                    ' Log data
                    LogForcePressure(CurrentPressure, CurrentPressForce)
                    LogDisplacement(CurrentDisp)
                    LogTime()

                    ' Add to graph
                    GraphAddPointP(CurrentPressForce, CurrentDisp - StartDisp)

                End If

            End If

            ' Update texts
            SetPressureText($"{CurrentPressForce} kN")
            SetPressureTextHUD($"{CurrentPressForce} kN")
            SetDispText($"{CurrentDisp} mm")

        Loop

    End Sub

    Private Sub TbServiceOrder_TextChanged(sender As Object, e As EventArgs) Handles TbServiceOrder.TextChanged
        MainGraph.Titles("SubTitle").Text = CStr(CBWheelsetClass.Text) & " - " & CBAxlePos.Text & " - " & TbServiceOrder.Text & " - " & TbAxleSerial.Text & " - (" & CBCustomer.Text & ")"
    End Sub

    Private Sub TbAxleSerial_TextChanged(sender As Object, e As EventArgs) Handles TbAxleSerial.TextChanged
        MainGraph.Titles("SubTitle").Text = CStr(CBWheelsetClass.Text) & " - " & CBAxlePos.Text & " - " & TbServiceOrder.Text & " - " & TbAxleSerial.Text & " - (" & CBCustomer.Text & ")"
    End Sub


    Private Sub CBCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCustomer.SelectedIndexChanged
        MainGraph.Titles("SubTitle").Text = CStr(CBWheelsetClass.Text) & " - " & CBAxlePos.Text & " - " & TbServiceOrder.Text & " - " & TbAxleSerial.Text & " - (" & CBCustomer.Text & ")"
    End Sub

    Private Sub CBAxlePos_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBAxlePos.SelectedValueChanged
        MainGraph.Titles("SubTitle").Text = CStr(CBWheelsetClass.Text) & " - " & CBAxlePos.Text & " - " & TbServiceOrder.Text & " - " & TbAxleSerial.Text & " - (" & CBCustomer.Text & ")"
    End Sub

    ' Check envelope
    Private Sub MainGraph_PostPaint(sender As Object, e As ChartPaintEventArgs) Handles MainGraph.PostPaint

        Dim envelope_path As New Drawing2D.GraphicsPath
        Dim new_points() As PointF = Array.CreateInstance(GetType(PointF), 9)

        ' Start position
        new_points(0).X = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.X, 0)
        new_points(0).Y = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.Y, 0)
        new_points(0) = e.ChartGraphics.GetAbsolutePoint(new_points(0))

        new_points(1).X = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.X, e.Chart.Series("Envelope").Points(0).XValue)
        new_points(1).Y = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.Y, e.Chart.Series("Envelope").Points(0).YValues.First)
        new_points(1) = e.ChartGraphics.GetAbsolutePoint(new_points(1))

        new_points(2).X = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.X, e.Chart.Series("Envelope").Points(1).XValue)
        new_points(2).Y = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.Y, e.Chart.Series("Envelope").Points(1).YValues.First)
        new_points(2) = e.ChartGraphics.GetAbsolutePoint(new_points(2))

        new_points(3).X = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.X, e.Chart.Series("Envelope").Points(2).XValue)
        new_points(3).Y = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.Y, e.Chart.Series("Envelope").Points(2).YValues.First)
        new_points(3) = e.ChartGraphics.GetAbsolutePoint(new_points(3))

        new_points(4).X = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.X, e.Chart.Series("Envelope").Points(3).XValue)
        new_points(4).Y = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.Y, e.Chart.Series("Envelope").Points(3).YValues.First)
        new_points(4) = e.ChartGraphics.GetAbsolutePoint(new_points(4))

        new_points(5).X = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.X, e.Chart.Series("Envelope").Points(4).XValue)
        new_points(5).Y = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.Y, e.Chart.Series("Envelope").Points(4).YValues.First)
        new_points(5) = e.ChartGraphics.GetAbsolutePoint(new_points(5))

        new_points(6).X = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.X, e.Chart.Series("Envelope").Points(5).XValue)
        new_points(6).Y = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.Y, e.Chart.Series("Envelope").Points(5).YValues.First)
        new_points(6) = e.ChartGraphics.GetAbsolutePoint(new_points(6))

        ' End position
        new_points(7).X = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.X, 0)
        new_points(7).Y = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.Y, 0)
        new_points(7) = e.ChartGraphics.GetAbsolutePoint(new_points(7))

        new_points(8).X = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.X, 0)
        new_points(8).Y = e.ChartGraphics.GetPositionFromAxis("ChartArea1", AxisName.Y, 0)
        new_points(8) = e.ChartGraphics.GetAbsolutePoint(new_points(8))

        ' Add to region
        envelope_path.AddPolygon(new_points)
        envelope_region = New Region(envelope_path)

    End Sub

    Private Sub MainGraph_Click(sender As Object, e As EventArgs) Handles MainGraph.Click

    End Sub

    Private Sub ShowTonnageHUDToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Tonne.Visible Then
            Tonne.Hide()
        Else
            Tonne.Show()
        End If
    End Sub

    Private Sub AdminOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminOptionsToolStripMenuItem.Click

        If InputBox("Enter admin password") <> "Bas1002" Then
            MsgBox("Incorrect Password!", vbExclamation)
            Exit Sub
        Else
            Dim Admin As New AdminOptionsWindow
            Admin.Show()
        End If
    End Sub

    ' Clear memory of arrays
    Private Sub MainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        DisplacementData = Nothing
        PressureData = Nothing
        PressForceData = Nothing
        TimeData = Nothing
        HighLimit = Nothing
        LowLimit = Nothing
        WheelsetName = Nothing
        DispLimit = Nothing
    End Sub
End Class
