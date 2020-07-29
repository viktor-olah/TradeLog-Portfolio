using System;
using System.Collections.Generic;
using System.Drawing;
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
using TradeLog.SQL;
using Brushes = System.Windows.Media.Brushes;

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
            ServerStatus(Model.StaticData.ServerStatus);
            version.Text = Model.StaticData.commitversion;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoginFieldBGColorControl();
                if (Model.StaticData.Validalas(Model.StaticData.usersData, fullname.Text) == false)
                {
                    newUser = new User(fullname.Text, loginname.Text, password.Password);
                    if (Model.StaticData.ServerStatus == true)
                    {
                        DBManagement.UjFelhasznaloREG(newUser);
                    }
                    MessageBox.Show("Új felhasználó regisztrálva ! Most már bejelentkezhet ","Login");
                    DialogResult = true;
                }
                else
                {
                    MessageBox.Show("Az Ön nevével már van jegyzett regisztráció!", "Hiba");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Hiba");
            }
           

            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void LoginFieldBGColorControl()
        {
            if (fullname.Text == "")
            {
                fullnameBG.Fill = Brushes.Coral;
            }
            else
            {
                fullnameBG.Fill = Brushes.White;
            }
            if (loginname.Text == "")
            {
                loginBG.Fill = Brushes.Coral;
            }
            else
            {
                loginBG.Fill = Brushes.White;
            }
            if (password.Password == "")
            {
                passBG.Fill = Brushes.Coral;
            }
            else
            {
                passBG.Fill = Brushes.White;
            }

        }

        private void ServerStatus(bool status)
        {
            if (status == true)
            {
                sql.Fill = Brushes.Green;
                xml.Fill = Brushes.Gray;
            }
            else
            {
                sql.Fill = Brushes.Red;
                xml.Fill = Brushes.Green;
            }
        }
    }
}
