

namespace NumbersOneToFifteen{
    public class SmallestMultiple: euler_practicing.Problem{
        private readonly int _problemNumber;

        public SmallestMultiple(){
            _problemNumber = 5;
        }

        public override int ProblemNumber{
            get { return _problemNumber; }
        }
        public override string Answer{
            get { return FindThoseNumbers(); }
        }

        private bool IsThatDivisible(int whatItDo){
            for(int i = 1; i <21; i++){
                if(whatItDo%i != 0){
                    return false;
                }
            }
            return true;
        }

        private string FindThoseNumbers(){
            int smallest = 1;
            bool smallestNotFound = true;
            while(smallestNotFound){
                if(IsThatDivisible(smallest)){
                    smallestNotFound = false;
                    break;
                }
                smallest++;
            }
            return smallest.ToString();
        }
    }
}