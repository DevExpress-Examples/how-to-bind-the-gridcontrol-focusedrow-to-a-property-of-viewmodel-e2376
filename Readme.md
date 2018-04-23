# How to bind the GridControl FocusedRow to a property of ViewModel


<p>To provide any property for the FocusedRow via xaml, the property should be the DependencyProperty. Inherit the ViewModel from the DependencyObject, and implement the CurrentRow dependency property.</p><p>Starting with version 2013 vol 1 the GridControl.FocusedRow property is marked as obsolete. The <strong>GridControl.</strong><strong>Current</strong><strong>Item</strong><strong>/GridControl</strong><strong>.SelectedItem</strong> property should be used instead.</p>

<br/>


