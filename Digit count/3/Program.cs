Console.WriteLine("Input your number here");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number>0)
{
    number=number/10;
    sum++;
}
Console.WriteLine(sum);