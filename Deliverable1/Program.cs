using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            int destination = 0;
            int sizeOfGroup = 0;
            string result;

            string vacationType = "";
            string travelMethod = "";


            while (destination < 1 || destination > 3)
            {
                Console.WriteLine("What type of Vacation would you like to go on?");
                Console.WriteLine("-- Enter the Number: 1 for a Musical Vacation");
                Console.WriteLine("-- Enter the Number: 2 for a Tropical Vacation");
                Console.WriteLine("-- Enter the Number: 3 for an Adventurous Vacation");

                string wordInput = Console.ReadLine();
                if (int.TryParse(wordInput, out destination))
                {
                    destination = int.Parse(wordInput);
                }
                
                if (destination < 1 || destination > 3)
                {
                    Console.WriteLine("Invalid Response, Try Again!");
                }
            }

            while (sizeOfGroup < 1)
            {
                Console.WriteLine("And how many people are going on this trip?");
                sizeOfGroup = int.Parse(Console.ReadLine());

                if (sizeOfGroup < 1)
                {
                    Console.WriteLine("Invalid Response, Try Again!");
                }
            }


            // Below are the conditions that set the Variable that are inserted in the result phrase!

          
            if (destination == 1)
            {
                vacationType = "New Orleans";
            }
            if (destination == 2)
            {
                vacationType = "Beach Vacation in Mexico";
            }
            if (destination == 3)
            {
                vacationType = "Whitewater Rafting in Grand Canyon";
            }
       



            if (sizeOfGroup > 0)
            {
                travelMethod = "First Class";
            }
            if (sizeOfGroup > 2)
            {
                travelMethod = "Helicopter";
            }
            if (sizeOfGroup > 5)
            {
                travelMethod = "Charter Flight";
            }

            result = "Based upon your selections it is recommended that your vacation destination be: " + vacationType + " via " + travelMethod + "!";

            Console.WriteLine(result);

        }

    }
}
