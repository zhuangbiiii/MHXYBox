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

namespace MHXYBox
{
    /// <summary>
    /// HuiMengDanCounter.xaml 的交互逻辑
    /// </summary>
    public partial class HuiMengDanCounter : Window
    {
        public HuiMengDanCounter()
        {
            InitializeComponent();
        }
        public int iFURONG { get; set; }
        public int iLINGFU { get; set; }
        public int iWUZHONGXIAN { get; set; }
        public int iJINGPING { get; set; }
        public int iLVFA { get; set; }
        private void Bt_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            switch(button.Name)
            {
                case "btFURONG":
                    iFURONG++;
                    break;
                case "btLINGFU":
                    iLINGFU++;
                    break;
                case "btWUZHONGXIAN":
                    iWUZHONGXIAN++;
                    break;
                case "btJINGPING":
                    iJINGPING++;
                    break;
                case "btLVFA":
                    iLVFA++;
                    break;
            }
            UPDATEUI();
        }
        private void UPDATEUI()
        {
            tFURONG.Text = iFURONG.ToString() + "/3";
            tLINGFU.Text = iLINGFU.ToString() + "/3";
            tWUZHONGXIAN.Text = iWUZHONGXIAN.ToString() + "/3";
            tJINGPING.Text = iJINGPING.ToString() + "/3";
            tLVFA.Text = iLVFA.ToString() + "/3";
        }
    }
}
