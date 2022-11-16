Console.WriteLine("введите трехзначное число");
int A = Convert.ToInt32(Console.ReadLine());

if (A > 100 && A < 1000)
    {
        int B = A % 10;
        Console.WriteLine(B);
    }
else
Console.WriteLine("число не трехзначное");
