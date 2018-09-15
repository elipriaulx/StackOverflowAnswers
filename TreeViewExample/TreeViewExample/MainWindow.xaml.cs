using System.Windows;
using TreeViewExample.ViewModels;

namespace TreeViewExample
{
    public partial class MainWindow : Window
    {
        #region Constructors

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        #endregion
    }
}
