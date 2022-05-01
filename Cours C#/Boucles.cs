/* MODULES */
using System;

namespace Code
{
    class boucles
    {
        static void Main(string[] args)
        {
            #region La boucle for
            for (int i = 1; i <= 10; i++) /* i = 1 SI I N'EST PAS EGAL A 10 ALORS CA VA PRINT DANS LA CONSOLE */ 
            {
                Console.WriteLine("Nombre n° " + i );
            }
            #endregion

            #region La boucle while
            Console.WriteLine("Tu dois appuyer sur la touche E");

            while (Console.ReadKey(true).Key != ConsoleKey.E) /* JE CHOISIT LA TOUCHE QUE JE VEUT APPUYER */
            {
                Console.WriteLine("Appuyez sur la touche E");
            }

            Console.WriteLine("Tu as appuyez sur la touche E !");
            Console.ReadKey(true);
            #endregion
        }
    }
}