
void Swap(int a,int b)
{
    int t=a;
    a=b;
    b=t;
}
int a=3,b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap(a,b);
System.Console.WriteLine($"a={a} b={b}");
