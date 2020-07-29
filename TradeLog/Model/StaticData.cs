using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TradeLog.Model
{
    static class StaticData
    {
        
        internal static List<User> usersData = new List<User>();        //Fo lista memoria tarolashoz.
        static object kivalaszt;                                        //objektum a bejelentkező tárolásához Kiválasztáskor
        internal static bool ServerStatus = true;                       //Server status futtatáskor értéket kap ha van érvények connect.
        internal static bool frChange = true;                           //FirstRun Change megakadályozza a winload töltését, ha már egyszer megtette.
        internal static string commitversion = "1.61";                  //version szam.


        internal static bool Validalas (List<User> adatok,string teljesnev)
        {
            bool validalas = false;
            foreach (User item in adatok)
            {
                if (teljesnev == item.VersenyzoNeve)
                {
                    validalas = true;
                }
            }
            return validalas;
        }                                                   // Belépési validálás
           
        internal static bool Kereses (List<User> adatok, string beirtnev, string jelszo)
        {
            bool adatEgyezesKereses = false;
            foreach (User item in adatok)
            {
                if (beirtnev == item.LoginName && jelszo == item.LoginPass)
                {
                    adatEgyezesKereses = true;

                }
            }
            return adatEgyezesKereses;
        }                                      // Keresés , van e már ilyen felhasználó egyáltalán.

        internal static Object Kivalasztott(List<User> adatok, string beirtnev, string jelszo)
        {
            foreach (User item in adatok)
            {
                if (beirtnev == item.LoginName && jelszo == item.LoginPass)
                {
                    kivalaszt = item;

                }

            }
            return kivalaszt;
        }

        static public List<Pozicio> Rendezes(List<Pozicio> kuldottLista)
        {
            List<Pozicio> rendezettLista = new List<Pozicio>();
            foreach (Pozicio item in kuldottLista)
            {
                rendezettLista.Add(item);
            }
            rendezettLista.Sort((x, y) => y.JegyzettIdo.CompareTo(x.JegyzettIdo));
            return rendezettLista;
        }
        static public List<User> BetoltottFelhasznalok()
        {
            List<User> CsakRegisztralt = new List<User>();
            List<User> osszetettAdatok = new List<User>();
            List<User> kimenet = new List<User>();
         
            CsakRegisztralt = SQL.DBManagement.CsakUserDBKiolvasasTokevel();
            osszetettAdatok = SQL.DBManagement.DBKiolvasas();

            foreach (User item in CsakRegisztralt)
            {
                kimenet.Add(item);
            }
            foreach (User item in osszetettAdatok)
            {
                kimenet.Add(item);
            }
            return kimenet;
        }
       
        static internal void XMLLoad()
        {
            if (File.Exists("Users.xml"))
            {
                XDocument users = XDocument.Load("Users.xml");
                usersData = (from user in users.Root.Elements("User")
                                              select new User(user)).ToList();
            }
        }           // XML - Betöltés , ha nincs sql szerver.
        static internal void XMLSave()
        {
            XDocument users = new XDocument(new XElement("User"));
            foreach (User item in usersData)
            {
                users.Root.Add(item.UserToXML());
            }
            users.Save("Users.xml");
        }           // XML - Mentés , ha nincs sql szerver.


    }
}
