/* MODULES */
using System;

namespace Code
{
    class calculs
    {
        static void Main(string[] args)
        {

            int note = 20;
            int moyenne = 0;
            moyenne = note + 8 / 2; /* 20 + 8 /2 | Je veut 14 mais le code me donne 24 */ 
            Console.WriteLine(moyenne);

            int note2 = 20;
            int moyenne2 = 0;
            moyenne2 = (note2 + 8) / 2; /* Je met "(note2 + 8) /2" pour définir la priorité*/ 
            Console.WriteLine(moyenne2);
            
        }
    }
}