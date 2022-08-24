// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Clear();
// Console.Write($"Введите число М(количество чисел): ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] massiveNumbers = new int[m];

// void InputNumbers(int m)
// {
// for (int i = 0; i < m; i++)
//   {
//     Console.Write($"Введи {i+1} число: ");
//     massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }

// int Comparison(int[] massiveNumbers)
// {
//   int count = 0;
//   for (int i = 0; i < massiveNumbers.Length; i++)
//   {
//     if(massiveNumbers[i] > 0 ) count += 1; 
//   }
//   return count;
// }

// InputNumbers(m);

// Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// Console.Clear();
// double[,] cf = new double[2, 2];
// double[] crossPoint = new double[2];

// void InputCoefficients(){
//   for (int i = 0; i < cf.GetLength(0); i++)
//   {
//     Console.Write($"Введите коэффициенты {i+1}го уравнения (y = k * x + b):\n");
//     for (int j = 0; j < cf.GetLength(1); j++)
//     {
//       if(j==0) Console.Write($"Введите коэффициент k: ");
//       else Console.Write($"Введите коэффициент b: ");
//       cf[i,j] = Convert.ToInt32(Console.ReadLine());
//     }
//   }
// }

// double[] Decision(double[,] cf)
// {
//   crossPoint[0] = (cf[1,1] - cf[0,1]) / (cf[0,0] - cf[1,0]);
//   crossPoint[1] = crossPoint[0] * cf[0,0] + cf[0,1];
//   return crossPoint;
// }

// void OutputResponse(double[,] cf)
// {
//   if (cf[0,0] == cf[1,0] && cf[0,1] == cf[1,1]) 
//   {
//     Console.Write($"\nПрямые совпадают");
//   }
//   else if (cf[0,0] == cf[1,0] && cf[0,1] != cf[1,1]) 
//   {
//     Console.Write($"\nПрямые параллельны");
//   }
//   else 
//   {
//     Decision(cf);
//     Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
//   }
// }

// InputCoefficients();
// OutputResponse(cf);


//  Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// int InputN()
// {
//     int NumberToInput = 0;
//     Console.Write($"Введите число: ");
//     NumberToInput = Convert.ToInt32(Console.ReadLine());
//     return NumberToInput;
// }
// void PrintArray(int[] ArrayToPrint)
// {

//     for (int i = 0; i < ArrayToPrint.Length; i++)
//     {
//         Console.Write($"{ArrayToPrint[i]}");
//         if (i < ArrayToPrint.Length - 1)
//         {
//             Console.Write("");
//         }
//     }
    
// }

// int[] DecToBinConvert(int decNumberToConvert)
// {
//     int temp = decNumberToConvert;
//     int binArraySize = 0;
//     for (binArraySize = 0; temp > 0; binArraySize++)
//         temp = temp / 2;
//     int[] binArray = new int[binArraySize];
//     for (int i = binArraySize - 1; i >= 0; i--)
//     {
//         binArray[i] = decNumberToConvert % 2;
//         decNumberToConvert = decNumberToConvert / 2;
//     }
//     return binArray;
// }

// int decNumber = InputN();
// int[] binNumberArray = DecToBinConvert(decNumber);

// Console.WriteLine("Число {0} в двоичной системе:"+ decNumber);
// PrintArray(binNumberArray);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.

// Console.Clear();
// void FillFibonacciArray(int[] fibonacciArrayToFill)
// {
// fibonacciArrayToFill[0] = 0;
//     fibonacciArrayToFill[1] = 1;
//     for (int i = 2; i < fibonacciArrayToFill.Length; i++)
//     {
//         fibonacciArrayToFill[i]=fibonacciArrayToFill[i-1]+
//                                 fibonacciArrayToFill[i-2];
//     }
// }
// void PrintArray(int[] ArrayToPrint)
// {
//     Console.Write("[");
//     for (int i = 0; i < ArrayToPrint.Length; i++)
//     {
//         Console.Write($"{ArrayToPrint[i]}");
//         if (i < ArrayToPrint.Length - 1)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.WriteLine("]");
// }
// int InputN(int border)
// {
//     int NumberToInput = 0;
//     do
//     {
//         Console.Write($"Введите число больше {border}: ");
//         NumberToInput = Convert.ToInt32(Console.ReadLine());
//         if (NumberToInput <= border)
//         {
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.Write("Ошибка! Нажмите любую клавишу и повторите ввод!");
//             Console.ForegroundColor = ConsoleColor.White;
//             Console.ReadKey();
//             Console.Clear();
//         }

//         else
//         {
//             return NumberToInput;
//         }
//     } while (true);
// }

// Console.Clear();
// Console.WriteLine("Для вывода первых N чисел Фибоначчи");
// int nFibonacci = InputN(2);

// int[] fibonacciArray = new int[nFibonacci];
// FillFibonacciArray(fibonacciArray);

// Console.WriteLine();
// PrintArray(fibonacciArray);

//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// void PrintArray(int[] arrayToPrint)
// {
//     Console.Write("[");
//     for (int i = 0; i < arrayToPrint.Length; i++)
//     {
//         Console.Write("{0}", arrayToPrint[i]);
//         if (i < arrayToPrint.Length - 1)
//         {
//             Console.Write("   ");
//         }
//     }
//     Console.WriteLine("]");
// }

// void FillArray(int[] arrayToFill, int diviation)
// {
//     for (int i = 0; i < arrayToFill.Length; i++)
//         arrayToFill[i] = new Random().Next(-diviation, diviation + 1);
// }

// void CopyArray(int[] arrayToCopy, int[] arrayToFill)
// {
//     for (int i = 0; i < arrayToCopy.Length; i++)
//         arrayToFill[i] = arrayToCopy[i];
// }


// int arraySize = 0;

// arraySize = new Random().Next(5, 20);
// int[] firstArray = new int[arraySize];
// int[] secondArray = new int[arraySize];
// FillArray(firstArray, 20);
// CopyArray(firstArray, secondArray);
// Console.Clear();

// Console.WriteLine("Первый массив:");
// PrintArray(firstArray);
// Console.WriteLine();
// Console.WriteLine("Второй массив - копия первого:");
// PrintArray(secondArray);
// Console.ResetColor();