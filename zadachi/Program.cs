Console.Clear();
Console.WriteLine ("Введите номер задачи от 1 до 3");
int number = int.Parse(Console.ReadLine() ?? "0"); 
switch (number)  
{
    case 1: 
       Console.Clear ();
       Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
       int Input()
        {
        Console.Write("Введите число: ");
        return Convert.ToInt32(Console.ReadLine());
        }
        int numb1 = Input();
        if(numb1 < 0)
        {
            numb1 = -numb1;
        }
        if(numb1 < 100 || numb1 > 999)
        {
            Console.WriteLine("Введите ТРЁХзначное число");
        }
        else 
        {
        numb1 = numb1 / 10 % 10;
        Console.WriteLine($"второй цифрой в введенном числе является {numb1}");
        }
        break;
    case 2:
        Console.Clear ();
        Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        int numb = Input();
        if(numb < 0)
        {
            numb = -numb;
        }
        if(numb < 100)
        {
            Console.WriteLine("Число не является трёхзначным. Третьей цифры в данном числе нет");
        }
        else
        {
        while(numb > 1000)
        {
            numb = numb / 10;
        }
        numb = numb % 10;
        Console.WriteLine($"Третья цифра в введенном числе: {numb}");
        }
        break;

    case 3:
        Console.Clear ();
        Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        Console.Write("Введите число, обозначающее день недели: ");
        int numbday = Convert.ToInt32(Console.ReadLine());        
        string[] weekday = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
        if(numbday < 1 || numbday > 7)
        {
            Console.WriteLine("данное число не является числом, обозначающим день недели. Введите число от 1 до 7");
            Console.Write("Введите число, обозначающее день недели: ");
        }
        else if (numbday < 6)
        {
            Console.WriteLine($"{weekday[numbday-1]} не является выходным днем");
        }
        else
        {
            Console.WriteLine($"{weekday[numbday-1]} выходной день");
        }
        break;
}



      

