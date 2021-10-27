using System;

namespace euler_practicing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heeeey, which problem you want?");
            var problemNumber = Console.ReadLine();
            int problemPicked;
            if(int.TryParse(problemNumber, out problemPicked)){
                ProblemFactory lifeInGeneral = new ProblemFactory();
                Console.WriteLine(lifeInGeneral.GetProblem(problemPicked).Answer);
            }
            else{
                Console.WriteLine("oh no thank you");
            }
        }
    }
}
