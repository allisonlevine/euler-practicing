using System;

namespace NumbersOneToFifteen{
    public class SpecialPythagoreanTriplet: euler_practicing.Problem{
        private readonly int _problemNumber;

        public SpecialPythagoreanTriplet(){
            _problemNumber = 9;
        }

        public override int ProblemNumber{
            get { return _problemNumber; }
        }
        public override string Answer{
            get { return FindThoseNumbers(); }
        }


        private string FindThoseNumbers(){
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 1;
            int sum = 1000;

            for(int a= 1; a < sum; a++){
                for(int b = a + 1; b < sum; b++){
                    firstNumber = a*a;
                    secondNumber = b*b;
                    thirdNumber = sum - a - b;
                    if(firstNumber + secondNumber == thirdNumber*thirdNumber){
                        return firstNumber.ToString() + " " + secondNumber.ToString() + " "+ thirdNumber.ToString();
                    }
                }
            }

            return firstNumber.ToString() + " " + secondNumber.ToString() + " "+ thirdNumber.ToString();
        }
    }
}