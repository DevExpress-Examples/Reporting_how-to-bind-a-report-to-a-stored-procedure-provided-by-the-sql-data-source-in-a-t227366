Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraReports.UI

Namespace dxSample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            ShowPreview()
        End Sub
        Private Shared Sub ShowPreview()
            Dim report As New XtraReport1()
            Dim tool As New ReportPrintTool(report)
            tool.ShowPreview()
        End Sub
    End Class
End Namespace
