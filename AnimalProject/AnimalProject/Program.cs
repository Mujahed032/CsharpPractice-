namespace AnimalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat catAnimal = new Cat("Cat",false);
            //string soundOfCat = catAnimal.MakesSound();

            Horse horseAnimal = new Horse("Horse", false);
            horseAnimal.MakesSound();

            //string soundOfHorse = horseAnimal.MakesSound();

            //Console.WriteLine($"The sound a horse makes is {soundOfHorse}");
            //Console.WriteLine($"The sound a cat makes is {soundOfCat}");

            Animal thisAnimal;

            thisAnimal = horseAnimal;

                thisAnimal.DescribeMe();
         

            thisAnimal = catAnimal;
            
           thisAnimal.DescribeMe();
            Console.ReadLine();

        }
    }
}