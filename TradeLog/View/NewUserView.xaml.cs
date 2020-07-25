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
using TradeLog.Model;

namespace TradeLog.View
{
    /// <summary>
    /// Interaction logic for NewUserView.xaml
    /// </summary>
    public partial class NewUserView : Window
    {

        User newUser;
        internal User User
        {
            get => newUser;
            set
            {
                newUser = value;
                fullname.Text = value.VersenyzoNeve;
                loginname.Text = value.LoginName;
                password.Password = value.LoginPass;

            }
        }
        public NewUserView()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (Model.StaticData.Validalas(Model.StaticData.usersData,fullname.Text) == false)
            {
                newUser = new User(fullname.Text, loginname.Text, password.Password);
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Az Ön nevével már van jegyzett regisztráció!", "Hiba");
            }

            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
