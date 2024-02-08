namespace GreeetingApp
{
    internal class GreetingProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the total Number of your courses: ");
            int course = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of your favorite book: ");
            double BookPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Your Name: {name}");
            Console.WriteLine($"Total Enroll Courses: {course}");
            Console.WriteLine($"Price of my fovorite Book: {BookPrice} ");

            Console.Write("Press Any Key to Exit....");
            Console.ReadKey();
        }
    }
}