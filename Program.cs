using System;

namespace POO
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Employe unEmploye = new Employe("Croteau", "Carine", 15.50);

            Employe unDeuxiemeEmploye = new Employe("Taleb", "Frédérik", 45.50, 60);
        
            Console.WriteLine(unEmploye.NomComplet());

            double salaireTotal = unEmploye.SalaireHebdomadaire() + unDeuxiemeEmploye.SalaireHebdomadaire();*/


            bool[] lab = {false,false,false,false,true,false,false,false,false,false};
            int position = 0;
            while(lab[position] == false)
            {
                position++;
            }
            Console.WriteLine(position);
            Console.ReadLine();

        }
    }
}
