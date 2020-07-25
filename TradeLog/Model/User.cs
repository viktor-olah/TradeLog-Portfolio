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
        int _id;
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
   
        public int Id { get => _id; set => _id = value; }
        internal List<Pozicio> Kotesek { get => kotesek; set => kotesek = value; }
        public double AktualisToke { get => _aktualisToke; set => _aktualisToke = value; }

        public User(string versenyzoNeve, string loginName, string loginPass, int id, double aktualisToke)
        {
            VersenyzoNeve = versenyzoNeve;
            LoginName = loginName;
            LoginPass = loginPass;
            Id = id;
            AktualisToke = aktualisToke;
            kotesek = new List<Pozicio>();
        }

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

      
      
    }
}
