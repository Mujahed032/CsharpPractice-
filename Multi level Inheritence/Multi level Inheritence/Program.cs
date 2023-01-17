namespace Multi_level_Inheritence
{
    class Car
    {
        internal string model;
        internal string color;
        internal int price;

        internal void printCarInfo()
        {
            Console.WriteLine("model:" + model);
            Console.WriteLine("color:" + color);
            Console.WriteLine("price:" + price);
        }
    }
    class Ferrari : Car
    {
        internal int speed;

        internal void printspeed()
        {
            Console.WriteLine("speed:" + speed);
        }
    }
    class Maruti : Ferrari
    {
        double mileage;
        internal void Displaymileage()
        {
            Console.WriteLine("mileage:" + mileage);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Maruti mycar = new Maruti();
            mycar.model = "Alto";
            mycar.color = "Red";
            mycar.price = 20000;
            mycar.speed = 500;
            mycar.printCarInfo();
            mycar.Displaymileage();
            mycar.printspeed();
            Console.ReadLine();

        }
    }
}