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
    return Console.ReadLine()!.Split(' ', ',', '/');
}


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = double.Parse(nums[0]) * x + double.Parse(nums[1]), y = double.Parse(nums[2]) * x + double.Parse(nums[3]); значения double.Parse(nums[1]), double.Parse(nums[0]), double.Parse(nums[3]) и double.Parse(nums[2]) задаются пользователем.

PointF FindCrossPoint(string[] nums)
{
    PointF cross = new PointF();

    if (nums.Length != 4)
    {
        Console.WriteLine("Вы ввели не 4 значения.");
        return cross;
    }
    else
    {
        cross.X = (float.Parse(nums[3]) - float.Parse(nums[1])) / (float.Parse(nums[0]) - float.Parse(nums[2]));

        cross.Y = (float.Parse(nums[0]) * (float.Parse(nums[3]) - float.Parse(nums[1]))) / (float.Parse(nums[0]) - float.Parse(nums[2])) + float.Parse(nums[1]);

        Console.WriteLine("Наши прямы заданы уравнениями: ");
        Console.WriteLine($"y = {float.Parse(nums[0])} * x + {float.Parse(nums[1])}");
        Console.WriteLine($"y = {float.Parse(nums[2])} * x + {float.Parse(nums[3])}");

        return cross;
    }
}

// не понял, как через Point сделать, не получилось создать Point(double x, double y)
// Получилось, правда нигде не мог найти ничего, пока писал Point увидел в подсказках какой-то PointF подумал, что это подойдет, оказалось что да)

// string FindCross(string[] nums)

// {
//     if (nums.Length != 4)
//     {
//         return "Вы ввели не 4 значения.";
//     }
//     else
//     {
//         double x = (double.Parse(nums[3]) - double.Parse(nums[1])) / (double.Parse(nums[0]) - double.Parse(nums[2]));

//         double y = (double.Parse(nums[0]) * (double.Parse(nums[3]) - double.Parse(nums[1]))) / (double.Parse(nums[0]) - double.Parse(nums[2])) + double.Parse(nums[1]);

//         Console.WriteLine("Ваши прямы заданы уравнениями: ");
//         Console.WriteLine($"y = {double.Parse(nums[0])} * x + {double.Parse(nums[1])}");
//         Console.WriteLine($"y = {double.Parse(nums[2])} * x + {double.Parse(nums[3])}");
//         return $"Точка пересечения ({x};{y}) ";
//     }

//}

while (true)
{
    try
    {
        Console.WriteLine("Какую задачу посмотрим? ");
        Console.WriteLine("1.Подсчет положительных | 2.Поиск точки пересечения");
        ConsoleKeyInfo chouse = Console.ReadKey();
        Console.Clear();

        if (chouse.KeyChar == '1')
        { Console.WriteLine($"Из вашего набора чисел всего {CatchNums(SplitString())} положительных."); }
        else if (chouse.KeyChar == '2')
        { Console.WriteLine($"Точка их пересечения {FindCrossPoint(SplitString())}"); }
        else
        { Console.WriteLine($"У меня тут всего две задачи."); }

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
