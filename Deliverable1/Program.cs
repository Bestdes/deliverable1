using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacationType = 0;
            int sizeOfGroup = 0;
            string result;

            string destination = "";
            string travelMethod = "";


            while (vacationType < 1 || vacationType > 3)
            {
                Console.WriteLine("What type of Vacation would you like to go on?");
                Console.WriteLine("-- Enter the Number: 1 for Musical");
                Console.WriteLine("-- Enter the Number: 2 for Tropical");
                Console.WriteLine("-- Enter the Number: 3 for Adventurous");
                vacationType = int.Parse(Console.ReadLine());
                
                if (vacationType < 1 || vacationType > 3)
                {
                    Console.WriteLine("Invalid Response, Try Again!");
                }
            }

            while (sizeOfGroup < 1)
            {
                Console.WriteLine("And how many people going on this trip?");
                sizeOfGroup = int.Parse(Console.ReadLine());

                if (sizeOfGroup < 0)
                {
                    Console.WriteLine("Invalid Response, Try Again!");
                }
            }

          
            if (vacationType == 1)
            {
                destination = "New Orleans";
            }
            if (vacationType == 2)
            {
                destination = "Beach Vacation in Mexico";
            }
            if (vacationType == 3)
            {
                destination = "Whitewater Rafting in Grand Canyon";
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

            result = "Based upon your selections it is recommended that your vacation destination be: " + destination + " via " + travelMethod + "!";

            Console.WriteLine(result);

        }

    }
}
