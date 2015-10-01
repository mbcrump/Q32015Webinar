using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Telerik.Windows.Controls;

namespace Q3_WPF_Demo
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

        private void tspControl1_ValueChanged(object sender, Telerik.Windows.Controls.TimeSpanPicker.ValueChangedEventArgs e)
        {
            MessageBox.Show("Value Changed");
        }

        private void tspControl1_DropDownOpened(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("DropDownOpened");
        }

        private void tspControl1_DropDownClosed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("DropDownClosed");
        }

        private void tspControl2_DropDownClosed(object sender, RoutedEventArgs e)
        {
            TimeSpan? totalTime = tspControl2.Value;

            var alert = new RadDesktopAlert();
            alert.Header = "Triggered Alert!";
            alert.Content = $"Hello, this message will self-destruct in {totalTime.Value.Seconds} seconds.";
            alert.ShowDuration = (int)totalTime.Value.TotalMilliseconds;

            //Add Icon from Theme
            alert.Icon = new Image { Source = Application.Current.FindResource("DesktopAlertIcon") as ImageSource, Width = 48, Height = 48 };
            alert.IconColumnWidth = 75;
            alert.IconMargin = new Thickness(0, 0, 10, 10);

            RadDesktopAlertManager manager = new RadDesktopAlertManager();
            manager.ShowAlert(alert);

        }
    }
}
