Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
int checker = 1;
for (int division = 2; division < number; division++)
{
    if ((number % division) == 0)
    {
        checker = 0;
    }
}

if (checker == 1)
    Console.WriteLine("Number is prime number.", number);
else
    Console.WriteLine("Number is not a prime number.", number);
