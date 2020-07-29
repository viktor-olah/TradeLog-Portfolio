using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.CodeDom;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TradeLog.Model;
using TradeLog.SQL;

namespace TradeLog.View
{
    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView : Window
    {

        User felhasznalo;

        string temp;
        string tempKeputvonal = "-";

        internal Pozicio Pozicio { get; private set; }
        internal User User
        {
            get => felhasznalo;
            set
            {
                felhasznalo = value;
                teljesNev.Text = value.VersenyzoNeve;
                azonosito.Text = value.LoginName;

                foreach (Pozicio item in value.Kotesek)
                {
                    lb1.Items.Add(item);
                }

                if (Model.StaticData.usersData.Count != 0)
                {
                    ListBoxRefresh();
                    NaploAdatok();
                }
                aktualistoke.Text = value.AktualisToke.ToString();
              
                AktualistokeStatusUpdate();
            }
        }



        public LogView()
        {
            InitializeComponent();
            ServerStatus(Model.StaticData.ServerStatus);
            idosikCB.ItemsSource = Pozicio.idosik;
        }


        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            View.Description desc = new View.Description();
            desc.megjegyzes.Text = megjegyzesTB.Text;
            if (desc.ShowDialog() == (DialogResult == null))
            {
                megjegyzesTB.Text = desc.megjegyzes.Text;
            }
        }       // Megjegyzés box kitöltése nagyobb nézetben.

        #region Window Shortcut
        private void Exit_click(object sender, RoutedEventArgs e)
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

        private void minimized_click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void back_click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Biztosan vissza lép a bejelentkező képernyőre", "Vissza", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MainWindow main = new MainWindow();
                this.Close();
                main.ShowDialog();
            }
        }
        #endregion

        private void jegyzesBtn_click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (User.AktualisToke != 0)
                {
                    lb1.Items.Clear();

                    User.Kotesek.Add(new Pozicio(ticketTB.Text, devizaparTB.Text, ValueValidation(mennyisegTB.Text.Replace(".",",")), ValueValidation(nyitoTB.Text.Replace(".", ",")), ValueValidation(stopTB.Text.Replace(".", ",")), ValueValidation(celarTB.Text.Replace(".", ",")), ValueValidation(zarTB.Text.Replace(".", ",")), ValueValidation(osszegTB.Text.Replace(".", ",")),tempKeputvonal,megjegyzesTB.Text, idosikCB.SelectedItem.ToString()));
                    if (Model.StaticData.ServerStatus == true)
                    {
                        DBManagement.UjJegyzes(User, User.Kotesek.Last());
                    }
                   
                    //Pozicio.ImageSave(tempKeputvonal);
                    ListBoxRefresh();
                    NaploAdatok();
                }
                else
                {
                    aktualistoke.Background = Brushes.Coral;
                }
                Pozicio.ImageSave(tempKeputvonal);
            }
            catch (ArgumentException ex)
            {
                ListBoxRefresh();
                MessageBox.Show(ex.Message, "Hiba");
            }
        }                      // Bejegyzés készítése

        private void lb1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)        // Jobb klikkel bejegyzés törlése
        {
            if (lb1.SelectedIndex != -1 && MessageBox.Show("Szeretné törölni a kiválasztott elemet", "Törlés", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                DBManagement.JegyzesTorlese(lb1.SelectedItem as Pozicio);
                User.Kotesek.Remove(lb1.SelectedItem as Pozicio);
                ListBoxRefresh();
                NaploAdatok();
            }
        }


        private void aktualistoke_PreviewMouseDown(object sender, MouseButtonEventArgs e)       
        {
            aktualistoke.Background = Brushes.White;
            eurText.Visibility = Visibility.Visible;
        }

        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (aktualistoke.Text != "" && temp != aktualistoke.Text)
                {
                    temp = aktualistoke.Text;
                    User.AktualisToke = ValueValidation(aktualistoke.Text);
                    if (Model.StaticData.ServerStatus == true)
                    {
                        DBManagement.UjaktualisTokeJegyzese(User);
                    }
                    aktualistoke.Background = Brushes.White;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                aktualistoke.Text = "";
                aktualistoke.Background = Brushes.Coral;
            }
          
        }       // Aktuális tőke frissítés textboxból kilépve.


        private void NaploAdatok()
        {
            //aktualistoke.Clear();
            talalatiAranyTB.Text = Pozicio.TalaltiArany(User.Kotesek).ToString("0" + " %");
            kereskedesekSzamaTB.Text = User.Kotesek.Count().ToString();
            osszNyeresegTB.Text = Pozicio.OsszNyereseg(User.Kotesek).ToString("0.00" + " EUR");
            payoffrationTB.Text = Pozicio.PayOffRation(User.Kotesek).ToString("0.00");
            celarmegvalosultTB.Text = Pozicio.CelarMegvalosulas(User.Kotesek).ToString();
            pozicioepitesTB.Text = Pozicio.Pozicioepites(User.Kotesek).ToString();

            if (User.AktualisToke != 0 && User.Kotesek.Count !=0)
            {
                aktualistoke.Text = (User.AktualisToke + User.Kotesek.Last().Vegosszeg).ToString();
            }
        }               // Napló adatok frissítése

        private void ListBoxRefresh()
        {
            lb1.Items.Clear();

            foreach (Pozicio item in Model.StaticData.Rendezes(User.Kotesek))
            {
                lb1.Items.Add(item);
            }
        }           // Listbox adatok frissítése memóriából.

        private void AktualistokeStatusUpdate()
        {
            if (aktualistoke.Text == "0")
            {
                eurText.Visibility = Visibility.Hidden;
                aktualistoke.Clear();

            }
            else
            {
                eurText.Visibility = Visibility.Visible;
            }

        }

        private void picture_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG (*.jpg)|*.jpg |All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)

                tempKeputvonal = openFileDialog.FileName;
        }           // Kép belinkelése (késöbbi fejlesztéshez)

        private double ValueValidation(string input)
        {
            double backValue=0.00;
            if (!string.IsNullOrEmpty(input) && double.TryParse(input, out double output))
            {
                backValue = output;
            }
            else
            {
                throw new ArgumentException("Hibás karakter adott meg a jegyzésben!");
            }
            return backValue;
        }                           // Bevitt adat ellenörző exeption-hez

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
        }                                  //Szerver Státusz fények

    }
}

    


