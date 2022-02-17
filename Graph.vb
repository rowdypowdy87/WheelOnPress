Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Region

Module Graph

    Public first_log As Boolean
    Public MaxLine, MinLine As StripLine

    Sub GraphInit()

        On Error GoTo GraphInit_Error

        MaxLine = New StripLine()
        MinLine = New StripLine()

        With MaxLine

            .Interval = 0
            .IntervalOffset = 3000
            .BorderWidth = 1
            .Text = "Maximum Force"
            .Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .BorderColor = System.Drawing.Color.Red

        End With

        With MinLine

            .Interval = 0
            .IntervalOffset = 0
            .BorderWidth = 1
            .Text = "Minimum Force"
            .Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .BorderColor = System.Drawing.Color.Red

        End With

        With MainWindow.MainGraph.ChartAreas("ChartArea1")

            '.BackColor = Color.Indigo
            .BorderColor = Color.LightGray
            .BorderDashStyle = ChartDashStyle.Solid
            .BorderWidth = 1
            .ShadowOffset = 5


            .AxisX.Title = "Displacement (mm)"
            .AxisX.TitleFont = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .AxisX.MajorGrid.LineColor = Color.LightBlue
            .AxisX.Maximum = 300
            .AxisX.Minimum = 0


            .AxisY.Title = "Force (kN)"
            .AxisY.TitleFont = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .AxisY.MajorGrid.LineColor = Color.LightGray
            .AxisY.Maximum = 2500
            .AxisY.Minimum = 0
            .AxisY.StripLines.Add(MaxLine)
            .AxisY.StripLines.Add(MinLine)

        End With


        first_log = False

        Exit Sub

GraphInit_Error:

        MsgBox("Error initializing Graph, the Application will now close", vbCritical)
        End

    End Sub

    Public Sub GraphClear()

        MainWindow.MainGraph.Series("DispPressure").Points.Clear()

    End Sub

    Public Sub GraphSetEnvelope(MaxForce As Integer, MinForce As Integer, MaxDisp As Integer)

        With MainWindow.MainGraph.Series("Envelope")

            .Points.Clear()
            .Points.AddXY(MaxDisp * 0.25, 0)
            .Points.AddXY(MaxDisp * 0.5, MinForce * 0.66666)
            .Points.AddXY(MaxDisp, MinForce)
            .Points.AddXY(MaxDisp, MaxForce)
            .Points.AddXY(MaxDisp * 0.75, MaxForce)
            .Points.AddXY(0, MinForce * 0.3)

        End With

    End Sub


    Sub GraphResize(x As Integer, y As Integer, w As Integer, h As Integer, i_graph As Chart)

        With i_graph

            .Left = x
            .Top = y
            .Width = w
            .Height = h

        End With

    End Sub

    Sub SetMinMax(Min As Integer, Max As Integer, DMax As Integer, IGraph As Chart)

        MainWindow.MainGraph.ChartAreas("ChartArea1").AxisY.Maximum = Max + 500

        MinLine.IntervalOffset = Min
        MaxLine.IntervalOffset = Max

        With MainWindow.MainGraph.ChartAreas("ChartArea1")

            .AxisX.Maximum = DMax + 50
            .AxisY.Maximum = Max + 500

        End With

    End Sub

    Public Function GetMax() As Double

        Return MaxLine.IntervalOffset

    End Function

    Public Function GetMin() As Double

        Return MinLine.IntervalOffset

    End Function

End Module
