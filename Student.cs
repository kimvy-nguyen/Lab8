using System;


namespace Lab8Breakout
{
    class Student
    {
        public string Name;
        public string HomeTown;
        public string FavoriteFood;
        public string FavoriteColor;

        public Student(string name, string homeTown, string favoriteFood, string favoriteColor)
        {
            Name = name;
            HomeTown = homeTown;
            FavoriteFood = favoriteFood;
            FavoriteColor = favoriteColor;
        }

        string empty = System.String.Empty;

        public Student()
        {
            Console.WriteLine("Enter new student's name:");
            Name = Console.ReadLine();

            if (Name == empty)
            {
                throw new Exception("Enter valid input.");
            }
            Console.WriteLine("Enter new student's hometown:");
            HomeTown = Console.ReadLine();

            if (HomeTown == empty)
            {
                throw new Exception("Enter valid input.");
            }

            Console.WriteLine("Enter new student's favorite food:");
            FavoriteFood = Console.ReadLine();

            if (FavoriteFood == empty)
            {
                throw new Exception("Enter valid input.");
            }

            Console.WriteLine("Enter new student's favorite color:");
            FavoriteColor = Console.ReadLine();

            if (FavoriteColor == empty)
            {
                throw new Exception("Enter valid input.");
            }
        }


        public string GetName()
        {
            return Name;
        }

        public string GetHomeTown()
        {
            return HomeTown;
        }

        public string GetFavoriteFood()
        {
            return FavoriteFood;
        }

        public string GetFavoriteColor()
        {
            return FavoriteColor;
        }

    }
}
