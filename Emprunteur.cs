using System;

    namespace Bibliotheque {
        public class Emprunteur {
            // attributs
            private string nomEmprunteur {get; set;}
            private string prenomEmprunteur {get; set;}
            private bool adherant {get; set;}
            private string nomLivre {get; set;}
            private string tomeLivre {get; set;}
            private DateOnly dateEmprunt {get; set;}
            private string dureeEmprunt {get; set;}
            


            // constructeurs
            // <summary>
                // Constructeur par défaut
            // </summary>
            public Emprunteur(string nomEmprunteur, string prenomEmprunteur, bool adherant, string nomLivre, string tomeLivre, DateOnly dateEmprunt, string dureeEmprunt) {
                this.nomEmprunteur = nomEmprunteur;
                this.prenomEmprunteur = prenomEmprunteur;
                this.adherant = adherant;
                this.nomLivre = nomLivre;
                this.tomeLivre = tomeLivre;
                this.dateEmprunt = dateEmprunt;
                this.dureeEmprunt = dureeEmprunt;
            }


            // Méthodes
            public void ConsulterEmprunteur() {
                Console.WriteLine("Nom : ", nomEmprunteur);
                Console.WriteLine("prenom : ", prenomEmprunteur);
                Console.WriteLine("Livre emprunté : ", nomLivre);
                Console.WriteLine("Date de l'emprunt : ", dateEmprunt.ToShortDateString());
                Console.WriteLine("temps de l'emprunt : ", dureeEmprunt);
            }
        }
    }