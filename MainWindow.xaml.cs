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
        // 摄妖香
        int SYX = 1800;
        // 回梦丹
        int HMD = 3600;
        // 双/三倍
        int Shuang = 3600;
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Tx0_Tick;
            timer.Start();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        void Tx0_Tick(object sender, EventArgs e)
        {
            Tx0.Text = DateTime.Now.ToLongTimeString();
        }
        void Tx1_Tick(object sender, EventArgs e)
        {
            if (SYX > 0)
            {
                Tx1.Text = (SYX / 60).ToString() + ":" + (SYX % 60).ToString();
                SYX--;
            }
            else
            {
                timer.Tick -= Tx1_Tick;
            }
        }
        void Tx2_Tick(object sender, EventArgs e)
        {
            if (HMD > 0)
            {
                Tx2.Text = (HMD / 60).ToString() + ":" + (HMD % 60).ToString();
                HMD--;
            }
            else
            {
                timer.Tick -= Tx2_Tick;
            }
        }
        void Tx3_Tick(object sender, EventArgs e)
        {
        }
        void Tx4_Tick(object sender, EventArgs e)
        {
        }
        void Tx5_Tick(object sender, EventArgs e)
        {
        }
        void Tx6_Tick(object sender, EventArgs e)
        {
        }
        void Tx7_Tick(object sender, EventArgs e)
        {
        }
        void Tx8_Tick(object sender, EventArgs e)
        {
        }
        void Tx9_Tick(object sender, EventArgs e)
        {
        }
        void Tx10_Tick(object sender, EventArgs e)
        {
        }
        void Tx11_Tick(object sender, EventArgs e)
        {
        }
        private void Bt0_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            // 启动摄妖香计时器
            SYX = 1800;
            timer.Tick += Tx1_Tick;
        }
        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            HMD = 3600;
            timer.Tick += Tx2_Tick;
        }
        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Bt4_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Bt5_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Bt6_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Bt7_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Bt8_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Bt9_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Bt10_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Bt11_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
