namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your favorite subject?");
            var userInput = Console.ReadLine();


            switch (userInput.ToLower())
            {
                case "math" :
                    Console.WriteLine("Math? Nice! I was told thats how you get all the numbers...");
                    break;
                case "chemistry":
                    Console.WriteLine("Chemistry? Thats out of my element...");
                    break;
                case "history":
                    Console.WriteLine("History? That seems a little dated...");
                    break;
                case "biology":
                    Console.WriteLine("Biology? How do you study? Must be osmosis...");
                    break;
                case "gym":
                    Console.WriteLine("Gym? I tried running a gym class but it was tiring... ");
                    break;
                default:
                    Console.WriteLine("What school did you go to? I didn't have that class!");
                    break;
            }
        }
    }
}