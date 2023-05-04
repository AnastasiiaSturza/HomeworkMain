//x = 10, y = 12 , sum = 10 + 11 + 12
/*using System.ComponentModel;

int sum = 0;
for (int i = 10; i <= 12; i++)

{
    Console.WriteLine(i);
    sum += i;
}
Console.WriteLine("sum: " + sum);


int j = 10;
int sum2 = 0;
while (j <= 12)
{
    sum2 += j;
    j++;
    Console.WriteLine(j);
}
Console.WriteLine("sum2: " + sum2);

int k = 10;
int sum3 = 0;
do
{
    sum3 += k;
    k++;
    Console.WriteLine(k);
}
while (k <= 12);
Console.WriteLine("sum3: " + sum3);

//x = 5 , y = 2 , sum = 2 + 3 + 4 + 5

int sum4 = 0;
for (int i1 = 5; i1 >= 2; i1--)
{
    Console.WriteLine("i1 " + i1);
    sum4 += i1;
}

Console.WriteLine("sum4: " + sum4);

int sum5 = 0;
int j1 = 5;
while (j1 >= 2)
{
    sum5 += j1;
    Console.WriteLine("j1 " + j1);
    j1--;
}
Console.WriteLine("sum5: " + sum5);

int k1 = 5;
int sum6 = 0;
do
{
    sum6 += k1;
    Console.WriteLine("k1 " + k1);
    k1--;
}
while (k1 >= 2);
Console.WriteLine("sum6: " + sum6);

//x=10 , y = 10 , sum = 10
int sum7 = 0;
for (int i2 = 10; i2 <= 10; i2++)
{

    Console.WriteLine($"i2  {i2} ");
    sum7 += i2;

}
Console.WriteLine("sum7: " + sum7);

int sum8 = 0;
int j2 = 10;
while (j2 <= 10)
{
    sum8 += j2;
    Console.WriteLine("j2 " + j2);
    j2++;
}
Console.WriteLine("sum8: " + sum8);

int sum9 = 0;
int k2 = 10;
do
{
    sum9 += k2;
    Console.WriteLine("k2 " + k2);
    k2++;
}
while (k2 <= 10);
Console.WriteLine("sum8: " + sum8);*/

// readLine
int x, y;
Console.Write("Add value x: ");
bool isResultX = int.TryParse(Console.ReadLine(), out x);

Console.Write("Add value y: ");
bool isResultY = int.TryParse(Console.ReadLine(), out y);
int sumXY = 0;

for (int z = x; z <= y; z++)
{
    if (!(isResultX && isResultY))
    {
        Console.WriteLine(" Value is incorrect");
        break;
    }
    else
    {
        Console.WriteLine("z = " + z);
        sumXY += z;
        {
            Console.WriteLine("sumXY : " + sumXY);
        }
    }
 }
 


    

   

 
    