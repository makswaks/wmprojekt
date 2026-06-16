using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wmprojekt
{
    public class Mannschaft
    {
        private string name;
        private int punkte;
        private int spiele;
        private int tore;

        public Mannschaft(string name)
        {
            this.name = name;
            punkte = 0;
            spiele = 0;
            tore = 0;
        }

        public string Name { get { return name; } }
        public int Punkte { get { return punkte; } }
        public int Spiele { get { return spiele; } }
        public int Tore { get { return tore; } }

        public void ErgebnisMelden(int eigeneTore, int gegnerTore)
        {
            spiele++;
            tore += eigeneTore;

            if (eigeneTore > gegnerTore)
                punkte += 3;
            else if (eigeneTore == gegnerTore)
                punkte += 1;
        }

        public override string ToString()
        {
            return name + " | Punkte: " + punkte +
                   " | Spiele: " + spiele + " | Tore: " + tore;
        }
    }
}
