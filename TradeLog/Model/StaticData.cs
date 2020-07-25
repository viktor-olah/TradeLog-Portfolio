using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TradeLog.Model
{
    static class StaticData
    {
        internal static List<User> usersData = new List<User>();
        static object kivalaszt;


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
        }

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
        }

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
       
    }
}
