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

Namespace WpfApplication1
    Public Class CustomerInfo
        Public Property Name() As String
        Public Property Salary() As Double
        Public Property [Date]() As Date
        Public Property IsFired() As Boolean
    End Class

End Namespace
