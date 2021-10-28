

namespace NumbersOneToFifteen{
    public class LargestPalindromeProduct: euler_practicing.Problem{
        private readonly int _problemNumber;

        public LargestPalindromeProduct(){
            _problemNumber = 4;
        }

        public override int ProblemNumber{
            get { return _problemNumber; }
        }
        public override string Answer{
            get { return FindThatNumber(); }
        }

        private string FindThatNumber(){
            int firstNumber = 101;
            int goodFirst = 0;
            int goodSecond = 0;
            int oldCombined = 0;
            while(firstNumber < 1000)
            {
                int secondNumber = 101;
                while(secondNumber < 1000){
                    string newNumber = (firstNumber * secondNumber).ToString();
                    int start = 0;
                    int numbLength = newNumber.Length - 1;
                    int newCombined = firstNumber * secondNumber;
                    if(ThatsAPal(newNumber, start, numbLength) && newCombined >= oldCombined){
                        goodFirst = firstNumber;
                        goodSecond = secondNumber;
                        oldCombined = firstNumber * secondNumber;
                    }
                    secondNumber++;
                }
                firstNumber++;
            }
            return oldCombined.ToString();
        }

        private bool ThatsAPal(string newNumber, int start, int numbLength)
        {
            while (start < numbLength)
            {
                if (newNumber[start] != newNumber[numbLength])
                {
                    return false;
                }
                start++;
                numbLength--;
            }
            return true;
        }
    }
}