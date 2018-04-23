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
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Mvvm;

namespace WpfApplication1 {
    public class ViewModel : DependencyObject {
        public static DependencyProperty CurrentCustomerProperty =
   DependencyProperty.Register("CurrentCustomer", typeof(CustomerInfo),
                               typeof(ViewModel));
        public CustomerInfo CurrentCustomer {
            get { return (CustomerInfo)GetValue(CurrentCustomerProperty); }
            set { SetValue(CurrentCustomerProperty, value); }
        }

        ObservableCollection<CustomerInfo> customers;
        public ObservableCollection<CustomerInfo> Customers {
            get {
                if(customers == null) {
                    customers = new ObservableCollection<CustomerInfo>();
                    CustomerInfo customer = new CustomerInfo();
                    customer.Name = "Andrew Fouler";
                    customer.Salary = 13;
                    customer.Date = DateTime.Today;
                    customer.IsFired = false;
                    customers.Add(customer);

                    customer = new CustomerInfo();
                    customer.Name = "Margaret Peacock";
                    customer.Date = DateTime.Today.AddDays(1);
                    customer.Salary = 9;
                    customer.IsFired = true;
                    customers.Add(customer);

                    customer = new CustomerInfo();
                    customer.Name = "Nancy Davolio";
                    customer.Date = DateTime.Today.AddDays(2);
                    customer.Salary = 117;
                    customers.Add(customer);
                }
                return customers;
            }
        }
        public ICommand ShowCustomer { get; private set; }

        public ViewModel() {
            ShowCustomer = new DelegateCommand<object>(o => Show());
        }
        void Show() {
            if (CurrentCustomer != null)
            {
                string message = "Current customer:\r\nName: " + CurrentCustomer.Name +
                    "\r\nDate: " + CurrentCustomer.Date +
                    "\r\nSalary: " + CurrentCustomer.Salary +
                    "\r\nIsFired: " + CurrentCustomer.IsFired;
                MessageBox.Show(message);
            }
        }
    }
}