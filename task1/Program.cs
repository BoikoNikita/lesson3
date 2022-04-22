Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());

if (N/10000 == N%10 && (N/1000)%10==(N%100)/10)
{
   Console.WriteLine("Это число палиндром!");
}
else
{
    Console.WriteLine("Это число не палиндром!");
}