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
    //Super Hero Class calls the Super Class +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    class SuperHero : Hero
    {
      
        // PRIVATE PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string[] superPowers = { "SUPER SPEED", "SUPER STRENGTH", "BODY ARMOR", "FLIGHT", "FIRE GENERATION", "WEATHER CONTROL" };
       string[] newArray = new string[3]; //Array to be loaded.
      
       int randomPower;
       Random rnd = new Random();
        public SuperHero(string name) : base(name)
        {
            generateRandomPowers();
        
        }




         private void generateRandomPowers()
        {
            
          int index = 0;
           
            
            while (index < newArray.Length)
            {
                randomPower = generateRandomPowerMember(rnd);

                if (superPowers[randomPower] != "Unavailable")
                {
                    newArray[index] = superPowers[randomPower];
                   // Console.WriteLine("{0}", newArray.Length);


                    superPowers[randomPower] = "Unavailable";
                    index++;

                }
                
                    
                    
             }




        }
        
        


        public void showPowers() 
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Your first advanced Super Power is {0}",newArray[0]);
            Console.WriteLine("Your second advanced Super Power is {0}", newArray[1]);
            Console.WriteLine("Your third advanced Super Power is {0}", newArray[2]);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
       
        }







        private int generateRandomPowerMember(Random rnd) 
        {
            

            randomPower = rnd.Next(6);
            
            return randomPower;
        }


    
    }
}
