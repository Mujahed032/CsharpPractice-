namespace AnimalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cat catAnimal = new Cat("Cat",false);
            ////string soundOfCat = catAnimal.MakesSound();

            //Horse horseAnimal = new Horse("Horse", false);
            //horseAnimal.MakesSound();

            //pigeon pigeonAnimal = new pigeon("pigeon", true);
            //pigeonAnimal.MakesSound();

            Animal userSelectedAnimal;

            
            Console.WriteLine("Choose an animal: /n 1: Cat /n 2.Horse /n 3.Pigeon " );


            Console.WriteLine("Choose a number from the above options:");
            var userEnteredNumber = int.Parse(Console.ReadLine());
           

            if(userEnteredNumber == (int)AnimalType.Cat)
            {
                userSelectedAnimal = new Cat("Minnu", false);
            }
            else if(userEnteredNumber == (int)AnimalType.Horse)
            {
                userSelectedAnimal = new Horse("Chetak", false);
            }
            else 
            {
                userSelectedAnimal = new pigeon("kabutar",true);
            }

            int insuranceAmount = userSelectedAnimal.GetInsurance();

            Console.WriteLine($"The insurance for your selected animal {userSelectedAnimal.Name} is {insuranceAmount}");

            userSelectedAnimal.DescribeMe();

        }
    }
}