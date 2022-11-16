Console.WriteLine("Input number1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2");
int number2 = Convert.ToInt32(Console.ReadLine());
int kvadrat = number2 * number2;

if (kvadrat == number1)
   {
        Console.WriteLine("второе число является корнем первого");
   }
else
    {
        Console.WriteLine("второе число не является корнем первого");
    }
