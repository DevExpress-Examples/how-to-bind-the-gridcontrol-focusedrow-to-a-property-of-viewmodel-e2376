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
Imports DevExpress.Wpf.Grid
Imports System.Windows.Threading
Imports DevExpress.Wpf.Editors.Settings
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
			gridControl1.DataSource = vm.GetData()


		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			vm.CurrentRow = gridControl1.GetRow(1)

		End Sub


	End Class

	Public Class ViewModel
		Inherits DependencyObject

		Public Shared CurrentRowProperty As DependencyProperty = DependencyProperty.Register("CurrentRow", GetType(Object), GetType(ViewModel))
		Public Property CurrentRow() As Object
			Get
				Return CObj(GetValue(CurrentRowProperty))
			End Get
			Set(ByVal value As Object)
				SetValue(CurrentRowProperty, value)
			End Set
		End Property

		Private coll As BindingList(Of ContactItem)
		Public Function GetData() As Object
			coll = New BindingList(Of ContactItem)()
			Dim f1 As New ContactItem()
			f1.Name = "Abcd bla bl1111a  "
			f1.Salary = 13R
            f1.IsFired = False
			coll.Add(f1)
			f1 = New ContactItem()
			f1.Name = "bla1"
            f1.Salary = 13
            coll.Add(f1)
            Return coll
		End Function


	End Class

End Namespace
