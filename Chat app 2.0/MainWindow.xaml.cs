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
            InitializeComponent();
            mainFrame.Navigate(new Home());
        }

        private void SideMenu_SelectionChanged(object sender, HandyControl.Data.FunctionEventArgs<object> e)
        {
            foreach (SideMenuItem item in sideMenuTop.Items)
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
                        case "Messages":
                            mainFrame.Navigate(new Notifications());
                            break;
                       
                        case "Home":
                            mainFrame.Navigate(new Home());
                            break;
                        default:
                            Growl.Error("Undefined URI!");
                            break;
                    }
                }
            }
        }

        private void SideMenu_SelectionChanged2(object sender, HandyControl.Data.FunctionEventArgs<object> e)
        {
            foreach (SideMenuItem item in sideMenuBottom.Items)
            {
                if (item.IsSelected)
                {
                    switch (item.Header)
                    {
                        case "About":
                            mainFrame.Navigate(new About());
                            break;
                        case "Settings":
                            mainFrame.Navigate(new Settings());
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
