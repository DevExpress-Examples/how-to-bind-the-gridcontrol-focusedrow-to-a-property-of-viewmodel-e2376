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
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Core.Commands

Namespace WpfApplication1
	Public Class ViewModel
		Inherits DependencyObject
		Public Shared CurrentCustomerProperty As DependencyProperty = DependencyProperty.Register("CurrentCustomer", GetType(CustomerInfo), GetType(ViewModel))
		Public Property CurrentCustomer() As CustomerInfo
			Get
				Return CType(GetValue(CurrentCustomerProperty), CustomerInfo)
			End Get
			Set(ByVal value As CustomerInfo)
				SetValue(CurrentCustomerProperty, value)
			End Set
		End Property

		Private customers_Renamed As ObservableCollection(Of CustomerInfo)
		Public ReadOnly Property Customers() As ObservableCollection(Of CustomerInfo)
			Get
				If customers_Renamed Is Nothing Then
					customers_Renamed = New ObservableCollection(Of CustomerInfo)()
					Dim customer As New CustomerInfo()
					customer.Name = "Andrew Fouler"
					customer.Salary = 13					
					customer.IsFired = False
					customers_Renamed.Add(customer)

					customer = New CustomerInfo()
					customer.Name = "Margaret Peacock"
                    customer.Salary = 9
					customer.IsFired = True
					customers_Renamed.Add(customer)

					customer = New CustomerInfo()
					customer.Name = "Nancy Davolio"
                    customer.Salary = 117
					customers_Renamed.Add(customer)
				End If
				Return customers_Renamed
			End Get
		End Property
		Private privateMoveNextRowCommand As ICommand
		Public Property MoveNextRowCommand() As ICommand
			Get
				Return privateMoveNextRowCommand
			End Get
			Private Set(ByVal value As ICommand)
				privateMoveNextRowCommand = value
			End Set
		End Property
		Private privateMovePrevRowCommand As ICommand
		Public Property MovePrevRowCommand() As ICommand
			Get
				Return privateMovePrevRowCommand
			End Get
			Private Set(ByVal value As ICommand)
				privateMovePrevRowCommand = value
			End Set
		End Property

		Public Sub New()
            MoveNextRowCommand = New DelegateCommand(Of Object)(AddressOf MoveNextRow)
            MovePrevRowCommand = New DelegateCommand(Of Object)(AddressOf MovePrevRow)
		End Sub
		Private Sub MoveNextRow()
			Dim currentIndex As Integer = Customers.IndexOf(CurrentCustomer)
			If currentIndex < Customers.Count - 1 Then
				CurrentCustomer = Customers(currentIndex + 1)
			End If
		End Sub
		Private Sub MovePrevRow()
			Dim currentIndex As Integer = Customers.IndexOf(CurrentCustomer)
			If currentIndex > 0 Then
				CurrentCustomer = Customers(currentIndex - 1)
			End If
		End Sub
	End Class
End Namespace