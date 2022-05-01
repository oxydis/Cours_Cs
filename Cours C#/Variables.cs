/* MODULES */
using System;

namespace Code
{
    class variables
    {
        static void Main(string[] args)
        {
            int age = 16;           /* CETTE VARIABLE CONTIENT UN NOMBRE */
            int chiffre = 10;
            age = age + 1;          /* J'AJOUTE 1 A LA VARIABLE AGE | "age+= 1;" MARCHE AUSSI OU "age ++;" */ 
            age = age + chiffre;    /* 16 + 1 + 10 = 27 */ 
            Console.WriteLine("J'ai " + age + " ans."); /* EQUIVALANT AU PRINT */

            bool T = true;          /* CES 2 VARIABLES PEUVENT CONTENIR QUE TRUE ET FALSE => CONDITIONS */ 
            bool F = false;

            string txt = "Bonjour aujourd'hui "; /* CES 2 VARIABLES CONTIENENT DU TEXTE */
            string txt2 = "c'est le C#.";
            Console.WriteLine(txt + txt2);      /* J'AFFICHE MES VARIABLES DANS LA CONSOLE */ 

            string txt3 = "Voici quelques bases sur les (\"variables\")."; /* DANS CETTE VARIABLES JE PEUT AFFICHER LES PARENTHESES DANS LA CONSOLE*/ 
            Console.WriteLine(txt3);

            string txt4 = "Ligne 1\nLigne 2\nLigne 3"; /* LES "\n" PERMETTENT DE METTRE LES ELEMENTS A LA LIGNE */
            Console.WriteLine(txt4);

            string txt5 = "Liste :\n\t-5 Pommes\n\t-4 Oranges\n\t-1Kg de Farine"; /* DASN CETTE VARIABLE LE "\t-" FAIT UNE TABULATION DANS LA CONSOLE */
            Console.WriteLine(txt5);
            
        }
    }
}