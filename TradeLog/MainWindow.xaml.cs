/* Contact Info
 *  Oláh Viktor
 *  oviktor92@gmail.com
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
using TradeLog.SQL;
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
            version.Text = Model.StaticData.commitversion;

        }


        // Ablak bezár, Windows Close / Program Close
        private void Kilepes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Biztosan be akarja zárni az alkalmazást?", "Bezárás", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    if (Model.StaticData.ServerStatus == true)
                    {
                        DBManagement.KapcsolatBontas();
                    }
                    else
                    {
                        Model.StaticData.XMLSave();
                    }
                    
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba");
            }
        }


        // Bejelentkezo (Login)
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


        // Új felhasználó regisztrálása labelre kattintva.
        private void Label_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            View.NewUserView dialog = new View.NewUserView();

            if (dialog.ShowDialog() == (DialogResult == null))
            {
                Model.StaticData.usersData.Add(dialog.User);
                this.Show();
            }

        }

        // Rendszer betöltés / SQL Connect / XML Connect.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Model.StaticData.frChange == true)
            {
                try
                {
                    Model.StaticData.usersData = Model.StaticData.BetoltottFelhasznalok();
                    Model.StaticData.ServerStatus = true;
                    sql.Fill = Brushes.Green;
                    xml.Fill = Brushes.Gray;
                    Model.StaticData.frChange = false;
                 
                }
                catch (Exception)
                {
                    MessageBox.Show("Nem sikerült kapcsolódni a MySQL - Szerverhez! Kérem ellenőrizze a [ConnectionStringet] vagy a szerver státuszt!", "Hiba a kapcsolódás során!");
                    MessageBox.Show("A tárolás lokálisan XML- fájlba történik a továbbiakban!", "További tárolási eljárás!");
                    Model.StaticData.XMLLoad();
                    xml.Fill = Brushes.Green;
                    sql.Fill = Brushes.Red;
                    Model.StaticData.ServerStatus = false;
                }

                finally
                {
                    Model.StaticData.frChange = false;
                   
                }
            }
          

        }
    }
}
