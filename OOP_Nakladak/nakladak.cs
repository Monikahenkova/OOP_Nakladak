using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Nakladak
{
    public class nakladak
    {
        public string Znacka { get; set; }
        public int Nosnost { get; set; }
        public int Nalozeno { get; set; }
        public int Objemnadrze { get; set; }
        public int Spotreba { get; set; }
        public int Palivo { get; set; }
        public int Vzdalenost { get; set; }

        

        public nakladak()
        {
            Nosnost = 0;
            Nalozeno = 0;
            Objemnadrze = 0;
            Spotreba = 0;
            Palivo = 0;
            Vzdalenost = 0;
        }






    }
}
