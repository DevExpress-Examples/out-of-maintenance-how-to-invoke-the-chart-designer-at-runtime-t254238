Imports DevExpress.Charts.Designer
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Ribbon

Namespace ChartDesignerRuntime
    Partial Public Class MainWindow
        Inherits DXRibbonWindow

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#ShowDesigner"
        Private Sub btnChartDesigner_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim designer As New ChartDesigner(chartControl)
            designer.Show(Me)
        End Sub
        #End Region ' #ShowDesigner
    End Class
End Namespace
