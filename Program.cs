using System.Globalization;
using CsvHelper;
using System;
    namespace Bibliotheque {
        internal class Program
        {
            static void Main(string[] args)
            {
                bool sortie = false;
                while(true) {
                    Console.WriteLine("Bonjour et bienvenue dans votre logiciel de consultation du stock :");
                    Console.WriteLine();
                    Console.Write("1. Ajouter/Modifier un livre | ");
                    Console.Write("2. Ajouter/Modifier un emprunteur | ");
                    Console.Write("3. Consulter le stock | ");
                    Console.WriteLine("4. Consulter les emprunts en cours et passés d'un emprunteur |");

                    Console.Write("Sélectionnez une action : ");
                    string? action = Console.ReadLine();

                    switch(action) {
                        case "1":

                        break;
                        
                        case "2":
 
                        break;

                        case "3":
                            Console.WriteLine("Entrez un nom de livre : ");
                            string? choix = Console.ReadLine();

                            Livre livre1 = new Livre("Alice", 0, new DateTime(1900, 07, 09), "français", 5, "tout âge", "Caroll", "Lewis");
                            Livre.AfficherLivre(livre1);
                            break;

                        case "4":

                        break;

                        default:
                            Console.WriteLine("Choix invalide.");
                        break;
                    }

                }

                using var writer = new StreamWriter("Bibliotheque.csv");
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(Bibliothèque);
            }
        }
    }