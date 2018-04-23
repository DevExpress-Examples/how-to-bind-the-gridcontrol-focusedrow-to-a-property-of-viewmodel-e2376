// Developer Express Code Central Example:
// How to bind the GridControl FocusedRow to a property of ViewModel
// 
// To provide any property for the FocusedRow via xaml, the property should be the
// DependencyProperty. Inherit the ViewModel from the DependencyObject, and
// implement the CurrentRow dependency property.
// Starting with version 2013 vol 1
// the GridControl.FocusedRow property is marked as obsolete. The
// GridControl.CurrentItem/GridControl.SelectedItem property should be used
// instead.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2376

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
    }
}
