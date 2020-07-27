using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace TradeLog.Model
{
    internal class Pozicio
    {


        string _ticket;
        string _devizapar;
        double _mennyiseg;
        double _priceNyit;
        double _stop;
        double _cel;
        double _zar;
        double _vegosszeg;
        string _keputvonal;
        string _megjegyzes;
        string _valasztottIdosik;
        DateTime _jegyzettIdo;

        internal static readonly string[] idosik = new string[8] { "1M", "5M", "15M", "30M", "1H", "4H", "1D", "1W" };

        public string Ticket
        {
            get => _ticket;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _ticket = value;
                }
                else
                {
                    throw new ArgumentException("Ticket szám megadása kötelező!");
                }
            }
        }
        public string Devizapar
        {
            get => _devizapar;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _devizapar = value;
                }
                else
                {
                    throw new ArgumentException("Devizapár megadása szükséges!");
                }

            }
        }
        public double Mennyiseg
        {
            get => _mennyiseg;
            set
            {

                if (value > 0)
                {
                    _mennyiseg = value;
                }
                else
                {
                    throw new ArgumentException("Lot mező kitöltése kötelező és értéke nem lehet negatív!");
                }

            }
        }
        public double PriceNyit
        {
            get => _priceNyit;
            set
            {
                if (value >= 0)
                {
                    _priceNyit = value;
                }
                else
                {
                    throw new ArgumentException("Price nyitási érték megadása kötelező és nem lehet negatív!");
                }
            }
        }
        public double Stop
        {
            get => _stop;
            set
            {
                if (value >= 0)
                {
                    _stop = value;
                }
                else
                {
                    throw new ArgumentException("Stop érték megadása kötelező és nem lehet negatív!");
                }

            }
        }
        public double Cel
        {
            get => _cel;
            set
            {
                if (value >= 0)
                {
                    _cel = value;
                }
                else
                {
                    throw new ArgumentException("Cél érték megadása kötelező és nem lehet negatív!");
                }
            }
        }
        public double Zar
        {
            get => _zar;
            set
            {
                if (value >= 0)
                {
                    _zar = value;
                }
                else
                {
                    throw new ArgumentException("Kérem adja meg a Záró értéket vagy adjon 0 értéket ha épít!");
                }
            }
        }
        public double Vegosszeg
        {
            get => _vegosszeg;
            set
            {

                _vegosszeg = value;


            }
        }
        public string Keputvonal { get => _keputvonal; set => _keputvonal = value; }
        public string Megjegyzes { get => _megjegyzes; set => _megjegyzes = value; }
        public string ValasztottIdosik
        {
            get => _valasztottIdosik;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _valasztottIdosik = value;
                }
                else
                {
                    throw new ArgumentException("Kérem válassza ki a használt idősíkot!");
                }
            }
        }
        public DateTime JegyzettIdo { get => _jegyzettIdo; set => _jegyzettIdo = value; }

        public Pozicio(string ticket, string devizapar, double mennyiseg, double priceNyit, double stop, double cel, double zar, double vegosszeg, string keputvonal, string megjegyzes, string valasztottIdosik)
        {
            Ticket = ticket;
            Devizapar = devizapar;
            Mennyiseg = mennyiseg;
            PriceNyit = priceNyit;
            Stop = stop;
            Cel = cel;
            Zar = zar;
            Vegosszeg = vegosszeg;
            Keputvonal = keputvonal;
            Megjegyzes = megjegyzes;
            ValasztottIdosik = valasztottIdosik;
            JegyzettIdo = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{JegyzettIdo} - Ticket Száma: {Ticket} - Devizapár:  {Devizapar}  - Választott idősík: {ValasztottIdosik} - Lot: {Mennyiseg} - Végösszeg: {Vegosszeg} EUR";
        }

        static internal double TalaltiArany(List<Pozicio> adatok)
        {
            double pozitiv = 0;
            double negativ = 0;
            double osszesKotes = 0;
            double talalatiarany = 0;


            foreach (Pozicio item1 in adatok)
            {
                if (item1.Vegosszeg > 0)
                {
                    pozitiv++;
                    osszesKotes++;
                }
                else
                {
                    negativ++;
                    osszesKotes++;
                }
            }

            talalatiarany = pozitiv / (pozitiv + negativ);

            return talalatiarany;
        }

        static internal double OsszNyereseg(List<Pozicio> adatok)
        {
            double osszeg = 0.00;
            foreach (Pozicio item in adatok)
            {
                osszeg = osszeg + item.Vegosszeg;
            }
            return osszeg;
        }

        static internal double PayOffRation(List<Pozicio> adatok)
        {
            double nyeresegAtlag = 0.00;
            double vesztesegAtlag = 0.00;
            List<double> nyeresegek = new List<double>();
            List<double> vesztesegek = new List<double>();


            foreach (Pozicio item1 in adatok)
            {
                if (item1.Vegosszeg > 0)
                {
                    nyeresegek.Add(item1.Vegosszeg);
                }
                else
                {
                    vesztesegek.Add(item1.Vegosszeg);
                }
            }
            if (nyeresegek.Count != 0)
            {
                nyeresegAtlag = nyeresegek.Average();
            }
            if (vesztesegek.Count != 0)
            {
                vesztesegAtlag = vesztesegek.Average();
            }


            double payOffRationValue = (nyeresegAtlag / vesztesegAtlag) * -1;

            return payOffRationValue;

        }

        static internal uint CelarMegvalosulas(List<Pozicio> adatok)
        {
            uint celarMegvalosulasSzamlalo = 0;
            foreach (Pozicio item in adatok)
            {
                if (item.Zar == item.Cel)
                {
                    celarMegvalosulasSzamlalo++;
                }
            }

            return celarMegvalosulasSzamlalo;
        }

        static internal uint Pozicioepites(List<Pozicio> adatok)
        {
            uint pozicioEpites = 0;
            foreach (Pozicio item in adatok)
            {
                if (item.Vegosszeg == 0)
                {
                    pozicioEpites++;
                }
            }

            return pozicioEpites;

        }

        static internal void ImageSave(string utvonal)
        {
            // v2.0 dev
        }
       

        /*
    public Pozicio(XElement pozicionode)
    {
        if (pozicionode.Name == "Kotes")
        {

            _ticket = pozicionode.Attribute("ticket").Value;
            _devizapar = pozicionode.Attribute("devizapar").Value;
            _mennyiseg = double.Parse(pozicionode.Attribute("mennyiseg").Value);
            _priceNyit = double.Parse(pozicionode.Attribute("pricenyit").Value);
            _stop = double.Parse(pozicionode.Attribute("stop").Value);
            _cel = double.Parse(pozicionode.Attribute("cel").Value);
            _zar = double.Parse(pozicionode.Attribute("zar").Value);
            _vegosszeg = double.Parse(pozicionode.Attribute("vegosszeg").Value);
            _keputvonal = pozicionode.Attribute("keputvonal").Value;
            _megjegyzes = pozicionode.Attribute("megjegyzes").Value;
            _valasztottIdosik = pozicionode.Attribute("valasztottidosik").Value;
            _jegyzettIdo = DateTime.Parse(pozicionode.Attribute("jegyzettido").Value);




        }
        else
        {
            throw new ArgumentException("A node csak Kotes (Poziciok) tipusu lehet!");
        }
    }

    public XElement PozicioToXML()
    {
        XElement pozicio = new XElement("Kotes",
             new XAttribute("ticket", _ticket),
             new XAttribute("devizapar", _devizapar),
             new XAttribute("mennyiseg", _mennyiseg),
             new XAttribute("pricenyit", _priceNyit),
             new XAttribute("stop", _stop),
             new XAttribute("cel", _cel),
             new XAttribute("zar", _zar),
             new XAttribute("vegosszeg", _vegosszeg),
             new XAttribute("keputvonal", _keputvonal),
             new XAttribute("megjegyzes", _megjegyzes),
             new XAttribute("valasztottidosik", _valasztottIdosik),
             new XAttribute("jegyzettido", _jegyzettIdo));
        return pozicio;

    }
        */
    }

}