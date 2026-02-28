namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Theme A: Student Score Analyzer
             * 
             */

            List<int> studentScores = new List<int> { 99, 85, 59, 93, 87 };

            bool running = true;

            // Keeps loop showing
            while (running)         
            {
                Console.WriteLine("\nStudent Score ");
                Console.WriteLine("1. Display Score ");
                Console.WriteLine("2. Show Total ");
                Console.WriteLine("3. Show Average ");
                Console.WriteLine("4. Exit ");
                Console.Write("Enter Choice: ");

                string input = Console.ReadLine();

                int choice = 0;

                // try catch stops it from crashing
                try
                {
                    choice = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Invalid. Please enter a number between 1 and 4.");
                }

                // makes sure number is valid
                if (choice >= 1 && choice <= 4)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("\nScores: ");
                        foreach (int score in studentScores)
                        {
                            Console.WriteLine(score);
                        }
                    }
                    else if (choice == 2)
                    {
                        int total = 0;

                        for (int i = 0; i < studentScores.Count; i++)
                        {
                            total += studentScores[i];
                        }

                        Console.WriteLine("\nTotal: " + total);
                    }
                    else if (choice == 3)
                    {
                        int total = 0;

                        for (int i = 0; i < studentScores.Count; i++)
                        {
                            total += studentScores[i];
                        }

                        double average = (double)total / studentScores.Count;

                        Console.WriteLine("\nAverage: " + average);

                    }
                    else if (choice == 4)
                    {
                        running = false;
                        Console.WriteLine("\nProgram ended.");
                    }

                }
                else
                {
                    if (choice != 0)
                    {
                        Console.WriteLine("Please choose a number from 1 to 4.");
                    }
                }
            }
        }

    }
}
