using System;

namespace dice_generator_2;

class program
{
    static void Main()
    {
        Random random = new Random();
        int playerrandom = random.Next();
        bool playagain = true;
        String ans;

        while (playagain)
        {
            for (int i = 0; i < playerrandom; i++) ;
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                playerrandom = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerrandom);
            }
            if (playerrandom == 6)
            {
                Console.WriteLine("|----------------|");
                Console.WriteLine("|                |");
                Console.WriteLine("|   0    0   0   |");
                Console.WriteLine("|                |");
                Console.WriteLine("|                |");
                Console.WriteLine("|   0    0   0   |");
                Console.WriteLine("|                |");
                Console.WriteLine("|----------------|");
            }
            else if (playerrandom == 5)
            {
                Console.WriteLine("|----------------|");
                Console.WriteLine("|   0        0   |");
                Console.WriteLine("|                |");
                Console.WriteLine("|        0       |");
                Console.WriteLine("|                |");
                Console.WriteLine("|   0        0   |");
                Console.WriteLine("|----------------|");
            }
            else if (playerrandom == 4)
            {
                Console.WriteLine("|----------------|");
                Console.WriteLine("|                |");
                Console.WriteLine("|   0        0   |");
                Console.WriteLine("|                |");
                Console.WriteLine("|                |");
                Console.WriteLine("|   0        0   |");
                Console.WriteLine("|                |");
                Console.WriteLine("|----------------|");
            }
            else if (playerrandom == 3)
            {
                Console.WriteLine("|----------------|");
                Console.WriteLine("|   0            |");
                Console.WriteLine("|                |");
                Console.WriteLine("|        0       |");
                Console.WriteLine("|                |");
                Console.WriteLine("|             0  |");
                Console.WriteLine("|----------------|");
            }
            else if (playerrandom == 2)
            {
                Console.WriteLine("|----------------|");
                Console.WriteLine("|                |");
                Console.WriteLine("|   0            |");
                Console.WriteLine("|                |");
                Console.WriteLine("|                |");
                Console.WriteLine("|            0   |");
                Console.WriteLine("|                |");
                Console.WriteLine("|----------------|");
            }
            else
            {
                Console.WriteLine("|----------------|");
                Console.WriteLine("|                |");
                Console.WriteLine("|                |");
                Console.WriteLine("|       0        |");
                Console.WriteLine("|                |");
                Console.WriteLine("|                |");
                Console.WriteLine("|----------------|");
            }
            Console.Write("Would you like to play again? (Y/N): ");
            ans = Console.ReadLine();
            ans = ans.ToUpper();

            if (ans == "Y")
            {
                playagain = true;
            }
            else
            {
                playagain = false;
            }
        }
        Console.WriteLine("You may now close the application");
        Console.ReadKey();
    }
}
