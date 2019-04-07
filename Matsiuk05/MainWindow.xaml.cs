using Matsiuk05.ViewModel;
using System.Windows;

namespace Matsiuk05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
                DataContext = new ProcessViewModel(delegate () { Dispatcher.Invoke(ProcessesDataGrid.Items.Refresh); });
            }
        }
    }

