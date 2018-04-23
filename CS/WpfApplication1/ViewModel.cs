using System;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Core.Commands;

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
        public ICommand MoveNextRowCommand { get; private set; }
        public ICommand MovePrevRowCommand { get; private set; }

        public ViewModel() {
            MoveNextRowCommand = new DelegateCommand<object>(o => MoveNextRow());
            MovePrevRowCommand = new DelegateCommand<object>(o => MovePrevRow());
        }
        void MoveNextRow() {
            int currentIndex = Customers.IndexOf(CurrentCustomer);
            if(currentIndex < Customers.Count - 1)
                CurrentCustomer = Customers[currentIndex + 1];
        }
        void MovePrevRow() {
            int currentIndex = Customers.IndexOf(CurrentCustomer);
            if(currentIndex > 0)
                CurrentCustomer = Customers[currentIndex - 1];
        }
    }
}