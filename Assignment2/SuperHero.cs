using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Neil Reading 
 Student Number 300793474
 COMP 123 Assignment 2
 */
namespace Assignment2
{
    //Super Hero Class calls the Super Class +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    class SuperHero : Hero
    {

        // PRIVATE PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string[] superPowers = { "SUPER SPEED", "SUPER STRENGTH", "BODY ARMOR", "FLIGHT", "FIRE GENERATION", "WEATHER CONTROL" };
        string[] newArray = new string[3]; //Array to be loaded.

        private int randomPower;
        Random rnd = new Random();

        //CONSTRUCTOR - CALLS THE SUPERCLASS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public SuperHero(string name)
            : base(name)
        {
            generateRandomPowers();

        }





        //PRIVATE METHODS++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int generateRandomPowerMember(Random rnd)
        {


            randomPower = rnd.Next(6);

            return randomPower;
        }


        private void generateRandomPowers()
        {

            int index = 0;


            while (index < newArray.Length)
            {
                randomPower = generateRandomPowerMember(rnd);

                if (superPowers[randomPower] != "Unavailable")   //Loop jumps out and starts over if condition is not met.
                {
                    newArray[index] = superPowers[randomPower];
                    


                    superPowers[randomPower] = "Unavailable";
                    index++;

                }
            }
        }


            




        



        //PUBLIC METHODS++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void showPowers()
        {
            Console.WriteLine("            Super Powers                              ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Your first advanced Super Power is {0}", newArray[0]);
            Console.WriteLine("Your second advanced Super Power is {0}", newArray[1]);
            Console.WriteLine("Your third advanced Super Power is {0}", newArray[2]);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

        }

    }
}





       

    
    

