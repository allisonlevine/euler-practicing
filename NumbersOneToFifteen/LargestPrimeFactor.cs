using UniversalFunctions;
using System;

namespace NumbersOneToFifteen{
    public class LargestPrimeFactor: euler_practicing.Problem{
        private readonly int _problemNumber;

        public LargestPrimeFactor(){
            _problemNumber = 3;
        }

        public override int ProblemNumber{
            get { return _problemNumber; }
        }
        public override string Answer{
            get { return FindThatNumber(); }
        }

        private string FindThatNumber(){
            long thatBigNumber = 600851475143;
            long thatprimenumber = 0;
            long start = 2;
            while(start * start <= thatBigNumber){
                if(thatBigNumber % start == 0){
                    thatBigNumber /= start;
                    if(MathFunctions.NumberIsPrime(thatBigNumber)){
                        thatprimenumber = thatBigNumber;
                    }
                }
                else{
                    start++;
                }
            }
            return thatprimenumber.ToString();
        }
    }
}