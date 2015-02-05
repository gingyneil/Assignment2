using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SuperHero : Hero
    {
       private string[] superPowers = { "Super	Speed", "Super	Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
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










        private int generateRandomPowerMember(Random rnd) 
        {
            

            randomPower = rnd.Next(6);
            //Console.WriteLine("My Random power is {0}", randomPower);
            return randomPower;
        }


    
    }
}
