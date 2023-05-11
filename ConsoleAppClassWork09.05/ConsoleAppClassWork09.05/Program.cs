using System.Linq.Expressions;

int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Console.WriteLine("array" + array.ToString()); - vyvodit prosto typ

void PrintAll (int[] array)

{ 
    if (array.Length == 100)
    {
        Console.WriteLine(" Array is too big");
        return;
    }
    
    foreach (int element in array)
    {
        Console.WriteLine("i= " + element);
    }
    /*for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }*/
}
PrintAll(array);

void MultBy2(int[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        array[i] *= 2;
    }
    PrintAll (array);
}
MultBy2(array);

int[] Copy(int[] array)
{
    int[] newCopy = new int[array.Length];
    int i = 0;
    foreach (int element in array)
    {
        newCopy[i++] = element;
        
    }
    return newCopy;
}
int[] copiedArray = array;//Copy(array);
//MultBy2(copiedArray);

//PrintAll(array);
//Copy(copiedArray);

/*int InitArray ( int[] array , int[] start, int[] end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = start++;
        if (start > end)
        {
            start[i] = -1;
        }
    }
}*/

int Summ ( int[] array)
{
    int summ = 0;
    foreach(int element in array)
    {
        summ += element;
    }
    
    return summ;
}
Console.WriteLine(Summ(array));

int[,] table = new int[10,10];
void InitTwoDemArray (int[,] array )
{
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = random.Next(100);
        }
    }
}
InitTwoDemArray(table);
int SummTab(int[,] array)
{
    int summ = 0;
    foreach (int element in array)
    {
        summ += element;
    }

    return summ;
}
Console.WriteLine("SumTable : " + SummTab(table));
void PrintArray (int[,] array)
{
    for (int i = 0;i < array.GetLength(0); i++)
    {
        for (int j = 0;j < array.GetLength(1)-1; j++)
        {
            Console.WriteLine(array[i,j] + "i and j");
        }
        Console.WriteLine();
    }
}


void SortArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        //var NotLast = i + 1 < array.Length;
        if (array[i] > array[i +1]) // 10 and5 // 5,10
        {
            var temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
        }
    }
}
SortArray(array);

var str = "Hello, World";

Console.WriteLine(str.IndexOf("hello"));
