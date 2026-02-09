
//1

/*
int EvenCount(int n)
{
    int count = 0;

    for (int i = n; i>=1; i/=10)
    {
        if ((i%10) % 2 == 0)
        {
            count++;
        }
    }

    return count;
}


int OddCount(int n)
{
    int count = 0;

    for (int i = n; i>=1; i/=10)
    {
        if ((i%10) % 2 != 0)
        {
            count++;
        }
    }

    return count;
}


int DigitCount(int n)
{
    int count = 0, dig;

    for (int i = n; i>=1; i/=10)
    {
        dig = i%10;
            count++;
    }

    return count;
}
int SumDigit(int n)
{
    int sum = 0;

    for (int i = n; i>=1; i/=10)
    {
        sum +=i%10;
    }

    return sum;
}

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Even:" + EvenCount(n));
Console.WriteLine("Odd:" + OddCount(n));
Console.WriteLine("Digit:" + DigitCount(n));
Console.WriteLine("Sum:" + SumDigit(n));
*/






//2
/*
int Add(int a, int b)
{
    return a+b;
}
int Subtract(int a, int b)
{
    return a-b;
}
int Multiply(int a, int b)
{
    return a*b;
}
int Division(int a, int b)
{
    return a/b;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Add:" + Add(a, b ));
System.Console.WriteLine("Subtract:" + Subtract(a, b ));
System.Console.WriteLine("Multiply:" + Multiply(a, b ));
System.Console.WriteLine("Division:" + Division(a, b ));
*/



//3

/*
using System;

int MaxDigit(int n)
{
    int n1 = n / 1000;
    int n2 = n / 100 % 10;
    int n3 = n / 10 % 10;
    int n4 = n % 10;

    int maxVal = Math.Max(
                    Math.Max(n1, n2),
                    Math.Max(n3, n4)
                 );
    return maxVal;
}

int MinDigit(int n)
{
    int n1 = n / 1000;
    int n2 = (n / 100) % 10;
    int n3 = (n / 10) % 10;
    int n4 = n % 10;

    int minVal = Math.Min(
                     Math.Min(n1, n2),
                     Math.Min(n3, n4)
                  );
    return minVal;
}

int n = Convert.ToInt32(Console.ReadLine());

int minVal = MinDigit(n);
int maxVal = MaxDigit(n);

Console.WriteLine(minVal + " + " + maxVal + " = " + (minVal + maxVal));

*/






//6
/*
int Divisors(int x)
{ int cnt=0;
    for(int i = 1; i <=x; i++)
    {
        if(x%i==0)
        Console.Write(i+ " ");
        cnt++;
    }
    return cnt;
}
int x = Convert.ToInt32(Console.ReadLine());
Divisors(x);
*/

//7















//8
/*
int MinNumber(int a, int b, int c, int d)
{
    int minVal = Math.Min(
                     Math.Min(a, b),
                     Math.Min(c, d)
                  );
    return minVal;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int minVal = MinNumber(a,b,c,d);
Console.WriteLine(minVal);

*/



//9


/*
int Min(int val1, int val2)
{
    int minVal = Math.Min(val1, val2);
    return minVal;
}
int val1 = Convert.ToInt32(Console.ReadLine());
int val2 = Convert.ToInt32(Console.ReadLine());
int minVal = Min(val1, val2);
Console.WriteLine(minVal);
*/


//10


/*
int Max(int val1, int val2)
{
    int maxVal = Math.Max(val1, val2);
    return maxVal;
}
int val1 = Convert.ToInt32(Console.ReadLine());
int val2 = Convert.ToInt32(Console.ReadLine());
int maxVal = Max(val1, val2);
Console.WriteLine(maxVal);

*/
