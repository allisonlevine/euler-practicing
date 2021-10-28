using System;
namespace NumbersOneToFifteen{
    public class SumSquareDifferences: euler_practicing.Problem{
        private readonly int _problemNumber;

        public SumSquareDifferences(){
            _problemNumber = 6;
        }

        public override int ProblemNumber{
            get { return _problemNumber; }
        }
        public override string Answer{
            get { return FindThatNumber(); }
        }

        private string FindThatNumber(){
            double squaredNaturals = 0;
            double naturalsSquared =0;
            for(int i =0; i < 101; i++){
                squaredNaturals += Math.Pow(i,2);
                naturalsSquared += i;
            }
            naturalsSquared = Math.Pow(naturalsSquared,2);
            return (naturalsSquared - squaredNaturals).ToString();
        }
    }
}