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
    public partial class LoginForm : Window
    {
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
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadingScreen.Opacity = 1;
            Panel.SetZIndex(mainGrid, -1);
            Panel.SetZIndex(LoadingScreen, 1);
            timer.Start();
        }
    }
}
