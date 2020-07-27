using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using TradeLog.Model;
using TradeLog.View;
using Brushes = System.Windows.Media.Brushes;

namespace TradeLog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }

     

        private void Kilepes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Biztosan be akarja zárni az alkalmazást?", "Bezárás", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba");
            }
            /*
            XDocument users = new XDocument(new XElement("User"));
            foreach (User item in Model.StaticData.usersData)
            {
                users.Root.Add(item.UserToXML());
            }
            users.Save("Users.xml");
            */

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            
                LoginFieldBGColorControl();
               
                    if (Model.StaticData.Kereses(Model.StaticData.usersData, loginname.Text, password.Password) == true)
                    {
                        MessageBox.Show("Sikeres Bejelentkezés! ", "Login");
                        View.LogView dialog = new View.LogView();
                        dialog.User = (User)Model.StaticData.Kivalasztott(Model.StaticData.usersData, loginname.Text, password.Password);
                        this.Close();
                        dialog.ShowDialog();
                    }
                   else
                    {
                            if (loginname.Text != "" && password.Password != "")
                            {
                                MessageBox.Show("Nincs ilyen felhasznaló! Kérem regisztráljon a lenti menüpont segítségével!", "Login");
                            }
                            else
                            {
                                MessageBox.Show("Hibásan kitöltött mező!", "Login");
                            }
                     }
        }

        private void LoginFieldBGColorControl()
        {
            if (loginname.Text == "")
            {

                loginbg.Fill = Brushes.Coral;
            }
            else
            {
                loginbg.Fill = Brushes.White;
            }

            if (password.Password == "")
            {

                passbg.Fill = Brushes.Coral;
            }
            else
            {
                passbg.Fill = Brushes.White;
            }
        }

        private void Label_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            View.NewUserView dialog = new View.NewUserView();

            if (dialog.ShowDialog() == (DialogResult == null))
            {
                Model.StaticData.usersData.Add(dialog.User);
                this.Show();
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            if (File.Exists("Users.xml"))
            {
                XDocument users = XDocument.Load("Users.xml");
                Model.StaticData.usersData = (from user in users.Root.Elements("User")
                                            select new User(user)).ToList();
            }
            */
        }
    }
}
