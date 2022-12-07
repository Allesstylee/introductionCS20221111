// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
int n=10;
int[] a=new int[n];
a[0]=0;
a[1]=1;
for(int i=2;i<n;i++)
    a[i]=a[i-1]+a[i-2];
for(int i=0;i<n;i++);
    System.Console.Write($"{a[i]} ");

    //error CS0103: Имя "i" не существует в текущем контексте. [C:\Users\aalle\OneDrive\Desktop\разрабо\RAO\introductionCS20221111\54\54.cspro j]