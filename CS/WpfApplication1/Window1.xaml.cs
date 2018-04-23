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

using System.Windows;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {

        ViewModel vm;
        public Window1() {
            InitializeComponent();
            vm = new ViewModel();
            this.DataContext = vm;
        }
    }

}
