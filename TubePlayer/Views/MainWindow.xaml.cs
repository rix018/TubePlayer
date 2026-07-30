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

namespace TubePlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void frmCtrl_winState(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button thisButton;
                thisButton = (Button)sender;

                if (thisButton.Name == "frmCtrl_min")
                {
                    WindowState = WindowState.Minimized;
                }
                else if (thisButton.Name == "frmCtrl_max")
                {
                    if (WindowState == WindowState.Maximized)
                    {
                        WindowState = WindowState.Normal;
                    }
                    else
                    {
                        WindowState = WindowState.Maximized;
                    }
                }
                else
                {
                    Application.Current.Shutdown();
                }
            }
        }

    }
}