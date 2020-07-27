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

namespace TradeLog.View
{
    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView : Window
    {

        User felhasznalo;
        string temp;
        string tempKeputvonal;
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
        }

        #region Window Shortcut
        private void Exit_click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Biztosan be akarja zárni az alkalmazást?", "Bezárás", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
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

                    User.Kotesek.Add(new Pozicio(ticketTB.Text, devizaparTB.Text, ValueValidation(mennyisegTB.Text), ValueValidation(nyitoTB.Text), ValueValidation(stopTB.Text), ValueValidation(celarTB.Text), ValueValidation(zarTB.Text), ValueValidation(osszegTB.Text), tempKeputvonal, megjegyzesTB.Text, idosikCB.SelectedItem.ToString()));
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
        }

        private void lb1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (lb1.SelectedIndex != -1 && MessageBox.Show("Szeretné törölni a kiválasztott elemet", "Törlés", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
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
                    aktualistoke.Background = Brushes.White;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                aktualistoke.Text = "";
                aktualistoke.Background = Brushes.Coral;
            }
          
        }


        private void NaploAdatok()
        {
            aktualistoke.Clear();
            talalatiAranyTB.Text = Pozicio.TalaltiArany(User.Kotesek).ToString("0" + " %");
            kereskedesekSzamaTB.Text = User.Kotesek.Count().ToString();
            osszNyeresegTB.Text = Pozicio.OsszNyereseg(User.Kotesek).ToString("0.00" + " EUR");
            payoffrationTB.Text = Pozicio.PayOffRation(User.Kotesek).ToString("0.00");
            celarmegvalosultTB.Text = Pozicio.CelarMegvalosulas(User.Kotesek).ToString();
            pozicioepitesTB.Text = Pozicio.Pozicioepites(User.Kotesek).ToString();

            if (User.AktualisToke != 0)
            {
                aktualistoke.Text = (User.AktualisToke + User.Kotesek.Last().Vegosszeg).ToString();
            }
        }

        private void ListBoxRefresh()
        {
            lb1.Items.Clear();

            foreach (Pozicio item in Model.StaticData.Rendezes(User.Kotesek))
            {
                lb1.Items.Add(item);
            }
        }

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
        }

        private double ValueValidation(string input)
        {
            double backValue=0.00;
            if (!string.IsNullOrEmpty(input) && double.TryParse(input, out double output) && output >= 0)
            {
                backValue = output;
            }
            else
            {
                throw new ArgumentException("Hibás karakter adott meg a jegyzésben!");
            }
            return backValue;
        }
    }
}

    


