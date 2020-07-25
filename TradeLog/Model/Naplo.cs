using System;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Xml.Linq;

namespace TradeLog.Model
{
    

    internal class Naplo
    {
        double _aktualisToke;

        public double AktualisToke { get => _aktualisToke; set => _aktualisToke = value; }

        public Naplo(double aktualisToke)
        {
            AktualisToke = aktualisToke;
           
        }

        public Naplo (XElement naplonode)
        {
            if (naplonode.Name == "Naplo")
            {
                _aktualisToke = double.Parse(naplonode.Attribute("aktualistoke").Value);
            }
            else
            {
                throw new ArgumentException("A node csak Naplo tipusu lehet!");
            }
        }

        public XElement NaploToXML()
        {
            XElement naplo = new XElement("Naplo",
                new XAttribute("aktualistoke", _aktualisToke));

            return naplo;
        }

       
    }
}