Console.WriteLine("Введите номер интересующей вас задачи: 10, 13 или 15 ");
while(true)
{
    int task = int.Parse(Console.ReadLine());
    if(task == 10)
    {
        Task10();
        break;
    }
     else if(task == 15)
     {
        Task15();
        break;
     }
     else if (task == 13)
     {
        Task13();
        break;
     }
}

// Задача №10
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


void Task10 () 

{
Console.WriteLine("Введите любое трехзначное число, в ответ программа покажет 2-ю цифру этого числа");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("2-я цифра введенного числа: " + ((number/ 10) % 10));   
}

// Задача №13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


void Task13()
{
  Console.WriteLine("Введите число, а программа вам покажет 3-ю цифру этого числа: ");
  int input = int.Parse(Console.ReadLine());
  if (input < 99)
    {
        Console.WriteLine("3-я цифра отсутствует");
    }
  else
    {
        Console.WriteLine("3-я цифра введенного числа: " + input.ToString()[2]);
    }
}


//Задача №15: 
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Task15()
{
Console.WriteLine("Введите цифру, обозначающую день недели (от 1 до 7): ");
int dayNumber = int.Parse(Console.ReadLine());
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Это выходной день");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Вы ввели неверное значение");
    }
    else Console.WriteLine("Это будний день");
}

//Task10();
//Task13();
//Task15();