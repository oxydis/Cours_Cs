/* MODULES */
using System;

namespace Code
{
    class conditions
    {
        static void Main(string[] args)
        {

            int age = 16;

            if (age >= 18) /* SI MON AGE EST SUPERIEUR A 18 ALORS */ 
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else { /* SINON */ 
                Console.WriteLine("Vous n'êtes pas majeur");
            }

            /* 2EME METHODE */ 

            int age2 = 18;

            bool majeur = (age2 >= 18); /* ON SE RAPELLE QUE : BOOL EST SOIT TRUE OE FALSE */ 

            Console.WriteLine(majeur);

            if (majeur) {
                Console.WriteLine("Vous êtes majeur");
            }           
            
             /* 3EME METHODE */

             string login = "oxydis";
             string password = "1234";

             if(login == "oxydis" && password == "1234" ) 
             {
                 Console.WriteLine("Vous êtes connecté");
             }
             else 
             {
                Console.WriteLine("Erreur, verifiez vos identifants");
             }

             /* 4EME METHODE */ 

            int age3 = 16;

            if(age == 18)
            {
                Console.WriteLine("Vous avez 18 ans ");
            }
            else if(age3 == 16 )
            {
                Console.WriteLine("Vous avez 16 ans ");
            }
        }
    }
}