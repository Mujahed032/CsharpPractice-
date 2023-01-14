namespace KeyPadIntToString
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Get value from Function.
            Console.WriteLine("Enter a number between 2 and 9: ");
            int numberEntered = int.Parse(Console.ReadLine());

            Char[] valueAtUserEnteredNumber = FunctionToGetValueFromANumber(numberEntered);

            if (valueAtUserEnteredNumber.Length == 0)
            {
                foreach (char x in valueAtUserEnteredNumber)
                {
                    Console.WriteLine(x);

                }
            }
            else
            {
                Console.WriteLine("You entered an invalid value: " + numberEntered);
            }

        }

      static char[] FunctionToGetValueFromANumber(int number)
        {
            Char[] valueToReturn = new Char[4];
           switch (number)
            {
                case 2:
                    valueToReturn[0] = 'a';
                    valueToReturn[1] = 'b';
                    valueToReturn[2] = 'c';
                    break;
                case 3:
                    valueToReturn[0] = 'd';
                    valueToReturn[1] = 'e';
                    valueToReturn[2] = 'f';
                    break;
                case 4:
                    valueToReturn[0] = 'g';
                    valueToReturn[1] = 'h';
                    valueToReturn[2] = 'i';
                    break;
                case 5:
                    valueToReturn[0] = 'j';
                    valueToReturn[1] = 'k';
                    valueToReturn[2] = 'l';
                    break;
                case 6:
                    valueToReturn[0] = 'm';
                    valueToReturn[1] = 'n';
                    valueToReturn[2] = 'o';
                    break;
                case 7:
                    valueToReturn[0] = 'p';
                    valueToReturn[1] = 'q';
                    valueToReturn[2] = 'r';
                    valueToReturn[3] = 's';
                    break;
                case 8:
                    valueToReturn[0] = 't';
                    valueToReturn[1] = 'u';
                    valueToReturn[2] = 'v';
                    break;
                case 9:
                    valueToReturn[0] = 'w';
                    valueToReturn[1] = 'x';
                    valueToReturn[2] = 'y';
                    valueToReturn[3] = 'z';
                    break;
                default:                   
                    break;

            } 
            return valueToReturn;
        }
    }
}