using Tyuiu.AntonovNS.Sprint2.Task4.V26.Lib;
namespace Tyuiu.AntonovNS.Sprint2.Task4.V26
{
    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Антонов Н.С. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("#* Спринт #2                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Антонов Никита Сергеевич |  ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Исходные данные:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x,y;
        Console.WriteLine("Введите значние X: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значние Y: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x, y));
    }
}
}