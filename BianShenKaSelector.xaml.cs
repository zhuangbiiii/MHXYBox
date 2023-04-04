using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MHXYBox
{
    /// <summary>
    /// BianShenKaSelector.xaml 的交互逻辑
    /// </summary>
    public partial class BianShenKaSelector : Window
    {
        public BianShenKaSelector()
        {
            InitializeComponent();
        }

        public int BianShenKaDuration { get; set; }
        private void Bt_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Content.ToString())
            {
                case "野鬼":
                    BianShenKaDuration = 7200;
                    break;
                case "蝴蝶":
                    BianShenKaDuration = 5400;
                    break;
                case "骷髅怪":
                    BianShenKaDuration = 10800;
                    break;
                case "狐狸精":
                    BianShenKaDuration = 10800;
                    break;
                case "童子":
                    BianShenKaDuration = 4680;
                    break;
                case "炎魔神":
                    BianShenKaDuration = 5400;
                    break;
                case "灵鹤":
                    BianShenKaDuration = 5400;
                    break;
                case "1级卡":
                    BianShenKaDuration = 10800;
                    break;
                default:
                    BianShenKaDuration = 3600;
                    break;
            }
            this.Close();
        }
    }
}
