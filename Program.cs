// 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

/*
Console.Write("Введите числа (через пробел): ");
 int CountNums(int m)
{
int number;
int count = 0;
    
for (int i = 0; i < m; i++)
{
        
    number = int.Parse(Console.ReadLine());
        
    if (number > 0)
      count++;
}

return count;
Console.WriteLine($"Введите числа  > 0 : {count}" );
}


*/


// 43: Напишите программу, которая найдёт точку
//  пересечения двух прямых, заданных уравнениями 
//  y = k1 * x + b1, y = k2 * x + b2;
//   значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


/*
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());


var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Пересечение в точке: ({x};{y})");
*/




//42(необязательно): Напишите программу, которая будет преобразовывать
//  десятичное число в двоичное.
//  45 -> 101101
//3  -> 11
//2  -> 10


// System.Console.Clear();
// Console.Write("Введите десятичное число для преобразования: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = 0; // a - остаток после % деления из которого формируется число в 
// //    двоичной системе исчисления
// int i = 0;
 
// int[] b = new int[10]; // массив с помощью которого двоичное число позже 
//                                  //будет выведено с конца для правильного отображения 
 
// while (number >= 1)
// {
//   a = number % 2;
//   b[i] = a;
//   i++;
 
//   number = number / 2;
 
// // Console.Write(a);
// };
 
// // Console.WriteLine();
 
// for (i = (b.Length - 1); i >= 0; i--)
// {
// // if (b[i] == 0)
// // {

//  // }
//  Console.Write(b[i]);
// }
// Console.WriteLine();

