using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikaSharp.Baza
{
    public class Radnik
    {
        public string ImePrezime { get; set; }
        public string Kontakt { get; set; }
        //listu plata i kad su promenjene Nova 
        public List<Plata> Plata = new List<Plata>();// da l'da bude objekat samo pa da plate hvatamo iz klase ili ovako.
        //public Dictionary<(DateTime, TimeSpan), new DateTime()>
        //Sintaksa, nismo znali sta dani u nedelji ?!
        public string Titula {get;set;}
        public string Uloga { get; set; }
        public string Pol { get; set; }
        
        public Radnik() { }

        public override string ToString()
        {
            return $"{Titula}. {ImePrezime},{Uloga}";
        }
    }
}
