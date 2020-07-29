using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using TradeLog.Model;

namespace TradeLog.SQL
{
    static class DBManagement
    {

        // Connect app.configba konfigurálva. ip/nev/pass

        #region MySQL Connect
        //MySQL Autoconnect híváskor
        static MySqlConnection connection;
        static MySqlCommand command;

        static DBManagement()
        {
            try
            {
                connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["TradeLogMySQL"].ConnectionString);
                connection.Open();

                command = new MySqlCommand();
                command.Connection = connection;
            }
            catch (Exception ex)
            {
                throw new DBManagementExept("A csatlakozás sikertelen volt a mysql adatbázishoz!", ex);
            }
        }
        #endregion

        #region MySQL Disconnect
        public static void KapcsolatBontas()
        {
            try
            {
                connection.Close();
                command = null;
            }
            catch (Exception ex)
            {
                throw new DBManagementExept("A kapcsolat bontása sikertelen!", ex);
            }
        }
        #endregion

        #region DB Kiolvasasok
        public static List<User> CsakUserDBKiolvasasTokevel()
        {
            try
            {
                List<User> felhasznaloiAdatok = new List<User>();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM `user`";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        felhasznaloiAdatok.Add(new User(reader["nev"].ToString(), reader["loginname"].ToString(), reader["loginpass"].ToString(),(double)reader["aktualistoke"]));
                    }
                    reader.Close();
                }
                return felhasznaloiAdatok;
            }
            catch (Exception ex)
            {
                throw new DBManagementExept("Az adatkiolvasás nem sikerült a MySQL adatbázisból", ex);
            }
        }


        public static List<User> DBKiolvasas()
        {
            try
            {
                List<User> felhasznaloiAdatok = new List<User>();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM `user` INNER JOIN `pozicio` ON `user`.`nev` = `pozicio`.`nevid`";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    
                        if (felhasznaloiAdatok.Count() == 0 || felhasznaloiAdatok.Last().VersenyzoNeve != (reader["nev"].ToString()))
                        {
                            felhasznaloiAdatok.Add(new User(reader["nev"].ToString(), reader["loginname"].ToString(), reader["loginpass"].ToString(), (double)reader["aktualistoke"]));
                        }
                       
                        felhasznaloiAdatok.Last().Kotesek.Add(new Pozicio(reader["ticket"].ToString(), reader["devizapar"].ToString(), (double)reader["mennyiseg"], (double)reader["pricenyit"], (double)reader["stop"], (double)reader["cel"], (double)reader["zar"], (double)reader["vegosszeg"], reader["keputvonal"].ToString(), reader["megjegyzes"].ToString(), reader["valasztottidosik"].ToString(), (DateTime)reader["jegyzettido"]));


                    }
                    reader.Close();
                }
                return felhasznaloiAdatok;
            }
            catch (Exception ex)
            {
                throw new DBManagementExept("Az adatkiolvasás nem sikerült a MySQL adatbázisból",ex);
            }
        }
        #endregion

     
        // Ha csak regisztrált de még nem naplózott és naplózna!
        public static double UserUpdateForLogin(User betoltott)
        {
            try 
            {
                double kiolvasott = 0.00;
                command.Parameters.Clear();
            
                    command.CommandText = " SELECT `aktualistoke` FROM `user` WHERE `nev` LIKE CONCAT(@kivalasztott, '%')";
                    command.Parameters.AddWithValue("@kivalasztott", betoltott.VersenyzoNeve);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kiolvasott = (double)reader[0];

                        }
                        reader.Close();
                    }

                return kiolvasott;
            }
            catch (Exception ex)
            {
                throw new DBManagementExept("Az adatkiolvasás nem sikerült a MySQL adatbázisból", ex);
            }
           
        }
        #region DB Update
        public static void UjaktualisTokeJegyzese(User ujadat)
        {
            MySqlTransaction transaction = null;
            try
            {
                command.Parameters.Clear();
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;

                command.CommandText = "UPDATE `user` SET `aktualistoke`=@aktualis WHERE `nev`=@nev ";

                command.Parameters.AddWithValue("@aktualis", ujadat.AktualisToke);
                command.Parameters.AddWithValue("@nev", ujadat.VersenyzoNeve);
                command.ExecuteNonQuery();

                command.Parameters.Clear();

                command.Transaction.Commit();

            }
            catch (Exception ex)
            {
                try
                {
                    command.Transaction.Rollback();
                }
                catch (Exception e)
                {
                    throw new DBManagementExept("Végzetes hiba történt! A tranzakció lezárása nem sikerült!", e);
                }
                throw new DBManagementExept("Aktualistőke frissítés sikertelenül zárult! Folyamat visszaállítva!", ex);
            }
        }
        #endregion

        #region MySQL Inserts
        public static void UjFelhasznaloREG(User ujadat)
        {
            MySqlTransaction transaction = null;
            try
            {
                command.Parameters.Clear();
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;

                command.CommandText = "INSERT INTO `user` (`nev`,`loginname`,`loginpass`) VALUES (@nev,@loginname,@loginpass)";
                command.Parameters.AddWithValue("@nev",ujadat.VersenyzoNeve);
                command.Parameters.AddWithValue("@loginname",ujadat.LoginName);
                command.Parameters.AddWithValue("@loginpass",ujadat.LoginPass);

                command.ExecuteNonQuery();
                command.Parameters.Clear();

                command.Transaction.Commit();

            }
            catch (Exception ex)
            {
                try
                {
                    command.Transaction.Rollback();
                }
                catch (Exception e)
                {
                    throw new DBManagementExept("Végzetes hiba történt! A tranzakció lezárása nem sikerült!", e);
                }
                throw new DBManagementExept("Adat beszúrás sikertelenül zárult! Folyamat visszaállítva!", ex);
            }
        }



        public static void UjJegyzes (User felhasznalo, Pozicio ujadat)
        {
            MySqlTransaction transaction = null;
            try
            {

                command.Parameters.Clear();
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;

                command.CommandText = "INSERT INTO `pozicio` (`nevid`,`ticket`,`devizapar`,`mennyiseg`,`pricenyit`,`stop`,`cel`,`zar`,`vegosszeg`,`keputvonal`,`megjegyzes`,`valasztottidosik`,`jegyzettido`) VALUES (@nevid,@ticket,@devizapar,@mennyiseg,@pricenyit,@stop,@cel,@zar,@vegosszeg,@keputvonal,@megjegyzes,@valasztottidosik,@jegyzettido)";

                command.Parameters.AddWithValue("@nevid",felhasznalo.VersenyzoNeve);
                command.Parameters.AddWithValue("@ticket",ujadat.Ticket);
                command.Parameters.AddWithValue("@devizapar",ujadat.Devizapar);
                command.Parameters.AddWithValue("@mennyiseg",ujadat.Mennyiseg);
                command.Parameters.AddWithValue("@pricenyit",ujadat.PriceNyit);
                command.Parameters.AddWithValue("@stop",ujadat.Stop);
                command.Parameters.AddWithValue("@cel",ujadat.Cel);
                command.Parameters.AddWithValue("@zar",ujadat.Zar);
                command.Parameters.AddWithValue("@vegosszeg",ujadat.Vegosszeg);
                command.Parameters.AddWithValue("@keputvonal",ujadat.Keputvonal);
                command.Parameters.AddWithValue("@megjegyzes",ujadat.Megjegyzes);
                command.Parameters.AddWithValue("@valasztottidosik",ujadat.ValasztottIdosik);
                command.Parameters.AddWithValue("@jegyzettido",ujadat.JegyzettIdo);
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                command.Transaction.Commit();


            }

            catch (Exception ex)
            {
                try
                {
                    command.Transaction.Rollback();
                }
                catch (Exception e)
                {
                    throw new DBManagementExept("Végzetes hiba történt! A tranzakció lezárása nem sikerült!", e);
                }
                throw new DBManagementExept("Bejegyzés sikertelenül zárult! Folyamat visszaállítva!", ex);
            }

        }
        #endregion

        #region Mysql delete ticket
        public static void JegyzesTorlese(Pozicio jegyzettertek)
        {
            MySqlTransaction transaction = null;
            try
            {
                command.Parameters.Clear();
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;

                command.CommandText = "DELETE FROM `pozicio` WHERE `ticket`=@ticket";
                command.Parameters.AddWithValue("@ticket", jegyzettertek.Ticket);
                command.ExecuteNonQuery();
                command.Transaction.Commit();

            }
            catch (Exception ex)
            {
                try
                {
                    command.Transaction.Rollback();
                }
                catch (Exception e)
                {
                    throw new DBManagementExept("Kritikus hiba! A tranzakció lezárása nem sikerült!", e);
                }
                throw new DBManagementExept("Ticket törlése sikertelen volt!", ex);
            }
        }
        #endregion


    }
}
