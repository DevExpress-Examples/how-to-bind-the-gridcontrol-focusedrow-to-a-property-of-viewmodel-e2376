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
