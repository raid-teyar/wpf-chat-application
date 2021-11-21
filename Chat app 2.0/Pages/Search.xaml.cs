using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Chat_app_2._0.UserControls;

namespace Chat_app_2._0.Pages
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        TextBlock searchForSomething = new TextBlock()
        {
            Text = "Search for something...",
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            FontSize = 20,
            Foreground = Brushes.Gray
        };

        

        DispatcherTimer timer = new DispatcherTimer();
        Loading loading = new Loading();

        int secounds = 0;
        public Search()
        {
            InitializeComponent();
            mainContent.Content = searchForSomething;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (secounds < 3)
            {
                secounds++;
            }
            else
            {
                timer.Stop();
                mainContent.Content = new NotFound();
            }
        }

        private void SearchBar_SearchStarted(object sender, HandyControl.Data.FunctionEventArgs<string> e)
        {
            timer.Start();
            mainContent.Content = loading;
        }
    }
}
