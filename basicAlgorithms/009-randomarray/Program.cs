int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min,max);
    return a;
}
void Print(int[] a)
{
    for(int i=0;i<a;.length;i++)
    System.Console.Write($"{a[i],5}");
}
int[] m-RandomIntArray(max:50,size:5);
Print(m);