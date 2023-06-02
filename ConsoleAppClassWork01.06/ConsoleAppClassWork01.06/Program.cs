
//var list  = new List<string>();
//for (int i = 0; i < 10; i++)
//{
//    list.Add(i.ToString());

//    //list.Capacity;
//    //list.Clear();
//    //list.Contains - true or false
//    //list.AddRange(list)

//}

//list.Remove("2");  // remove this from list
//list.RemoveAt(0); // remove by index
//list.Sort();

//foreach (var item in list)
//{

//    Console.WriteLine(item);
//}
//Console.WriteLine();

//list.AddRange(new string[] { "10" , "12"});


//foreach (var item in list)
//{  
//    Console.WriteLine(item);

//}

//Console.WriteLine($"list count {list.Count}");
////list.Insert (0, item) - add item by index
//Console.ReadLine();


//using System.Xml;

//Dictionary<int,string> dictionary = new Dictionary<int, string>();
//for (int i = 0; i < 10; i++)
//{
   
//    dictionary.Add(i, i.ToString());
//}

//dictionary[1] = "100"; // add value to index 1

//foreach (var item  in dictionary)
//{
//    Console.WriteLine($"item Key: {item.Key} , and item value: {item.Value}");
//    Console.WriteLine();
//}

////dictionary.ContainsKey(0);
//dictionary.TryGetValue(1, out string value);  // show value by index
//Console.WriteLine(value);

//var set = new HashSet<string>();
//var set2 = new HashSet<string>();  
//for  (int i = 0; i < 10; i++)
//{
//    set.Add(i.ToString());
//    set2.Add((i+4).ToString());
//}

//Console.WriteLine(set.Contains("2")); // true

//set.IntersectWith(set2);//only eiement wich have another set
//foreach (var item in set)
//Console.WriteLine(item);
//Console.WriteLine();
//Console.WriteLine($"count = {set.Count}");
//Console.WriteLine();

//var result = set.Intersect(set2); 
//Console.WriteLine(result);
//Console.WriteLine($" is set equal set2 : {set.Equals(set2)}");
//set.Add("a");
//set2.Add("a");// doesn`t add to set because it also has "a"

Queue <string> queue = new Queue<string>(); 
queue.Enqueue("a");
queue.Enqueue("b");
queue.Enqueue("c");
queue.Enqueue("20"); // add  elements to end of queque

while (queue.TryDequeue(out var item))
{
    
    Console.WriteLine(item);
}
Console.WriteLine();

Stack<string> stack = new Stack<string>();
stack.Push("a");  // method for adding elements
stack.Push("b");
stack.Push("c");
//stack.Pop(); // for delete element

while (stack.TryPop(out var item))
    Console.WriteLine($"stack item {item}");

