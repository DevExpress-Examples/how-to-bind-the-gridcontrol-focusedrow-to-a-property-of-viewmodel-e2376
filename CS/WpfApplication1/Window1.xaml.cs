using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Wpf.Grid;
using System.Windows.Threading;
using DevExpress.Wpf.Editors.Settings;
using System.Threading;
using DevExpress.Data;
using System.Windows.Markup;

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
            gridControl1.DataSource = vm.GetData();


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            vm.CurrentRow = gridControl1.GetRow(1);

        }


    }

    public class ViewModel : DependencyObject
    {

        public static DependencyProperty CurrentRowProperty =
   DependencyProperty.Register("CurrentRow", typeof(object),
                               typeof(ViewModel));
        public object CurrentRow
        {
            get { return (object)GetValue(CurrentRowProperty); }
            set { SetValue(CurrentRowProperty, value); }
        }

        BindingList<ContactItem> coll;
        public object GetData()
        {
            coll = new BindingList<ContactItem>();
            ContactItem f1 = new ContactItem();
            f1.Name = "Abcd bla bl1111a  ";
            f1.Salary = 13d;
            f1.Date = DateTime.Today;
            f1.IsFired = false;
            coll.Add(f1);
            f1 = new ContactItem();
            f1.Name = "bla1";
            f1.Date = DateTime.Today;
            f1.Salary = 13;

            coll.Add(f1);

            return coll;
        }

        
    }

}
