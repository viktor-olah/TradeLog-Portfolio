using Microsoft.SqlServer.Server;
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
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView : Window
    {

        User felhasznalo;
        string temp;

        internal User User
        {
            get => felhasznalo;
            set
            {
                felhasznalo = value;
                teljesNev.Text = value.VersenyzoNeve;
                azonosito.Text = value.LoginName;
                if (felhasznalo.Szemelyesnaplo != null)
                {
                    aktualistoke.Text = value.Szemelyesnaplo.AktualisToke.ToString();
                    eurText.Visibility = Visibility.Visible;
                }
                
                foreach (Pozicio item in value.Kotesek)
                {
                    lb1.Items.Add(item);
                }
                if (Model.StaticData.usersData.Count != 0)
                {
                    ListBoxRefresh();
                    NaploAdatok();
                }
            }
        }
       
        public LogView()
        {
            InitializeComponent();
            idosikCB.ItemsSource = Pozicio.idosik;
           
           
            
           
        }

        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            
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
                lb1.Items.Clear();

                User.Kotesek.Add(new Pozicio(ticketTB.Text, devizaparTB.Text, double.Parse(mennyisegTB.Text), double.Parse(nyitoTB.Text), double.Parse(stopTB.Text), double.Parse(celarTB.Text), double.Parse(zarTB.Text), double.Parse(osszegTB.Text), "new", megjegyzesTB.Text, idosikCB.SelectedItem.ToString()));

                ListBoxRefresh();
                NaploAdatok();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Hiba");

            }
          
      

        }

        private void lb1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (lb1.SelectedIndex !=-1 && MessageBox.Show("Szeretné törölni a kiválasztott elemet","Törlés",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
               
                User.Kotesek.Remove(lb1.SelectedItem as Pozicio);
                ListBoxRefresh();
                NaploAdatok();
            }
        }

     
        private void aktualistoke_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            eurText.Visibility = Visibility.Visible;
        }

        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (aktualistoke.Text != "" && temp != aktualistoke.Text)
            {
                temp = aktualistoke.Text;
                User.Szemelyesnaplo = new Naplo(double.Parse(aktualistoke.Text));
                
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
        private void NaploAdatok()
        {
            talalatiAranyTB.Text = Model.Pozicio.TalaltiArany(User.Kotesek).ToString("0" + " %");
            kereskedesekSzamaTB.Text = User.Kotesek.Count().ToString();
            osszNyeresegTB.Text = Model.Pozicio.OsszNyereseg(User.Kotesek).ToString("0.00"+ " EUR");
            payoffrationTB.Text = Model.Pozicio.PayOffRation(User.Kotesek).ToString("0.00");
            celarmegvalosultTB.Text = Model.Pozicio.CelarMegvalosulas(User.Kotesek).ToString();
            pozicioepitesTB.Text = Model.Pozicio.Pozicioepites(User.Kotesek).ToString();
        }

    }
}

