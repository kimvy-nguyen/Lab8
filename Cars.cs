using System;

namespace Bonus16
{
    class Cars
    {
        public string Make;
        public string Model;
        public int Year;
        public double Price;

        public Cars(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public Cars()
        {

        }


        public void SetMake(string _make)
        {
            Make = _make;
        }

        public void SetModel(string _model)
        {
            Model = _model;
        }

        public void SetYear(int _year)
        {
            Year = _year;
        }

        public void SetPrice(double _price)
        {
            Price = _price;
        }
    }
}