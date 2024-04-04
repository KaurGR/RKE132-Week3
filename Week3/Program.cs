//Even / odd numbers

Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;

if (result != 0) //!= is not
{
    Console.WriteLine("This number is odd.");
}
else
{
    Console.WriteLine("This number is even.");
}