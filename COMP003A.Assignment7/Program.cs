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

                try
                {
                    choice = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Invalid. Please enter a number between 1 and 4.");
                }


        }
    }
}
