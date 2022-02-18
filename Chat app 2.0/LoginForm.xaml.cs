using Chat_app_2._0.Helpers;
using HandyControl.Controls;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Chat_app_2._0
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : System.Windows.Window
    {
        DataAccessHelper helper = new DataAccessHelper();
        DispatcherTimer timer = new DispatcherTimer();
        public int Progress
        {
            get { return (int)GetValue(ProgressProperty); }
            set { SetValue(ProgressProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Progress.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressProperty =
            DependencyProperty.Register("Progress", typeof(int), typeof(LoginForm), new PropertyMetadata(0));


        public LoginForm()
        {
            InitializeComponent();
            DataContext = this;
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Progress++;
            if (Progress == 100)
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (await helper.getUser(email.Text, password.Password) == null)
            {
                Growl.Error("user not found!");
            }
            else
            {
                LoadingScreen.Opacity = 1;
                Panel.SetZIndex(mainGrid, -1);
                Panel.SetZIndex(LoadingScreen, 1);
                timer.Start();
            }
            
        }
    }
}
