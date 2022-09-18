using System.Drawing;
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int CatchNums(string[] nums)
{
    int sum = 0;
    foreach (var a in nums)
    {
        if (int.Parse(a) >= 0)
        {
            sum++;
        }
    }

    return sum;
}

string[] SplitString()
{
    Console.Write("Введите числа через пробел, запятую или / : ");

    string numbs = Console.ReadLine()!;
    string[] numSt = numbs.Split(' ', ',', '/');
    return numSt;
}


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Point FindCrossPoint(string[] nums)

// {
//     Point cross = new Point();

//     if (nums.Length != 4)
//     {
//         Console.WriteLine("Вы ввели не 4 значения.");
//         return cross;
//     }
//     else
//     {
//         int k1 = int.Parse(nums[0]);
//         int b1 = int.Parse(nums[1]);
//         int k2 = int.Parse(nums[2]);
//         int b2 = int.Parse(nums[3]);

//         cross.X = (b2 - b1) / (k1 - k2);

//         cross.Y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
//         Console.WriteLine("Наши прямы заданы уравнениями: ");
//         Console.WriteLine($"y = {k1} * x + {b1}");
//         Console.WriteLine($"y = {k2} * x + {b2}");
//         return cross;
//     }

// }

// не понял, как через Point сделать, не получилось создать Point(double x, double y)
string FindCross(string[] nums)

{
    if (nums.Length != 4)
    {
        return "Вы ввели не 4 значения.";
    }
    else
    {
        double k1 = double.Parse(nums[0]);
        double b1 = double.Parse(nums[1]);
        double k2 = double.Parse(nums[2]);
        double b2 = double.Parse(nums[3]);

        double x = (b2 - b1) / (k1 - k2);

        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.WriteLine("Ваши прямы заданы уравнениями: ");
        Console.WriteLine($"y = {k1} * x + {b1}");
        Console.WriteLine($"y = {k2} * x + {b2}");
       return $"Точка пересечения ({x};{y}) ";
    }

}

while (true)
{
    try
    {
        Console.WriteLine("Какую задачу посмотрим? ");
        Console.WriteLine("1.Подсчет положительных | 2.Поиск точки пересечения");
        ConsoleKeyInfo chouse = Console.ReadKey();
        Console.Clear();
        if (chouse.KeyChar == '1') Console.WriteLine($"Из вашего набора чисел всего {CatchNums(SplitString())} положительных.");
        else if (chouse.KeyChar == '2') Console.WriteLine($"Точка их пересечения {FindCross(SplitString())}");
        else Console.WriteLine($"У меня тут всего две задачи.");


    }
    catch (Exception)
    {
        Console.WriteLine("Упс! Что-то пошло не так, попробуйте ввести корректные данные.");
    }

    //Зацикливание программы
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.Clear();
    if (quite.KeyChar == 'q' || quite.KeyChar == 'й') break;
}
