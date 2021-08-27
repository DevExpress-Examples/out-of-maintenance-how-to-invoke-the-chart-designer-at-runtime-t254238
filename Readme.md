<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128569997/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T254238)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ChartDesignerRuntime/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ChartDesignerRuntime/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/ChartDesignerRuntime/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ChartDesignerRuntime/MainWindow.xaml.vb))**
<!-- default file list end -->
# How to invoke the Chart Designer at runtime


This example demonstrates how to invoke the <a href="https://documentation.devexpress.com/#WPF/CustomDocument17445">Chart Designer</a> at runtime.


<h3>Description</h3>

To show the Chart Designer to end-users, create an instance of the <a href="https://documentation.devexpress.com/#WPF/clsDevExpressChartsDesignerChartDesignertopic">ChartDesigner&nbsp;</a>class using the constructor that receives an <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsChartControltopic">ChartControl&nbsp;</a>object as a parameter. Then call the <a href="https://documentation.devexpress.com/#WPF/DevExpressChartsDesignerChartDesigner_Showtopic">ChartDesigner.Show</a>&nbsp;method.

<br/>


