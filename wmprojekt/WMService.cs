using System.Collections.Generic;

namespace wmprojekt
{
    public class WMService
    {
        private ErgebnisRepository repository;
        private List<Mannschaft> mannschaften;

        public WMService(ErgebnisRepository repo)
        {
            repository = repo;
            mannschaften = new List<Mannschaft>();
            mannschaften.Add(new Mannschaft("Deutschland"));
            mannschaften.Add(new Mannschaft("Curacao"));
            mannschaften.Add(new Mannschaft("Elfenbeinkueste"));
            mannschaften.Add(new Mannschaft("Ecuador"));

            // Gespeicherte Ergebnisse laden und Punkte berechnen
            List<Ergebnis> geladene = repository.LadeErgebnisse();
            foreach (Ergebnis e in geladene)
            {
                Mannschaft mH = FindeMannschaft(e.HeimTeam);
                Mannschaft mG = FindeMannschaft(e.GastTeam);
                if (mH == null || mG == null) continue;
                mH.ErgebnisMelden(e.ToreHeim, e.ToreGast);
                mG.ErgebnisMelden(e.ToreGast, e.ToreHeim);
            }
        }

        public bool ErgebnisEintragen(string heim, string gast,
                                       int toreHeim, int toreGast)
        {
            Mannschaft mH = FindeMannschaft(heim);
            Mannschaft mG = FindeMannschaft(gast);

            if (mH == null || mG == null) return false;

            mH.ErgebnisMelden(toreHeim, toreGast);
            mG.ErgebnisMelden(toreGast, toreHeim);

            repository.SpeichereErgebnis(new Ergebnis(heim, gast, toreHeim, toreGast));
            return true;
        }

        // AUFGABE 1 – FindeMannschaft()
        // Suche in der Liste mannschaften nach dem Namen
        // Wenn gefunden: return die Mannschaft
        // Wenn nicht gefunden: return null
        private Mannschaft FindeMannschaft(string name)
        {
            // Schritt 1: Gehe durch alle Mannschaften
            foreach (Mannschaft m in mannschaften)
            {
                // Schritt 2: Vergleiche den Namen
                if (m.Name == name)
                    return m;
            }
            // Schritt 3: Nichts gefunden
            return null;
        }

        // AUFGABE 2 – GetTabelle()
        // Gibt alle Mannschaften sortiert nach Punkten zurueck
        // Tipp: BubbleSort – den kennt ihr schon!
        public List<Mannschaft> GetTabelle()
        {
            // Schritt 1: Kopie erstellen (Original nicht veraendern!)
            List<Mannschaft> kopie = new List<Mannschaft>(mannschaften);

            // Schritt 2: BubbleSort – hoch nach niedrig
            for (int i = 0; i < kopie.Count - 1; i++)
            {
                for (int j = i + 1; j < kopie.Count; j++)
                {
                    // Schritt 3: Tauschen wenn j mehr Punkte hat als i
                    if (kopie[j].Punkte > kopie[i].Punkte)
                    {
                        Mannschaft temp = kopie[i];
                        kopie[i] = kopie[j];
                        kopie[j] = temp;
                    }
                }
            }
            return kopie;
        }

        public List<Ergebnis> GetErgebnisse()
        {
            return repository.LadeErgebnisse();
        }
    }
}