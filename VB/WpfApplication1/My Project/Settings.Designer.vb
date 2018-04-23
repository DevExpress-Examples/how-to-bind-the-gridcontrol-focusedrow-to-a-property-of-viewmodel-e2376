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

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
    Friend NotInheritable Partial Class Settings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace
