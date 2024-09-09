namespace GuessingNumber2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attemps = 0;
            const int MAX_ATTEMPS = 5;
            const int MIN = 1;
            const int MAX = 50;
            int inputNum = 0;
            int numOfAttemp = 0;


            Random rng = new Random();
            int randomNum = rng.Next(MIN, MAX);

            Console.WriteLine($"Try to guess the hidden number from {MIN} to {MAX} (You have {MAX_ATTEMPS} attemps):");

            while (inputNum != randomNum)
            {
                inputNum = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine($"Guess:{inputNum}");
                numOfAttemp++;
                Console.WriteLine($"Attemp:{numOfAttemp}");

                if (inputNum == randomNum)
                {
                    Console.WriteLine($"Congratulations, you have guess it!!\nThe hidden number is {randomNum}.\nYou have guess it in {numOfAttemp} attemps. ");

                    break;
                }
                if (numOfAttemp == MAX_ATTEMPS)
                {
                    Console.WriteLine($"You have reached you number of attemps.\nYou have lost.\nThe hidden number is {randomNum}");
                    break;
                }

                if (inputNum > randomNum)
                {
                    Console.WriteLine("The number is too high.");
                }
                else if (inputNum < randomNum)
                {
                    Console.WriteLine("The number is too low.");
                }
                if (Math.Abs(inputNum - randomNum) <= MAX_ATTEMPS)
                {
                    Console.WriteLine("You're close!");

                }
                Console.WriteLine("Try again");
            }
        }
    }
}