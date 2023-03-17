using System;

    namespace Bibliotheque {
        public class Auteur {

            // attributs
            private string nomAuteur {get; set;}
            private string prenomAuteur {get; set;}
            private string genre {get; set;}
            private string livre {get; set;}


            // constructeurs
            // <summary>
            // Constructeur par défaut
            // </summary>
            public Auteur(string nomAuteur, string prenomAuteur, string genre, string livre) {
                this.nomAuteur = nomAuteur;
                this.prenomAuteur = prenomAuteur;
                this.genre = genre;
                this.livre = livre;
            }


            // Méthodes
            public void AfficherAuteur() {
                Console.WriteLine("Nom : {0}", nomAuteur);
                Console.WriteLine("prenom : {0}", prenomAuteur);
                Console.WriteLine("genre : {0}", genre);
                Console.WriteLine("livre : {0}", livre);
            }

        }
    }