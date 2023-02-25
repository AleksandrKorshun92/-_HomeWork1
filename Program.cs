// Task 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// В условиях задачи нет указания на какие должны быть числа, поэтому сделал их целыми.

Console.WriteLine("Hello, write the first integer number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the second integer number ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(number2 > max)
{
    Console.WriteLine("The largest number " + number2);
}
else
{
    Console.WriteLine("The largest number " + number1);
}
Console.WriteLine("Thank you");