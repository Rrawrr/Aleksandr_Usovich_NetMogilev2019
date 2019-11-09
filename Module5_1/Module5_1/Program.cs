using System;

namespace Module5_1
{
    class Program
    {
        static string[,] display =
                                 {{ "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" },
                                  { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" },
                                  { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" },
                                  { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" },
                                  { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" },
                                  { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" },
                                  { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" },
                                  { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" },
                                  { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" },
                                  { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" },
                                  { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" },
                                  { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" }
                                };

        static int startPositionRow;
        static int startPositionColumn;

        static int currentPositionRow;
        static int currentPositionColumn;

        static int princessPositionRow;
        static int princessPositionColumn;

        static int currentHitPoints;

        static Tuple<int, int>[] bombPlaces = new Tuple<int, int>[10];
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            startPositionRow = 1;
            startPositionColumn = 1;

            princessPositionRow = 10;
            princessPositionColumn = 10;

            currentHitPoints = 10;

            currentPositionRow = startPositionRow;
            currentPositionColumn = startPositionColumn;

            display[currentPositionRow, currentPositionColumn] = "v";
            display[princessPositionRow, princessPositionColumn] = "p";

            PlaceBombs();

            Console.WriteLine("Here you are! Go find your Princess!");
            ShowDisplay(display);

            Console.WriteLine("Where do you want to go? Use arrows");
            Console.WriteLine();
            CheckInput();
        }

        static void PlaceBombs()
        {
            for(int counter=0;counter<bombPlaces.Length;)
            {
                int bombPlaceRow = rnd.Next(1, 11);
                int bombPlaceColumn = rnd.Next(1, 11);

                if ((bombPlaceRow == 1 && bombPlaceColumn == 1) || (bombPlaceRow == 10 && bombPlaceColumn == 10) || CheckBomb(bombPlaceRow, bombPlaceColumn))
                {
                    //do nothing.
                }
                else
                {
                    bombPlaces[counter] = Tuple.Create(bombPlaceRow, bombPlaceColumn);
                    counter++;
                }
            }
        }

        static bool CheckBomb(int positionRow, int positionColumn)
        {
            bool isBombThere = false;
            Tuple<int, int> nextStep = Tuple.Create(positionRow, positionColumn);
            foreach (var bomb in bombPlaces)
            {
                if (Equals(nextStep,bomb))
                {
                    isBombThere = true;
                    break;
                }
            }
            return isBombThere;
        }

        static void ReplaceBomb(int positionRow,int positionColumn)
        {
            Tuple<int, int> yourBomb = Tuple.Create(positionRow, positionColumn);
            {
                for (int counter = 0; counter < bombPlaces.Length; counter++)
                {
                    if (Equals(bombPlaces[counter], yourBomb))
                    {
                        bombPlaces[counter] = Tuple.Create(-1,-1);
                    }
                }
            }
        }

        static void Mover(int plusRow,int plusColumn)
        {
            int nextPositionRow = currentPositionRow + plusRow;
            int nextPositionColumn = currentPositionColumn + plusColumn;

            if (nextPositionRow <= 10 && nextPositionRow > 0 && nextPositionColumn <= 10 && nextPositionColumn > 0)
            {
                if (nextPositionRow == princessPositionRow && nextPositionColumn == princessPositionColumn)
                {
                    Move(plusRow, plusColumn,false);
                    WinCondition();
                }
                else if (CheckBomb(nextPositionRow, nextPositionColumn))
                {
                    GetDamage();
                    Move(plusRow, plusColumn,true);
                    ReplaceBomb(nextPositionRow, nextPositionColumn);
                    CheckInput();
                }
                else
                {
                    Move(plusRow, plusColumn,false);
                    CheckInput();
                }
            }
            else
            {
                Console.WriteLine("Can't go there!");
                CheckInput();
            }
        }

        static void Move(int plusRow, int plusColumn,bool hasGotDamage)
        {
            if (display[currentPositionRow, currentPositionColumn] != "o")
                display[currentPositionRow, currentPositionColumn] = ".";

            currentPositionRow += plusRow;
            currentPositionColumn += plusColumn;

            if(hasGotDamage)
                display[currentPositionRow, currentPositionColumn] = "o";
            else
                display[currentPositionRow, currentPositionColumn] = "v";
            ShowDisplay(display);
        }

        static void ShowDisplay(string[,] display)
        {
            for (int counterRow = 0; counterRow < 12; counterRow++)
            {
                for (int counterColumn = 0; counterColumn < 12; counterColumn++)
                {
                    Console.Write("{0} ", display[counterRow, counterColumn]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Health: " + currentHitPoints);
            Console.WriteLine();
        }

        static void GetDamage()
        {
            int damage = rnd.Next(1, 10);

            if ((currentHitPoints - damage) > 0)
            {
                Console.WriteLine("You've got into a trap " + damage + " damage!");
                currentHitPoints -= damage;
            }
            else
            {
                Console.WriteLine("You've got into a trap, " + damage + " damage!");
                currentHitPoints -= damage;
                LoseCondition();
            }
        }

        static void WinCondition()
        {
            Console.WriteLine("Congratulations! You have found the Princess!");
            Console.WriteLine("Do you want to play again? yes/no");
            Console.WriteLine();

            string input = Console.ReadLine();
            switch (input)
            {
                case "yes":
                    Restart();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        static void LoseCondition()
        {
            display[currentPositionRow, currentPositionColumn] = "x";
            ShowDisplay(display);
            Console.WriteLine("You couldn't survive this trap...");
            Console.WriteLine("Do you want to play again? yes/no");

            string input = Console.ReadLine();
            switch (input)
            {
                case "yes":
                    Restart();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        static void Restart()
        {
            for (int counterRow = 1; counterRow < 11; counterRow++)
            {
                for (int counterColumn = 1; counterColumn < 11; counterColumn++)
                {
                    display[counterRow, counterColumn] = " ";
                }
            }
            Start();
        }

        static void CheckInput()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    Mover(-1,0);
                    break;
                case ConsoleKey.DownArrow:
                    Mover(1,0);
                    break;
                case ConsoleKey.LeftArrow:
                    Mover(0,-1);
                    break;
                case ConsoleKey.RightArrow:
                    Mover(0,1);
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Press arrow to move!");
                    CheckInput();
                    break;
            }
        }
    }
}
