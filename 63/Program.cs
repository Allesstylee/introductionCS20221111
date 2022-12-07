﻿// Создать подпрограмму Create2DArray(m,n), которая возвращает двумерный массив следующим правилом: Aij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива
int[,] Random2DArray(int n,int m,int min=0,int max=10)
{

    int[,] a=new int[n.m];
     Random random=new Random();
for(int i=0;i<n;j++)
    for(int j=0;j<m;j++)
        a[i,j]=random.Next(min.max+1);
        return a;
}
void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLenght(1);j++)
        System.Console.Write($"{a[i,j],4}");
            System.Console.WriteLine();
    }
}
int[,] a=Create2DArray(4,5);
Print2DArray(a);