using System;

namespace Lab8Final
{
    public class FormatException : SystemException
    {
        public static void Main(string[] args)
        {
        
            string[] names = new string[5];
            names[0] = "Dakota Slabbekoorn";
            names[1] = "Joshua Bultsma";
            names[2] = "James Dockery";
            names[3] = "Maricela Rivera";
            names[4] = "Sam Thomson";

            string[] food = new string[5];
            food[0] = "pho";
            food[1] = "cheese tortellini";
            food[2] = "cheeseburgers and fries";
            food[3] = "tacos";
            food[4] = "tacos";

            string[] hometown = new string[5];
            hometown[0] = "Kent City, Michigan";
            hometown[1] = "Grand Rapids, Michigan";
            hometown[2] = "Grand Rapids, Michigan";
            hometown[3] = "Morelia, Mexico";
            hometown[4] = "Grand Rapids, Michigan";

            bool cont = true;
            while (cont)
            {

                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-5):");

                int userNum = int.Parse(Console.ReadLine());

                
                    while (userNum >= 6)
                    {
                        Console.WriteLine("That student does not exist. Please try again. (enter a number 1-5):");
                    userNum = int.Parse(Console.ReadLine());

                }
                


                Console.WriteLine("Student 10 is " + names[userNum] + ". What would you like to know about " + names[userNum] + "? (enter 'hometown' or 'favorite food':");

                    
                

            string interest = Console.ReadLine();
               
            //while (!interest.Contains("hometown") || !interest.Contains("favorite food"))
               // {
                //    Console.WriteLine("That data does not exist. Please try again. (enter 'hometown' or 'favorite food'):");
                //}

                if (interest.Contains("hometown"))
                {
                    Console.Write(names[userNum] + " is from " + hometown[userNum]);

                }
                else if (interest.Contains("favorite food"))
                {
                    Console.Write(names[userNum] + "'s favorite food is " + food[userNum]);
                }
                else
                {
                    while (!interest.Contains("hometown") && !interest.Contains("favorite food"))
                    {
                        Console.WriteLine("That data does not exist. Please try again. (enter 'hometown' or 'favorite food'):");
                    }
                }
                

                Console.WriteLine(". Would you like to know more? (enter 'yes' or 'no'):");
                string option = Console.ReadLine();

                if (option == "Yes" || option == "yes" || option == "YES")
                {
                    cont = true;
                }
                else if (option == "No" || option == "no" || option == "NO")
                {
                    cont = false;
                }






            }
            Console.WriteLine("\nThanks!");

        }
    }
}
