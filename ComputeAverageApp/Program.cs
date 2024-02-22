namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static double studentAve, totalgrades, roundGrades;
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 5 grades separated by new line");
            for(int i = 0; i < 5;  i++) 
            {
                
                double grades = Convert.ToDouble(Console.ReadLine());

                totalgrades += grades;

            }

            studentAve = totalgrades / 5;
            roundGrades = Math.Round(studentAve);

            Console.WriteLine("The Averages is " +  studentAve + " and the round of is " + roundGrades);

            Console.WriteLine("Enter any key to exit...");
            Console.ReadKey(); 
        }
    }
}