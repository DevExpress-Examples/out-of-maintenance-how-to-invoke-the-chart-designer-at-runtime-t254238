Imports DevExpress.Charts.Designer
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Ribbon

Namespace ChartDesignerRuntime

    Public Partial Class MainWindow
        Inherits DXRibbonWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

'#Region "#ShowDesigner"
        Private Sub btnChartDesigner_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim designer As ChartDesigner = New ChartDesigner(Me.chartControl)
            designer.Show(Me)
        End Sub
'#End Region  ' #ShowDesigner
    End Class
End Namespace
