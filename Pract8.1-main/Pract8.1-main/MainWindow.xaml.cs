using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Практическая_Работа_8._1_РКИС
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool block = true;
        int fail = 0;
        DateTime? lastAttemptTime = null;
        readonly TimeSpan minDelay = TimeSpan.FromSeconds(1);
        readonly TimeSpan maxDelay = TimeSpan.FromMinutes(5);
        readonly double delayMultiplier = 2.0;
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        DispatcherTimer timer = new DispatcherTimer();
        Stopwatch stopwatch = new Stopwatch();
        public void StartTimer()
        {
            block = false;
            stopwatch.Start();
            fail ++ ;
        }
        public TimeSpan StopTimer()
        {
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
        public TimeSpan ResetTimer()
        {
            stopwatch.Reset();
            return stopwatch.Elapsed;
        }
        public int GetTimer()
        {
            return Convert.ToInt32(stopwatch.ElapsedMilliseconds / 1000);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!block)
            {
                TBTimer.Text = Convert.ToString("До след попытки " + Math.Abs(GetTimer() - 3 * fail) + " сек.");
            }
            if (GetTimer() >= 3 * fail) 
            {
                StopTimer();
                ResetTimer();
                block = true;
            }
        }
        private void btnAutorisation_Click(object sender, RoutedEventArgs e)
        {
           
            if (!block) 
            {
                return;
            }
                string login = TBlog.Text;
                string password = TBPsswd.Password;
                if (string.IsNullOrWhiteSpace(login) && string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Введите логин и пароль!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                    StartTimer();
                    return;
                }
                if (string.IsNullOrWhiteSpace(login))
                {
                    MessageBox.Show("Введите логин!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                    StartTimer();
                    return;
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Введите пароль!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                    StartTimer(); 
                    return;
                }
                if (password.Length < 8)
                {
                    MessageBox.Show("Пароль не менее 8 символов!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                     StartTimer();
                    password = string.Empty;
                    return;
                }      
                if (login == "Admin" && password == "1loveRKIS")
                {
                    MessageBox.Show("Всё отлично щас войдём!");
                    Admin admin = new Admin();
                    admin.Show();
                    mainWindow_Closed(this, new EventArgs());
                }
                if (login == "CoachBox" && password == "Box123987")
                {
                    MessageBox.Show("Всё отлично щас войдём!");
                    Coach coach = new Coach();
                    coach.Show();
                    mainWindow_Closed(this, new EventArgs());
                }
                else
                {
                    fail++;
                }
            }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TBTime_Копировать_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
