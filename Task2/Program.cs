namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int answerTaskA = 0;
            double aForTaskA = a;
            double sumDeposit = 0;
            for (int i = 2; sumDeposit < b; sumDeposit = aForTaskA * 0.02)
            {
                answerTaskA = i;
                i = i + 1;
                aForTaskA = aForTaskA * 1.02;
            }
            Console.WriteLine(sumDeposit);
            Console.WriteLine("Ответ под а)" + answerTaskA);

            double aForTaskB = a;
            int answerTaskB = 0;
            for (int i = 1; aForTaskB < c; aForTaskB = aForTaskB * 1.02)
            {
                answerTaskB = i;
                i = i + 1;

            }
            Console.WriteLine("Ответ под б)" + answerTaskB);
        }
    }
}