using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Neil Reading
 Student Number 300793474
 Comp123 Assignment 2
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
            SuperHero showme = new SuperHero("showme");
            showme.generateRandomPowers();
        }
    }
}
