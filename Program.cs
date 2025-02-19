
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Son topish oʻyiniga xush kelibsiz!");
        
        Random random = new Random();
        int maxAttempts = 10;
        bool playAgain = true;
        
        while (playAgain)
        {
            int targetNumber = random.Next(1, 101);
            int attempts = 0;
            bool hasWon = false;
            
            Console.WriteLine("\nMen 1 dan 100 gacha son oʻyladim.");
            
            while (attempts < maxAttempts && !hasWon)
            {
                Console.Write($"\nTaxminingizni kiriting ({maxAttempts - attempts} urinish qoldi): ");
                string input = Console.ReadLine();
                
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Iltimos, faqat raqam kiriting!");
                    continue;
                }
                
                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Iltimos, 1 dan 100 gacha son kiriting!");
                    continue;
                }
                
                attempts++;
                
                if (guess == targetNumber)
                {
                    hasWon = true;
                    Console.WriteLine($"\nTabriklaymiz! {attempts} ta urinishda topdingiz!");
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Kattaroq son ayting!");
                }
                else
                {
                    Console.WriteLine("Kichikroq son ayting!");
                }
            }
            
            if (!hasWon)
            {
                Console.WriteLine($"\nAfsus! Men oʻylagan son {targetNumber} edi.");
            }
            
            Console.Write("\nYana oʻynaysizmi? (ha/yoʻq): ");
            playAgain = Console.ReadLine().ToLower().StartsWith("h");
        }
        
        Console.WriteLine("\nOʻyin tugadi. Xayr!");
    }
}

