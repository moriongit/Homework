Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= number)
{
    if (i != number)
        i = i * 2;
    if (i == number)
    {
        Console.WriteLine("The number is power of 2");
            break;
    };
}
if (i > number)
    Console.Write("no");