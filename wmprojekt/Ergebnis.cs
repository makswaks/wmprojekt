namespace wmprojekt
{
    public class Ergebnis
    {
        private string heimTeam;
        private string gastTeam;
        private int toreHeim;
        private int toreGast;

        public Ergebnis(string heim, string gast, int tHeim, int tGast)
        {
            heimTeam = heim;
            gastTeam = gast;
            toreHeim = tHeim;
            toreGast = tGast;
        }

        public string HeimTeam { get { return heimTeam; } }
        public string GastTeam { get { return gastTeam; } }
        public int ToreHeim { get { return toreHeim; } }
        public int ToreGast { get { return toreGast; } }

        public override string ToString()
        {
            return heimTeam + " " + toreHeim + " : " + toreGast + " " + gastTeam;
        }
    }
}