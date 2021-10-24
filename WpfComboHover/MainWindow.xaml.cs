using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Extensions.DependencyInjection;

namespace WpfComboHover
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService<MainViewModel>();
        }

        public MainViewModel ViewModel => (MainViewModel)DataContext;

        private void ComboBoxItem_MouseMove(object sender, MouseEventArgs e)
        {
            ViewModel.HighlightedItem = (sender as ComboBoxItem)?.DataContext as Item;
        }
    }
}
