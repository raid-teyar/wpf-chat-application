using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Chat_app_2;
using Chat_app_2._0.Helpers;
using HandyControl.Controls;

namespace Chat_app_2._0.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        Uri img1 = new Uri("../src/E2tADaFVEAYJhLX.jpg", UriKind.Relative);
        Uri img2 = new Uri("../src/E0sUY2IVoAMnzU0.jpg", UriKind.Relative);
        Uri img3 = new Uri("../src/E0SigB2VUAA8RH0.jpg", UriKind.Relative);
        Uri img4 = new Uri("../src/E0IYR9TUUAIczGF.jpg", UriKind.Relative);
        public Home()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { username = "rd07", gender = Gender.Male, profile = img1 });
            users.Add(new User() { username = "mayar07", gender = Gender.Female, profile = img2 });
            users.Add(new User() { username = "bh07", gender = Gender.Male, profile = img3 });
            users.Add(new User() { username = "khalil07", gender = Gender.none, profile = img4 });
            msgUsers.ItemsSource = users;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataAccessHelper helper = new DataAccessHelper();
            helper.connectDatabase("LocalConnectionString");
        }
    }
}
