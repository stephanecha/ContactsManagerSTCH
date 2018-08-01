using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> contacts = new List<string>();


            do
            {
                AffichageMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        ListeDesContacts(contacts);
                        break;

                    case "2":
                        AjoutdunContact(contacts);
                        break;

                    case "3":
                        SupressiondunContact(contacts);
                        break;

                    case "4":
                        Console.WriteLine("Merci au revoir.......");
                        Environment.Exit(0);
                        break;
                }
            } while (true);

            Console.WriteLine("taper une touche.......");
            Console.ReadKey();
        }

        static void AffichageMenu()
        {
            Console.WriteLine("1-Liste des contacts \n2-Ajout d'un contact \n3-Suppression d'un contact\n4-Quitter");
        }

        static void ListeDesContacts(List<string> contacts)
        {

            Console.WriteLine("Liste des contacts:\n");

            foreach (string element in contacts)
            {
                Console.WriteLine(element);

            }

        }
        static void AjoutdunContact(List<string> contacts)
        {
            Console.WriteLine("Entrer contact à ajouter:\n");
            contacts.Add(Console.ReadLine());
        }

        static void SupressiondunContact(List<string> contacts)
        {

            Console.WriteLine("Entrer contact à supprimer:\n");

            contacts.Remove(Console.ReadLine());

        }

    }
}
