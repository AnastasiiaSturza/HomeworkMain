using System.Reflection;
//bubble :

    Console.WriteLine(" Add whole numbers for bubble sort separated by a comma like : 1,2,3 ");
    string[] numbsConsol = Console.ReadLine().Trim().Split(new char[] { ',' });
    int[] Numbs = new int[numbsConsol.Length];
    int bubble;
for (int i = 0; i < Numbs.Length; i++)
{
    Numbs[i] = int.Parse(numbsConsol[i]);
}
for (int i = 0; i < numbsConsol.Length; i++)
{
    for (int j = 0; j < Numbs.Length - 1 - i; j++)
    {
        if (Numbs[j] > Numbs[j + 1]) // "<" - from max to less
        {
                bubble = Numbs[j];
                Numbs[j] = Numbs[j + 1];
                Numbs[j + 1] = bubble;
        }
    }

}
for (int i = 0; i < Numbs.Length; i++)
{
    Console.WriteLine($"Element from bubble {i + 1} : {Numbs[i]}");
}
    
    
    





// selection
Console.WriteLine(" Add whole numbers separated by a comma like : 1,2,3 ");
string[] numbsConsolSort = Console.ReadLine().Trim().Split(new char[] { ',' });
int[] NumbsSort = new int[numbsConsolSort.Length];
int sort;

    for (int i = 0; i < NumbsSort.Length; i++)
    {
        NumbsSort[i] = int.Parse(numbsConsolSort[i]);
    }

    for (int i = 0; i < NumbsSort.Length-1; i++)
    {
        sort = i;
        for (int j = i + 1; j < NumbsSort.Length; j++)
        {
            if (NumbsSort[j] < NumbsSort[sort]) // ">" from max to less
           
                sort = j;
            
        }
       
        int temp = NumbsSort[i];
        NumbsSort[i] = NumbsSort[sort];
        NumbsSort[sort] = temp;
    }

for (int i = 0; i< NumbsSort.Length ; i++)
{
    Console.WriteLine($"Element from selection {i+1} :{NumbsSort[i]}");
}

//Insertion

Console.WriteLine(" Add whole numbers separated by a comma like : 1,2,3 ");
string[] numbsConsolInsert = Console.ReadLine().Trim().Split(new char[] { ',' });
int[] NumbsInsert = new int[numbsConsolInsert.Length];
int insert; ;

for (int i = 0; i < NumbsInsert.Length; i++)
{
    NumbsInsert[i] = int.Parse(numbsConsolInsert[i]);
}

for (int i = 0; i < NumbsInsert.Length; i++)
{
    insert =NumbsInsert[i];
    int j = i -1;

    while (j >= 0 && NumbsInsert[j]> insert)
    {
        NumbsInsert[j+1] = NumbsInsert[j];
        NumbsInsert[j] = insert;
        j--;
    }

}
for (int i = 0; NumbsInsert.Length > 0; i++)
{
    Console.WriteLine($"Elements from insertion {i+1} {NumbsInsert[i]}");
}

