using Tyuiu.StoyakinNM.Sprint1.Task5.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Стоякин Н.М. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Class Math                                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Стоякин Никита Михайлович | ПКТб 24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
        Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение      *");
        Console.WriteLine("* 1,2,...,7 в зависимости от того, на какой день недели (понедельник,     *");
        Console.WriteLine("* вторник,..., воскресенье) приходится k-й день невисокосного года,       *");
        Console.WriteLine("* в котором 1 января – понедельник.                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите K:");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ;                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = Convert.ToInt32(ds.Calculate(k));
        Console.WriteLine(res);

        Console.ReadKey();

    }
}