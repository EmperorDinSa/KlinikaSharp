using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikaSharp.Baza
{
    public class Kontraktor
    {
        public Radnik Radnik { get; set; }
        public decimal Provizija { get; set; }
        public bool UProcentima { get; set; }
        //lista dostupnosti?!

        public Kontraktor() { }
    }
}
