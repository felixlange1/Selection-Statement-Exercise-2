namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is awesome!");
                    break;
                case "science":
                    Console.WriteLine("Science is cool because it's all about the real world.");
                    break;
                case "history":
                    Console.WriteLine("A lot of people underestimate the value of history.");
                    break;
                case "English":
                    Console.WriteLine("English is a great choice.");
                    break;
                default:
                    Console.WriteLine("That's a cool subject.");
                    break;
            }
        }
    }
}