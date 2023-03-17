using System;

    namespace Bibliotheque {
        public class Emprunt {

            // attributs
            private string nomLivre {get; set;}
            private int tomeLivre {get; set;}
            private DateTime dateEmprunt {get; set;}
            private string frequenceEmprunt {get; set;}
            private string tempsEmprunt {get; set;}
            


            // constructeurs
            // <summary>
                // Constructeur par défaut
            // </summary>
            public Emprunt(string nomLivre, int tomeLivre, DateTime dateEmprunt, string frequenceEmprunt, string tempsEmprunt) {
                this.nomLivre = nomLivre;
                this.tomeLivre = tomeLivre;
                this.dateEmprunt = dateEmprunt;
                this.frequenceEmprunt = frequenceEmprunt;
                this.tempsEmprunt = tempsEmprunt;
            }


            // Méthodes
            public void ConsulterEmprunt() {
                Console.WriteLine("Nom du livre : ", nomLivre);
                Console.WriteLine("Tome : ", tomeLivre);
                Console.WriteLine("Date de l'emprunt : ", dateEmprunt.ToShortDateString());
                Console.WriteLine("temps de l'emprunt : ", tempsEmprunt);
            }
        }
    }