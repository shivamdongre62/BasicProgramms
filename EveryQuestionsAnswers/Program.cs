using EveryQuestionsAnswers.BasicFunctions;

namespace EveryQuestionsAnswers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Basic obj = new Basic();
            obj.Function();
            /*obj.Sum(17, 45)*/;
            Console.WriteLine(obj.Sum(17, 45));
            Console.WriteLine(obj.Division(17, 45));

        }
    }
}