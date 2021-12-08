using System;

namespace ConsoleApp1
{
    public interface ICarBehavior
    {
        void BaBu();
    }
    public class Car : ICarBehavior
    {
        private string name;

        public Car(string name, int tire = 0, int door = 0)
        {
            Name = name;
            Tire = tire;
            Door = door;
        }
        //public Car(int tire,int door)
        //{
        //    Tire = tire;
        //    Door = door;
        //}
        //public Car(int tire, string name, int door)
        //{
        //    Name = name;
        //    Tire = tire;
        //    Door = door;
        //}

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Tire { get; set; }
        public int Door { get; set; }

        public void BaBu()
        {
            Console.WriteLine("喇叭聲音");
        }

        public void Run()
        {

        }
        public void Run(string message)
        {

        }
    }

    public class Airplane : Car
    {
        public Airplane(string name, int tire = 0, int door = 0) : base(name, tire, door)
        {

        }
        public void Fly()
        {

        }
    }
}
