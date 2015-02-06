using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Neil Reading
 Student Number 300793474
 Comp123 Assignment 2
 *Revision History
 *Feb/3/2015
 *Feb/4/2015
 *Feb/5/2015
 *Feb/6/2015 - Date Last Modified.
 *This is a Program that creates a Hero object and applies superpowers to that Hero. Then it calls a fight method and displays whether the hit attempt was successful or not.
 */
namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Neil = new Hero("Neil");
            Neil.show();
            Neil.fight();
          
            SuperHero NewSuperHero = new SuperHero("Neil");
            NewSuperHero.showPowers();
            NewSuperHero.fight();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            
        }
    }
}
