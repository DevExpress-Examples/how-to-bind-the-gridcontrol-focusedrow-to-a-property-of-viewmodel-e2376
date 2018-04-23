' Developer Express Code Central Example:
' How to bind the GridControl FocusedRow to a property of ViewModel
' 
' To provide any property for the FocusedRow via xaml, the property should be the
' DependencyProperty. Inherit the ViewModel from the DependencyObject, and
' implement the CurrentRow dependency property.
' Starting with version 2013 vol 1
' the GridControl.FocusedRow property is marked as obsolete. The
' GridControl.CurrentItem/GridControl.SelectedItem property should be used
' instead.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2376

Imports System
Imports System.Windows
Imports System.Windows.Input
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Mvvm

Namespace WpfApplication1
    Public Class ViewModel
        Inherits DependencyObject

        Public Shared CurrentCustomerProperty As DependencyProperty = DependencyProperty.Register("CurrentCustomer", GetType(CustomerInfo), GetType(ViewModel))
        Public Property CurrentCustomer() As CustomerInfo
            Get
                Return DirectCast(GetValue(CurrentCustomerProperty), CustomerInfo)
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
                    customer.Date = Date.Today
                    customer.IsFired = False
                    customers_Renamed.Add(customer)

                    customer = New CustomerInfo()
                    customer.Name = "Margaret Peacock"
                    customer.Date = Date.Today.AddDays(1)
                    customer.Salary = 9
                    customer.IsFired = True
                    customers_Renamed.Add(customer)

                    customer = New CustomerInfo()
                    customer.Name = "Nancy Davolio"
                    customer.Date = Date.Today.AddDays(2)
                    customer.Salary = 117
                    customers_Renamed.Add(customer)
                End If
                Return customers_Renamed
            End Get
        End Property
        Private privateShowCustomer As ICommand
        Public Property ShowCustomer() As ICommand
            Get
                Return privateShowCustomer
            End Get
            Private Set(ByVal value As ICommand)
                privateShowCustomer = value
            End Set
        End Property

        Public Sub New()
            ShowCustomer = New DelegateCommand(Of Object)(Sub(o) Show())
        End Sub
        Private Sub Show()
            If CurrentCustomer IsNot Nothing Then
                Dim message As String = "Current customer:" & ControlChars.CrLf & "Name: " & CurrentCustomer.Name & ControlChars.CrLf & "Date: " & CurrentCustomer.Date & ControlChars.CrLf & "Salary: " & CurrentCustomer.Salary & ControlChars.CrLf & "IsFired: " & CurrentCustomer.IsFired
                MessageBox.Show(message)
            End If
        End Sub
    End Class
End Namespace