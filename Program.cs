// ++++++++++++++++++++ Задача 1 ++++++++++++++++++++++++++++++++++++
// Console.WriteLine("Введите числа через пробел:");
// string input = Console.ReadLine();

// string[] inputStrings = input.Split(' ');
// int[] numbers = new int[inputStrings.Length];
// int positiveNumbersCount = 0;
//     for (int i = 0; i < inputStrings.Length; i++) {
//       numbers[i] = int.Parse(inputStrings[i]);
//       if (numbers[i] > 0) {
//         positiveNumbersCount++;
//       }
//     }

// Console.WriteLine("Количество чисел больше нуля: " + positiveNumbersCount);

// ++++++++++++++++++++ Задача 2 ++++++++++++++++++++++++++++++++++++
Console.WriteLine("Введите значение k1:");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b1:");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение k2:");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b2:");
double b2 = double.Parse(Console.ReadLine());

    if (k1 == k2) {
      if (b1 == b2) {
        Console.WriteLine("Прямые совпадают");
      } else {
        Console.WriteLine("Прямые параллельны и не имеют точек пересечения");
      }
    } 
    else {
      double x = (b2 - b1) / (k1 - k2);
      double y = k1 * x + b1;

      Console.WriteLine("Точка пересечения прямых: (" + x + ", " + y + ")");
    }