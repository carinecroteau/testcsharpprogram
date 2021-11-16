namespace POO 
{
    public class Employe
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public double TauxHoraire { get; set; }
        public double HeuresTravail { get; set; } = 40;

        public Employe(string nom, string prenom, double tauxHoraire) 
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.TauxHoraire = TauxHoraire;
        }

        public Employe(string nom, string prenom, double tauxHoraire, double heuresTravail) 
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.TauxHoraire = TauxHoraire;
            this.HeuresTravail = heuresTravail;
        }   

        public string NomComplet()
        {
            return Prenom + " " + Nom;
        }   

        public double SalaireHebdomadaire()
        {
            return this.TauxHoraire * this.HeuresTravail;
        }  
    }
}

