using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SuperHero : Hero
    {
       private string[] superPowers = { "SUPER SPEED", "SUPER STRENGTH", "BODY ARMOR", "FLIGHT", "FIRE GENERATION", "WEATHER CONTROL" };
       string[] newArray = new string[3];
       int index =0;
       int randomPower;
        public SuperHero(string name) : base(name)
        {
            generateRandomPowers();
        
        }







        private void generateRandomPowers()
        {
           Random rnd = new Random();
       
            while (index < newArray.Length)
            {
                randomPower = generateRandomPowerMember(rnd);

                if (superPowers[randomPower] != "unavailable") 
                {
                    newArray[index] = superPowers[randomPower];

                    superPowers[randomPower] = "unavailable";

                    index++;
                }

           
            
             }
       
         }


        public void showPowers() 
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Your first advanced Super Power is {0}",superPowers[0]);
            Console.WriteLine("Your second advanced Super Power is {0}", superPowers[1]);
            Console.WriteLine("Your third advanced Super Power is {0}", superPowers[2]);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
       
        }







        private int generateRandomPowerMember(Random rnd) 
        {
            

            randomPower = rnd.Next(6);
            //Console.WriteLine("My Random power is {0}", randomPower);
            return randomPower;
        }


    
    }
}
