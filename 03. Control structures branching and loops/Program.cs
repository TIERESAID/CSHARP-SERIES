using System;

namespace _03._Control_structures_branching_and_loops
{
    class Program
    {
        static  void Main(string[] args)
        {

            int numberOfPlayer ;

            Console.WriteLine("How many player:");
            numberOfPlayer = Convert.ToInt32(Console.ReadLine());
            string[] playersName = new string[numberOfPlayer];

            for(int i = 0 ; i<numberOfPlayer ; i++){
                Console.WriteLine($"Enter the name of player {i+1}");
                playersName[i] = Console.ReadLine();
            }

            Random rand = new Random();
            int RandomNumberGuessedbyComputer = rand.Next(12,123);
            Console.WriteLine(RandomNumberGuessedbyComputer);

            int j = 0 ;
            int x = 0 ;
            do{
                if( j==numberOfPlayer )
                    j = 0;
                
                do
                {
                    Console.WriteLine($"Player[{j+1}]   ({playersName[j]}) : Enter a between [1-4]");
                    x = Convert.ToInt32(Console.ReadLine());
                }while(x<1 || x >4);

                // Soustraction with x
                RandomNumberGuessedbyComputer = RandomNumberGuessedbyComputer - x ;
                if(RandomNumberGuessedbyComputer < 0){
                    Console.WriteLine($"{playersName[j]} WIN THE GAME!" );
                    Console.WriteLine($"{playersName[j]} DO YOU WANT TO TAKE REVENGE? (YES OR NO)" );
                    string yesORno = Console.ReadLine();
                    if(yesORno == "YES" || yesORno == "yes"){
                        RandomNumberGuessedbyComputer = rand.Next(12,123);
                        j = -1;
                    }
                    else if(yesORno == "N0" || yesORno == "no"){
                        RandomNumberGuessedbyComputer = 0;
                        Console.WriteLine("END OF THE GAME");
                    }
                }
                j = j + 1 ;
            }while(RandomNumberGuessedbyComputer > 0);
            
            Console.ReadKey();

        }
    }
}
