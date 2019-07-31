using System;
using System.Collections.Generic;

namespace Lab8Breakout
{
    class FormatException : SystemException
    {
        static void Main(string[] args)
        {


            Student s1 = new Student("Dakota Slabbekoorn", "Kent City, MI", "Pho", "purple");
            Student s2 = new Student("Joshua Bultsma", "Grand Rapids, MI", "Cheese tortellini", "orange");
            Student s3 = new Student("James Dockery", "Grand Rapids, MI", "Cheeseburgers and fries", "white");
            Student s4 = new Student("Maricela Rivera", "Morelia, Mexico", "Tacos", "red");
            Student s5 = new Student("Sam Thomson", "Grand Rapids, MI", "Tacos", "pink");

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);



            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 0-" + students.Count + "):");

                int pick = 0;
                try
                {
                    string input = Console.ReadLine();
                    pick = int.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("A valid int was not given");
                }
                while (pick >= 5)
                {
                    Console.WriteLine("That student does not exist. Please try again. (enter a number 0-4):");
                    pick = int.Parse(Console.ReadLine());

                }
                Student s = students[pick];
                string name = s.GetName();
                Console.WriteLine("Student " + pick + " is " + name + ". What would you like to know about " + name + "? (enter 'hometown' or 'favorite food' or 'favorite color':");


                string interest = Console.ReadLine();

                if (interest.Contains("hometown"))
                {
                    string hometown = s.GetHomeTown();
                    Console.Write(name + " is from " + hometown);

                }
                else if (interest.Contains("favorite food"))
                {
                    string favoritefood = s.GetFavoriteFood();
                    Console.Write(name + "'s favorite food is " + favoritefood);
                }
                else if (interest.Contains("favorite color"))
                {
                    string favoritecolor = s.GetFavoriteColor();
                    Console.Write(name + "'s favorite color is " + favoritecolor);
                }
                else
                {
                    while (!interest.Contains("hometown") && !interest.Contains("favorite food") && !interest.Contains("favorite color"))
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
            bool conti = true;
            while (conti)
            {
                Console.WriteLine("Would you like to add another student? (enter 'yes' or 'no'):");
                string response = Console.ReadLine();

                if (response == "Yes" || response == "yes" || response == "YES")
                {
                    conti = true;
                    Student create = new Student();
                    Console.WriteLine(create);
                }
                else if (response == "No" || response == "no" || response == "NO")
                {
                    conti = false;
                }
            }

                Console.WriteLine("\nThanks!");

            }
        }
    }
