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

namespace TradeLog.View
{
    /// <summary>
    /// Interaction logic for Description.xaml
    /// </summary>
    public partial class Description : Window
    {
        public Description()
        {
            InitializeComponent();
        }

        private void mentes_click(object sender, RoutedEventArgs e)
        {
            if (megjegyzes.Text != "")
            {
                DialogResult = true;
            }
        }

        private void Megse_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
