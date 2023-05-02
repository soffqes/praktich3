/******************************************************************************
26.04.2023
Старовойтова 23ИС-21
Вариант 22

Не использовала шаг, код не работает
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("a:");
    int a = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("b:");
    int b = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("x:");
    int x = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Первое число:");
    int n0 = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Второе число:");
    int nk = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Шаг:");
    int deltan = Convert.ToInt32 (Console.ReadLine());
    double c = 0;
    while (n0<=nk) {
        double k1 = Math.Cos(a)+2*b;
        double k2 = Math.Pow(Math.Tan(Math.Sqrt(Math.Pow (a, 2) + b - n0)), 2);
        double k3 = Math.Pow (2.7, x);
        c = k1/k2 + k3;
    }
    Console.WriteLine("Результат для " + n0 + "=" + Math.Round(c, 2));
  }
}
