using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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

namespace MHXYBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer Timer1 = new DispatcherTimer();
            Timer1.Interval = TimeSpan.FromSeconds(1);
            Timer1.Tick += timer1_Tick;
            Timer1.Start();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        void timer1_Tick(object sender, EventArgs e)
        {
            Tx1.Text = DateTime.Now.ToLongTimeString();
        }
        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            if(Bt1.Content.ToString() == "Start")
            {
                Bt1.Content = "Stop";
            }
            else
            {
                Bt1.Content = "Start";
            }
        }
        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            if (Bt2.Content.ToString() == "Start")
            {
                Bt2.Content = "Stop";
            }
            else
            {
                Bt2.Content = "Start";
            }
            DispatcherTimer Timer2 = new DispatcherTimer();
            Timer2.Interval = TimeSpan.FromSeconds(1);
            Timer2.Tick += timer2_Tick;
            Timer2.Start();
        }
        void timer2_Tick(object sender, EventArgs e)
        {
            Tx2.Text = DateTime.Now.ToLongTimeString();
        }
        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            if (Bt3.Content.ToString() == "Start")
            {
                Bt3.Content = "Stop";
            }
            else
            {
                Bt3.Content = "Start";
            }
        }
    }
}
