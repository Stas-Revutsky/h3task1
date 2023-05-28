namespace h3task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine().ToLower();
            int aoieCount = 0;

            foreach (char letter in str)
            {
                if (letter.Equals('a') || letter.Equals('o') ||
                    letter.Equals('i') || letter.Equals('e')) { aoieCount++; };
            }
            
            Console.WriteLine($"There are {aoieCount} a o i or e letters in the text");
        }
    }
}