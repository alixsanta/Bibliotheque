using System;

    namespace Bibliotheque {
        public class Livre {

            // attributs
            private string nomLivre {get; set;}
            private int tomeLivre {get; set;}
            private DateTime dateSortieLivre {get; set;}
            private string langueLivre {get; set;}
            private int nombreEnStock {get; set;}
            private string categorieAge {get; set;}
            private string nomAuteur {get; set;}
            private string prenomAuteur {get; set;}


            // constructeurs
            // <summary>
            // Constructeur par défaut
            // </summary>
            public Livre(string nomLivre, int tomeLivre, DateTime dateSortieLivre, string langueLivre, int nombreEnStock, string categorieAge, string nomAuteur, string prenomAuteur) {
                this.nomLivre = nomLivre;
                this.tomeLivre = tomeLivre;
                this.dateSortieLivre = dateSortieLivre;
                this.langueLivre = langueLivre;
                this.nombreEnStock = nombreEnStock;
                this.categorieAge = categorieAge;
                this.nomAuteur = nomAuteur;
                this.prenomAuteur = prenomAuteur;
            }


            // Méthodes

            public void AfficherLivre() {
                Console.WriteLine("Nom du livre : ", nomLivre);
                Console.WriteLine("Tome : ", tomeLivre);
                Console.WriteLine("Date de sortie : ", dateSortieLivre.ToShortDateString());
                Console.WriteLine("langue : ", langueLivre);
                Console.WriteLine("nombre en stock : ", nombreEnStock);
                Console.WriteLine("catégorie : ", categorieAge);
                Console.WriteLine("Auteur : ", nomAuteur + ", " + prenomAuteur);
            }

            public void AfficherTousLesLivres(List<Livre> livres) {
                foreach (Livre livre in livres) {
                    livre.AfficherLivre();
                    Console.WriteLine();
                }
            }   

        }
    }