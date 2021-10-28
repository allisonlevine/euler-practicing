

namespace NumbersOneToFifteen{
    public class EvenFibonacciSum: euler_practicing.Problem{
        private readonly int _problemNumber;

        public EvenFibonacciSum(){
            _problemNumber = 2;
        }

        public override int ProblemNumber{
            get { return _problemNumber; }
        }
        public override string Answer{
            get { return FindThoseNumbers(); }
        }

        private string FindThoseNumbers(){
            int total = 0;
            int a = 0;
            int b = 1;
            int c = 0;
            while(total < 4000000){
                c = a + b;
                a = b;
                b = c;
                if(c % 2 == 0){
                    total +=c;
                }
            }
            return total.ToString();
        }
    }
}