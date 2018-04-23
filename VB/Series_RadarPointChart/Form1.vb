Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_RadarPointChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a new chart.
			Dim RadarPointChart As New ChartControl()

			' Add a radar series to it.
			Dim series1 As New Series("Series 1", ViewType.RadarPoint)

			' Populate the series with points.
			series1.Points.Add(New SeriesPoint(0, 90))
			series1.Points.Add(New SeriesPoint(90, 95))
			series1.Points.Add(New SeriesPoint(180, 50))
			series1.Points.Add(New SeriesPoint(270, 55))
			series1.Points.Add(New SeriesPoint(0, 180))
			series1.Points.Add(New SeriesPoint(90, 185))
			series1.Points.Add(New SeriesPoint(180, 270))
			series1.Points.Add(New SeriesPoint(270, 275))

			' Add the series to the chart.
			RadarPointChart.Series.Add(series1)

			' Adjust the series options.
			series1.Label.Visible = False

			' Flip the diagram (if necessary).
			CType(RadarPointChart.Diagram, RadarDiagram).StartAngleInDegrees = 180
			CType(RadarPointChart.Diagram, RadarDiagram).RotationDirection = RadarDiagramRotationDirection.Counterclockwise

			' Add a title to the chart and hide the legend.
			Dim chartTitle1 As New ChartTitle()
			chartTitle1.Text = "Radar Point Chart"
			RadarPointChart.Titles.Add(chartTitle1)
			RadarPointChart.Legend.Visible = False

			' Add the chart to the form.
			RadarPointChart.Dock = DockStyle.Fill
			Me.Controls.Add(RadarPointChart)
		End Sub

	End Class
End Namespace