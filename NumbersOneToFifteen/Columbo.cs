
namespace NumbersOneToFifteen{
    public class Columbo: euler_practicing.Problem
    {
        private readonly int _problemNumber;
        private string _answer;

        public Columbo(){
            _problemNumber = 0;
        }

        public override int ProblemNumber{
            get { return _problemNumber; }
        }
        public override string Answer{
            get { return "just one more thing..."; }
        }
    }
}