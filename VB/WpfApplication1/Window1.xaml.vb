Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Xpf.Grid
Imports System.Windows.Threading
Imports DevExpress.Xpf.Editors.Settings
Imports System.Threading
Imports DevExpress.Data
Imports System.Windows.Markup

Namespace WpfApplication1
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window

		Private vm As ViewModel
		Public Sub New()
			InitializeComponent()
			vm = New ViewModel()
			Me.DataContext = vm
		End Sub
	End Class

End Namespace
