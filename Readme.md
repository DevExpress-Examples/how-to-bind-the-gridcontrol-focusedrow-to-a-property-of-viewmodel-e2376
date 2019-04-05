<!-- default file list -->
*Files to look at*:

* [Customer.cs](./CS/WpfApplication1/Customer.cs) (VB: [Customer.vb](./VB/WpfApplication1/Customer.vb))
* [Window1.xaml](./CS/WpfApplication1/Window1.xaml) (VB: [Window1.xaml](./VB/WpfApplication1/Window1.xaml))
* [Window1.xaml.cs](./CS/WpfApplication1/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/WpfApplication1/Window1.xaml.vb))
<!-- default file list end -->
# How to bind the GridControl FocusedRow to a property of ViewModel


<p>To provide any property for the FocusedRow via xaml, the property should be the DependencyProperty. Inherit the ViewModel from the DependencyObject, and implement the CurrentRow dependency property.</p><p>Starting with version 2013 vol 1 the GridControl.FocusedRow property is marked as obsolete. The <strong>GridControl.</strong><strong>Current</strong><strong>Item</strong><strong>/GridControl</strong><strong>.SelectedItem</strong> property should be used instead.</p>

<br/>


