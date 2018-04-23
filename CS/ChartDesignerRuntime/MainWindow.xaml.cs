using DevExpress.Charts.Designer;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Ribbon;

namespace ChartDesignerRuntime {
    public partial class MainWindow : DXRibbonWindow {
        public MainWindow() {
            InitializeComponent();
        }

        #region #ShowDesigner
        private void btnChartDesigner_ItemClick(object sender, ItemClickEventArgs e) {
            ChartDesigner designer = new ChartDesigner(chartControl);
            designer.Show(this);
        }
        #endregion #ShowDesigner
    }
}
