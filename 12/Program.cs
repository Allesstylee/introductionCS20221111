int n;
do
{
    System.Console.WriteLine("Введите число от 10 до 99");
     n=Convert.ToInt32(Console.ReadLine());
}
while(n<10 || n>99);