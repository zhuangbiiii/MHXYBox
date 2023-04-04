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
        int SYX = 0;
        // 回梦丹
        int HMD = 0;
        // 双/三倍
        int Shuang = 0;
        // 年卡加成
        int NianKa = 0;
        // 变身卡
        int BianShenKa = 0;
        // 月光1
        int YG1 = 0;
        // 月光2
        int YG2 = 0;
        // 月光3
        int YG3 = 0;
        // 月光4
        int YG4 = 0;
        // 月光5
        int YG5 = 0;
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
            // 更新当前时间
            Tx0.Text = DateTime.Now.ToLongTimeString();
        }
        void Tx1_Tick(object sender, EventArgs e)
        {
            // 更新摄妖香时间
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
            // 更新回梦丹时间
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
            // 更新双/三倍时间
            if (Shuang > 0)
            {
                Tx3.Text = (Shuang / 60).ToString() + ":" + (Shuang % 60).ToString();
                Shuang--;
            }
            else
            {
                timer.Tick -= Tx3_Tick;
            }
        }
        void Tx4_Tick(object sender, EventArgs e)
        {
            // 更新年卡加成时间
            if (NianKa > 0)
            {
                Tx4.Text = (NianKa / 60).ToString() + ":" + (NianKa % 60).ToString();
                NianKa--;
            }
            else
            {
                timer.Tick -= Tx4_Tick;
            }
        }
        void Tx5_Tick(object sender, EventArgs e)
        {
            // 更新变身卡时间
            if (BianShenKa > 0)
            {
                Tx5.Text = (BianShenKa / 60).ToString() + ":" + (BianShenKa % 60).ToString();
                BianShenKa--;
            }
            else
            {
                timer.Tick -= Tx5_Tick;
            }
        }
        void YG1_Tick(object sender, EventArgs e)
        {
            // 更新月光1时间
            if (YG1 > 0) 
            {
                YG1TX.Text = (YG1 / 60).ToString() + ":" + (YG1 % 60).ToString();
                YG1--;
            }
            else
            {
                timer.Tick -= YG1_Tick;
            }
        }
        void YG2_Tick(object sender, EventArgs e)
        {
            // 更新月光2时间
            if (YG2 > 0)
            {
                YG2TX.Text = (YG2 / 60).ToString() + ":" + (YG2 % 60).ToString();
                YG2--;
            }
            else
            {
                timer.Tick -= YG2_Tick;
            }
        }
        void YG3_Tick(object sender, EventArgs e)
        {
            // 更新月光3时间
            if (YG3 > 0)
            {
                YG3TX.Text = (YG3 / 60).ToString() + ":" + (YG3 % 60).ToString();
                YG3--;
            }
            else
            {
                timer.Tick -= YG3_Tick;
            }
        }
        void YG4_Tick(object sender, EventArgs e)
        {
            // 更新月光4时间
            if (YG4 > 0)
            {
                YG4TX.Text = (YG4 / 60).ToString() + ":" + (YG4 % 60).ToString();
                YG4--;
            }
            else
            {
                timer.Tick -= YG4_Tick;
            }
        }
        void YG5_Tick(object sender, EventArgs e)
        {
            // 更新月光5时间
            if (YG5 > 0)
            {
                YG5TX.Text = (YG5 / 60).ToString() + ":" + (YG5 % 60).ToString();
                YG5--;
            }
            else
            {
                timer.Tick -= YG5_Tick;
            }
        }

        private void MenuItem0_Click(object sender, EventArgs e)
        {
            HuiMengDanCounter huiMengDanCounter = new HuiMengDanCounter();
            huiMengDanCounter.Show();
        }
        private void Bt0_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            // 启动摄妖香计时器
            if(SYX > 0)
            {
                timer.Tick -= Tx1_Tick;
            }
            SYX = 1800;
            timer.Tick += Tx1_Tick;
        }
        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            // 启动回梦丹计时器
            if(HMD > 0)
            {
                timer.Tick -= Tx2_Tick;
            }
            HMD = 3600;
            timer.Tick += Tx2_Tick;
        }
        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            // 启动双/三倍计时器
            if(Shuang > 0)
            {
                timer.Tick -= Tx3_Tick;
            }
            Shuang += 3600;
            timer.Tick += Tx3_Tick;
        }
        private void Bt4_Click(object sender, RoutedEventArgs e)
        {
            // 启动年卡加成计时器
            if(NianKa > 0)
            {
                timer.Tick -= Tx4_Tick;
            }
            NianKa = 10800;
            timer.Tick += Tx4_Tick;
        }
        private void Bt5_Click(object sender, RoutedEventArgs e)
        {
            // 变身卡选择
            Button bt = sender as Button;
            BianShenKaSelector bianShenKaSelector = new BianShenKaSelector();
            bianShenKaSelector.Show();
            // event while menPaiSelector is selected
            bianShenKaSelector.Closed += (s, args) =>
            {
                // 开始倒计时
                if(BianShenKa >  0)
                {
                    timer.Tick -= Tx5_Tick;
                }
                BianShenKa = bianShenKaSelector.BianShenKaDuration;
                timer.Tick += Tx5_Tick;
            };
        }

        private void BtMoon_Click(object sender, RoutedEventArgs e)
        {
            // 月光门派选择
            Button bt = sender as Button;
            MenPaiSelector menPaiSelector = new MenPaiSelector();
            menPaiSelector.Show();
            // event while menPaiSelector is selected
            menPaiSelector.Closed += (s, args) =>
            {
                // do something
                bt.Content = menPaiSelector.MenPai;
            };
        }

        private void YG1Reset_Click(object sender, RoutedEventArgs e)
        {
            // 重设月光1计时器
            if(YG1 > 0)
            {
                timer.Tick -= YG1_Tick;
            }
            YG1 = 1800;
            timer.Tick += YG1_Tick;
        }

        private void YG2Reset_Click(object sender, RoutedEventArgs e)
        {
            // 重设月光2计时器
            if(YG2 > 0)
            {
                timer.Tick -= YG2_Tick;
            }
            YG2 = 1800;
            timer.Tick += YG2_Tick;
        }

        private void YG3Reset_Click(object sender, RoutedEventArgs e)
        {
            // 重设月光3计时器
            if(YG3 > 0)
            { 
                timer.Tick -= YG3_Tick;
            }
            YG3 = 1800;
            timer.Tick += YG3_Tick;
        }

        private void YG4Reset_Click(object sender, RoutedEventArgs e)
        {
            // 重设月光4计时器
            if(YG4 > 0)
            {
                timer.Tick -= YG4_Tick;
            }
            YG4 = 1800;
            timer.Tick += YG4_Tick;
        }

        private void YG5Reset_Click(object sender, RoutedEventArgs e)
        {
            // 重设月光5计时器
            if(YG5 > 0)
            {
                timer.Tick -= YG5_Tick;
            }
            YG5 = 1800;
            timer.Tick += YG5_Tick;
        }
        private void MenPaiBT_Click(object sender, RoutedEventArgs e)
        {
            // 禁用按下的按钮
            Button bt = sender as Button;
            bt.IsEnabled = false;
        }

        private void ShiBaMenPaiReseter_Click(object sender, RoutedEventArgs e)
        {
            // 启用所有按钮
            foreach (var item in ShibaMenPai.Children)
            {
                if (item is Button)
                {
                    Button bt = item as Button;
                    bt.IsEnabled = true;
                }
            }
        }

        private void GuiHuan_Click(object sender, RoutedEventArgs e)
        {
            // 重置双/三计时器
            Shuang = 0;
            timer.Tick -= Tx3_Tick;
            Tx3.Text = "N/A";
        }
    }
}
