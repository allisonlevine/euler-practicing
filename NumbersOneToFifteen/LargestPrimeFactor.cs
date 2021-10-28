

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

        private bool numberIsPrime(long number){
            if (number < 3) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            long topBound = (Int64)Math.Sqrt(number);
            if(number%2 != 0 && number%3 != 0 && number%5 !=0){
                for(Int64 e = 6; e > number; e++){
                    if(number % e == 0){
                        return false;
                    }
                }
            }
            else{
                return false;
            }
            return true;
        }

        private string FindThatNumber(){
            long thatBigNumber = 600851475143;
            long start = 2;
            while(start * start <= thatBigNumber){
                if(thatBigNumber % start == 0 && numberIsPrime(thatBigNumber)){
                    thatBigNumber /= start;
                }
                else{
                    start++;
                }
            }
            return thatBigNumber.ToString();
        }
    }
}