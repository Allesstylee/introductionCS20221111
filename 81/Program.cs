// 81. Вывести на экран символы от A до Z как показано ниже: 
//A 
//BB 
//CCC 
//...
for(Char c='A';c<='Z';c++)
{
    for(int i=1;i<=c-'A'+1;i++)
    System.Console.WriteLine(c);
    System.Console.WriteLine();
}
