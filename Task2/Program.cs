namespace Task2
{
    public class Logic
    {
        public static int getMonthOfExceededIncrease(double initialSum, double maxIncrease)
        {
            int answerTaskA = 0;

            double sumDeposit = 0;
            for (int i = 0; sumDeposit <= maxIncrease; initialSum = initialSum * 1.02)
            {
                
                sumDeposit = initialSum * 0.02;
                i = i + 1;
                answerTaskA = i;
            }
            return answerTaskA;
        }
        public static int getMonthOfExceededDeposit(double initialSum, double maxDeposit)
        {
            
            int answerTaskB = 0;
            for (int i = 0; initialSum <= maxDeposit; initialSum = initialSum * 1.02)
            {
                i = i + 1;
                answerTaskB = i;

            }
            return answerTaskB;
        }
        public static string calculateDepositInfo(double initialSum, double maxIncrease, double maxDeposit)
        {
            int answerTaskA=Logic.getMonthOfExceededIncrease(initialSum, maxIncrease);
            int answerTaskB=Logic.getMonthOfExceededDeposit(initialSum, maxDeposit);
            string messageAnswers = "Ответ под а)" + answerTaskA + "\n" + "Ответ под б)" + answerTaskB; 
            return messageAnswers;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());

            string messageAnswers=Logic.calculateDepositInfo(a, b, c);

            Console.WriteLine(messageAnswers);
        }
    }
}