Console.Clear();
Console.WriteLine("Enter one numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>99)
{
    int N = (a%100) / 10;
    Console.WriteLine(N);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}