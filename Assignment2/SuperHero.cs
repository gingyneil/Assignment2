using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SuperHero : Hero
    {
       string[] superPowers = { "Super	Speed", "Super	Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
       string[] newArray = new string[3];
       int index =0;

        public SuperHero(string name) : base(name)
        {
            generateRandomPowers();
        
        }







        public void generateRandomPowers()
        {
           Random rnd = new Random();
       
            while (index < newArray.Length)
            {
            
            
            
            
            
            
            
            
            
            
            }
       
       }










        private static int generateRandomPowerMember(Random rnd) 
        {
            int randomPower;

            randomPower = rnd.Next(6);
            Console.WriteLine("My Randome power is {0}", randomPower);
            return randomPower;
        }


    
    }
}
