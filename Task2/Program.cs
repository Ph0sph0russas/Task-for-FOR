namespace Task2
{
    public class Logic
    {
        public static int monthOfIncrease(double a, double b)
        {
            int answerTaskA = 0;
            
            double sumDeposit = 0;
            for (int i = 2; sumDeposit < b; sumDeposit = a * 0.02)
            {
                answerTaskA = i;
                i = i + 1;
                a = a * 1.02;
            }
            return answerTaskA;
        }
        public static int monthOfDeposit(double a, int c)
        {
            
            int answerTaskB = 0;
            for (int i = 1; a < c; a = a * 1.02)
            {
                answerTaskB = i;
                i = i + 1;

            }
            return answerTaskB;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int answerTaskA = Logic.monthOfIncrease(a, b);
            int answerTaskB = Logic.monthOfDeposit(a, c);
            

            Console.WriteLine("Ответ под а)" + answerTaskA);
            Console.WriteLine("Ответ под б)" + answerTaskB);
        }
    }
}