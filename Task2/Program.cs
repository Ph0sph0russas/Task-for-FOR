namespace Task2
{
    public class Logic
    {
        public static int monthOfIncrease(double a, double b)
        {
            int answerTaskA = 0;

            double sumDeposit = 0;
            for (int i = 0; sumDeposit <= b; a = a * 1.02)
            {
                
                sumDeposit = a * 0.02;
                i = i + 1;
                answerTaskA = i;
            }
            return answerTaskA;
        }
        public static int monthOfDeposit(double a, double c)
        {
            
            int answerTaskB = 0;
            for (int i = 0; a <= c; a = a * 1.02)
            {
                i = i + 1;
                answerTaskB = i;

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
            double c = int.Parse(Console.ReadLine());

            int answerTaskA = Logic.monthOfIncrease(a, b);
            int answerTaskB = Logic.monthOfDeposit(a, c);
            

            Console.WriteLine("Ответ под а)" + answerTaskA);
            Console.WriteLine("Ответ под б)" + answerTaskB);
        }
    }
}