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
    /// MenPaiSelector.xaml 的交互逻辑
    /// </summary>
    public partial class MenPaiSelector : Window
    {
        public MenPaiSelector()
        {
            InitializeComponent();
        }

        public string MenPai { get; set; }
        private void Bt_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            MenPai = button.Content.ToString();
            this.Close();
        }
    }
}
