using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryQuestionsAnswers.BasicFunctions
{
    public class Basic
    {
        //Write a C# Sharp program to print Hello and your name in a separate line.
        public void  Function()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Shivam");

        }
        public int Sum(int x,int y)
        {
            int sum = 0;
            sum = x + y;
            return sum;
        }

        public int Division(int x,int y)
        {
            int sum = 0;
            sum = x / y;
            return sum ;
        }
        public void Swap(int x,int y)
        {
            Console.WriteLine("Before Swapping "+x + "and" + y);
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.Write("After Swaping "+ x + "and " + y);
        }
    }
}
