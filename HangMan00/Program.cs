namespace HangMan00
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to Hangman");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Mission: Guess the word correctly to save your friend!");

            string[] words = new string[] { "Dog", "Fun", "Gaming", "Coding" };

            var randomWordsSelector = new Random();
            string currentWord = words[randomWordsSelector.Next(3)];
            int livesLeft = 7;
            Console.WriteLine("You have " + livesLeft + " lives");

            for (int a = 0; a < 6; a++)
            {

            

                Console.WriteLine("");
                 for (int i = 0; i < currentWord.Length; i++)
                 {
                    Console.Write("-");
                 }
            
            

                Console.WriteLine("\n");
                string userGuess = Console.ReadLine();

                if (currentWord == userGuess)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else if (currentWord != userGuess)
                {
                    livesLeft--;
                    Console.WriteLine("You have " +livesLeft + " lives left \n");               
                }
               


               




            }

            Console.ReadLine();

        }      
            
    }
    
}