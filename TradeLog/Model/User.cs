using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml;
using System.Xml.Linq;

namespace TradeLog.Model
{
    class User
    {
       
        string _versenyzoNeve;
        string _loginName;
        string _loginPass;

        double _aktualisToke;

        List<Pozicio> kotesek;

        public string VersenyzoNeve
        {
            get => _versenyzoNeve;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _versenyzoNeve = value;
                }
                else
                {
                    throw new ArgumentException("Teljes név megadása kötelező!");
                }
            }
        }
        public string LoginName
        {
            get => _loginName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _loginName = value;
                }
                else
                {
                    throw new ArgumentException("Login név megadása kötelező!");
                }
            }
        }
        public string LoginPass
        {
            get => _loginPass;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _loginPass = value;
                }
                else
                {
                    throw new ArgumentException("Jelszó megadása kötelező!");
                }
            }
        }
   
  
        internal List<Pozicio> Kotesek { get => kotesek; set => kotesek = value; }
        public double AktualisToke { get => _aktualisToke; set => _aktualisToke = value; }

        //Már kereskedik / SQL
        public User(string versenyzoNeve, string loginName, string loginPass, double aktualisToke)
        {
            VersenyzoNeve = versenyzoNeve;
            LoginName = loginName;
            LoginPass = loginPass;
            AktualisToke = aktualisToke;
            kotesek = new List<Pozicio>();
        }
        // Csak regisztrál.
        public User(string versenyzoNeve, string loginName, string loginPass)
        {
            VersenyzoNeve = versenyzoNeve;
            LoginName = loginName;
            LoginPass = loginPass;
            kotesek = new List<Pozicio>();
            
        }


        public override string ToString()
        {
            return $"{VersenyzoNeve} - {LoginPass}";
        }


        // XML - Load
        public User(XElement usernode)
        {
            if (usernode.Name == "User")
            {
                _versenyzoNeve = usernode.Attribute("versenyzoNeve").Value;
                _loginName = usernode.Attribute("loginName").Value;
                _loginPass = usernode.Attribute("loginPass").Value;
                _aktualisToke = double.Parse(usernode.Attribute("aktualistoke").Value);
                kotesek = (from kotesek in usernode.Element("Kotesek_lista").Elements("Kotesek").Elements("Kotes") select new Pozicio(kotesek)).ToList();
            }
            else
            {
                throw new ArgumentException("A node csak User tipusu lehet!");
            }
        }

        // XML - Save
        public XElement UserToXML()
        {
            XElement user = new XElement("User",
                new XAttribute("versenyzoNeve", _versenyzoNeve),
                new XAttribute("loginName", _loginName),
                new XAttribute("loginPass", _loginPass),
                new XAttribute("aktualistoke", _aktualisToke),
                
                new XElement("Kotesek_lista", new XElement("Kotesek")));
            foreach (Pozicio item in kotesek)
            {
                user.Element("Kotesek_lista").Element("Kotesek").Add(item.PozicioToXML());
            }
         
            return user;
        }


    }
}
