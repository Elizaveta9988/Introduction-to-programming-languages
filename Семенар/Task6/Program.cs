internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число:");
        int num = int.Parse(Console.ReadLine());
        int remain = num % 2;
        if (remain == 0)
        {
            Console.Write("Число" + num + "четное?");
            Console.WriteLine("ДА");
        }
        else
        {
            Console.WriteLine("Число" + num + "четное?");
            Console.WriteLine("НЕТ");
        }
    }
}