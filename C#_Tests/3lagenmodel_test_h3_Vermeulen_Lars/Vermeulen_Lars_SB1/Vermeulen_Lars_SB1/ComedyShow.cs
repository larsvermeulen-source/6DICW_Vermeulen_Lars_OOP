namespace Vermeulen_Lars_SB1
{
    internal static class ComedyShow
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public class Comedyshow
        {
            private int intAantal = 0;
            private double dblTotaalscore = 0 ;
            readonly String StrLaatst;
            public ComedyShow(int intAantal , double dblTotaalscore, String StrLaatst)
            {
                _intAantal = intAantal ;
                _dblTotaalscore = dblTotaalscore ;
                _StrLaatst = StrLaatst ;
            }
            public int _intAantal
            {
                get { return _intAantal; }
                set { _intAantal = value; }
            }
            public double _dblTotaalscore
            {
                get { return _dblTotaalscore; }
                set { _dblTotaalscore = value; }
            }
            public String _StrLaatst
            {
                get { return _StrLaatst; }
                set { _StrLaatst= value; }
            }

            public void Add(String naam, double score)
            {
                dblTotaalscore += score;
                _StrLaatst = naam;
                BerekenGemiddelde();

            }
            public double BerekenGemiddelde()
            {
                return (dblTotaalscore / intAantal);
            }
        }
        
    }
}