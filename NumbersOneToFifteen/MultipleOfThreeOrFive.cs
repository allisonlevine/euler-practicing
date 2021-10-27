

namespace NumbersOneToFifteen{
    public class MultipleOfThreeOrFive: euler_practicing.Problem{
        private readonly int _problemNumber;
        private string _answer;

        public MultipleOfThreeOrFive(){
            _problemNumber = 1;
        }

        public override int ProblemNumber{
            get { return _problemNumber; }
        }
        public override string Answer{
            get { return findThoseNumbers(); }
        }

        private string findThoseNumbers(){
            int total = 0;
            for(var i = 0; i < 1000; i++){
                if(i%3 == 0 || i%5 == 0){
                    total += i;
                }
            }
            return total.ToString();
        }
    }
}