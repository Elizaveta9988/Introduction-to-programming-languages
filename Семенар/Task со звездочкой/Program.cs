//Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
using static System.Console;
class ChristmasTree {
    static void Main() {
        int size;
        Write("Enter size: ");
        while (!int.TryParse(ReadLine(), out size) || size <= 0)
            Write("Enter size, damn it: ");
        for (int i = 1; i <= size; i++)
            for (int j = 1; j <= i; j++)
                WriteLine(new string(' ', size - j) + new string('*', j * 2 - 1));
    }
}