using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three
{
    class Vehicle
    {
        public int cost { get; }
        public int speed { get; }
        public int yearIsue { get; }
        public int xLocation { get; }
        public int yLocation { get; }

        public Vehicle(int xLocation,int yLocation, int cost, int speed, int yearIsue)
        {
            this.cost = cost;
            this.speed = speed;
            this.yearIsue = yearIsue;
            this.xLocation = xLocation;
            this.yLocation = yLocation;
        }
    }

    class Plane : Vehicle
    {
        private int height;
        private int countPassengers;
        public Plane(int xLocation, int yLocation,int cost, int speed, int yearIsue)
           : base(xLocation,yLocation,cost, speed, yearIsue)
        {

        }
        public int Height
        { get { return height; }
          set { height = value; }
        }

        public int CountPassengers
        {
            get { return countPassengers; }
            set { countPassengers = value; }
        }

        public void about()
        {
            Console.WriteLine("Самалёт в координаты X= {0} Y= {1}, стоимость {2}, год выпуска {5}, кол-во пасажиров {3}, высота {4}",xLocation,xLocation ,cost,countPassengers, Height,yearIsue);
        }
    }
    class Ship : Vehicle
    {
        private int countPassengers;
        private string port;
        public Ship(int xLocation, int yLocation, int cost, int speed, int yearIsue)
           : base(xLocation, yLocation, cost, speed, yearIsue)
        {

        }

        public string Port
        {
            get { return port; }
            set { port = value; }
        }

        public int CountPassengers
        {
            get { return countPassengers; }
            set { countPassengers = value; }
        }

        public void about()
        {
            Console.WriteLine("Корабль в координатах X= {0} Y= {1}, стоимость {2}, год выпуска {5} кол-во пасажиров {3}, порт прибытя {4}", xLocation, xLocation, cost, countPassengers, port,yearIsue);
        }
    }
    class Car : Vehicle
    {
        public Car(int xLocation, int yLocation, int cost, int speed, int yearIsue)
           : base(xLocation, yLocation, cost, speed, yearIsue)
        {

        }

        public void about()
        {
            Console.WriteLine("Машина в координатах X= {0} Y= {1}, стоимость {2}, год выпуска {3}", xLocation, xLocation, cost,yearIsue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(7, 2, 200000, 200, 2018);
            plane.Height = 20;
            plane.CountPassengers = 3;
            Car car = new Car(2, 5, 150000, 180, 2019);
            Ship ship = new Ship(100, 25, 4000, 250, 2018);
            ship.CountPassengers = 4;
            ship.Port = "First";

            ship.about();
            car.about();
            plane.about();
            Console.ReadKey();
        }
    }
}
