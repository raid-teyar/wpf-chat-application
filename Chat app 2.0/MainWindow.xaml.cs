using HandyControl.Controls;
using System;
using Chat_app_2._0.Pages;



namespace Chat_app_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            InitializeComponent();
            mainFrame.Navigate(new Uri("Pages/Home.xaml", UriKind.Relative));
            
        }

        private void SideMenu_SelectionChanged(object sender, HandyControl.Data.FunctionEventArgs<object> e)
        {
            foreach (SideMenuItem item in sideMenu.Items)
            {
                if (item.IsSelected)
                {
                    switch (item.Header)
                    {
                        case "Search":
                            mainFrame.Navigate(new Search());
                            break; 
                        case "Account":
                            mainFrame.Navigate(new Account());
                            break;
                        case "Notifications":
                            mainFrame.Navigate(new Notifications());
                            break;
                        case "Settings":
                            mainFrame.Navigate(new Settings());
                            break;
                        case "Home":
                            mainFrame.Navigate(new Home());
                            break;
                        case "About":
                            mainFrame.Navigate(new About());
                            break;
                        default:
                            Growl.Error("Undefined URI!");
                            break;
                    }
                }
            }
        }
    }
}
