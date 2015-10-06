using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Q3_UWP_Demo
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            List<Data> data = new List<Data>();
            data.Add(new Data() { CompanyName = "Microsoft", Value = 9 });
            data.Add(new Data() { CompanyName = "Google", Value = 5 });
            data.Add(new Data() { CompanyName = "Apple", Value = 7 });
            data.Add(new Data() { CompanyName = "SalesForce", Value = 3 });
            data.Add(new Data() { CompanyName = "SAP", Value = 15 });

            this.chart.DataContext = data;
        }
    }
}
