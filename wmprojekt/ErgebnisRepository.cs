using System;
using System.Collections.Generic;
using System.IO;

namespace wmprojekt
{
    public class ErgebnisRepository
    {
        private string dateipfad;

        public ErgebnisRepository()
        {
            dateipfad = "ergebnisse.csv";
        }

        // Alle Ergebnisse aus der CSV-Datei laden
        public List<Ergebnis> LadeErgebnisse()
        {
            List<Ergebnis> ergebnisse = new List<Ergebnis>();

            // Wenn Datei noch nicht existiert, leere Liste zurueckgeben
            if (!File.Exists(dateipfad))
                return ergebnisse;

            string[] zeilen = File.ReadAllLines(dateipfad);

            foreach (string zeile in zeilen)
            {
                // Zeile aufteilen: Deutschland;Curacao;8;0
                string[] teile = zeile.Split(';');

                string heim = teile[0];
                string gast = teile[1];
                int toreHeim = int.Parse(teile[2]);
                int toreGast = int.Parse(teile[3]);

                ergebnisse.Add(new Ergebnis(heim, gast, toreHeim, toreGast));
            }

            return ergebnisse;
        }

        // Ein neues Ergebnis an die CSV-Datei anhaengen
        public void SpeichereErgebnis(Ergebnis e)
        {
            string zeile = e.HeimTeam + ";" + e.GastTeam + ";" +
                           e.ToreHeim + ";" + e.ToreGast;

            File.AppendAllText(dateipfad, zeile + "\r\n");
        }
    }
}