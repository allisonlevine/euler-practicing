using System;

namespace NumbersOneToFifteen{
    public class That10001stPrime: euler_practicing.Problem{
        private readonly int _problemNumber;

        public That10001stPrime(){
            _problemNumber = 7;
        }

        public override int ProblemNumber{
            get { return _problemNumber; }
        }
        public override string Answer{
            get { return FindThoseNumbers(); }
        }


        private string FindThoseNumbers(){
            bool numberNotFound = true;
            int counter = 0;
            int primeCounter = 0;

            while(numberNotFound){
                counter++;
                if(UniversalFunctions.MathFunctions.NumberIsPrime(counter)){
                    primeCounter++;
                }
                if(primeCounter == 10001){
                    numberNotFound = false;
                }
            }

            return counter.ToString();
        }
    }
}