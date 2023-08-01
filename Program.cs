using System;
using System.Collections.Generic;


namespace compsite;


class Program
{
    static void Main()
    {
        // Création de l'arbre généalogique à partir du premier géniteur
        Person premierGeniteur = new Person("Père");

        Person enfant1 = new Person("Enfant 1");
        Person enfant2 = new Person("Enfant 2");
        Person enfant3 = new Person("Enfant 3");

        premierGeniteur.AddChild(enfant1);
        premierGeniteur.AddChild(enfant2);
        premierGeniteur.AddChild(enfant3);

        Person petitEnfant1 = new Person("Petit-Enfant 1");
        Person petitEnfant2 = new Person("Petit-Enfant 2");

        enfant1.AddChild(petitEnfant1);
        enfant2.AddChild(petitEnfant2);

        // Affichage de l'arbre généalogique
        Console.WriteLine(premierGeniteur.ToString());
    }
}