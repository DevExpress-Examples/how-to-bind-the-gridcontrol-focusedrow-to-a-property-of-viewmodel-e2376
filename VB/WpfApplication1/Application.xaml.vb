﻿' Developer Express Code Central Example:
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
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Windows

Namespace WpfApplication1
    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Partial Public Class App
        Inherits Application

    End Class
End Namespace
