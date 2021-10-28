using NumbersOneToFifteen;
using System.Collections.Generic;

namespace euler_practicing
{
    //aka my life
    public class ProblemFactory
    {
        private List<Problem> themProblems { get; set; } = new List<Problem>();
        // Constructor
        public ProblemFactory()
        {
            themProblems.Insert(0, new Columbo());
            themProblems.Insert(1, new MultipleOfThreeOrFive());
            themProblems.Insert(2, new EvenFibonacciSum());
            themProblems.Insert(3, new LargestPrimeFactor());
            themProblems.Insert(4, new LargestPalindromeProduct());
            themProblems.Insert(5, new SmallestMultiple());
        }
        public Problem GetProblem(int key)
        {
            if(key >= themProblems.Count){
                return new Columbo();
            }
            return themProblems[key];
        }
    }
}
