//1. Add meeting - without walidation
//0. Exit calendar
//2. Show all meeting
using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;
using System.IO.Enumeration;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

Typle<string, int ,string, string>[] meetings = new Typle<string, int, string, string>[0];
const string FileName = "meetings.csv";

void ShowAll()
{
    Console.WriteLine($"Start time ", 25);
    Console.WriteLine($"Duration ", 25);
    Console.WriteLine($"Room ", 25);
    Console.WriteLine($"Name ", 25);
    Console.WriteLine();
    var fileContent= File.ReadAllLines(FileName);
    foreach (var line in fileContent)
    {
        var meetingContent = line.Split(',');
        Console.WriteLine($"{meetingContent[0], 20}"//date
            +$"{meetingContent[1], 20}" //duration
            + $"{meetingContent[2], 20}"//room
            + $"{meetingContent[3], 20}");//name
    }
    
    Console.ReadLine();
}
 bool GetRoom (DateTime dateTime, string roomName)
{
    var fileContent = File.ReadAllLines(FileName);
    foreach (var line in fileContent)
    {
        var meetingContent = line.Split(",");
        var date = meetingContent[0];
        var room = meetingContent[2];
        var dateParsingResult = DateTime.TryParse(date, out var meetingDate);
        if (meetingDate == dateTime && room == roomName)
        {
            return true;
        }
    }

    return false;
}

void ShowError (string error) // change to exception
{ 
    Console.ForegroundColor = ConsoleColor.Red;
   
    Console.WriteLine(error);
    
    Console.ReadLine ();
    
    
}
 void AddMeeting () // meeting stsrt time
{
    Console.WriteLine(" Start time : ");
    
    var dateParseResult = DateTime.TryParse(Console.ReadLine(), out var startTime);
    if (!dateParseResult)
    {

        ShowError("Error! Invalid date");
        return;
    }
    Console.WriteLine("Duration in minutes: ");
    var durationParseResult = int.TryParse(Console.ReadLine(), out var duration);
    if (!durationParseResult)
    {
        ShowError("Error invalid value");
        return;
    }


    Console.WriteLine("Room: ");
    var room = Console.ReadLine();
    if (string.IsNullOrEmpty(room))
    {
        ShowError("Error empty room");
        return;
    }
    int roomNumbMax = 3;
    if (room.Length > roomNumbMax)
    {
        ShowError ($"Error!Room number should not be longer than {roomNumbMax}");
        return;
    }
    var isBusy = GetRoom(startTime, room);
    if (isBusy)
    {
        ShowError("Room is busy in this time");
        return;
    }


    Console.WriteLine("Name: ");
    var name = Console.ReadLine ();
    if (string.IsNullOrEmpty(name))
    {
        ShowError("Empty Name");
        return;
    }
    int nameMaxValue = 20;
    if (name.Length > nameMaxValue)
    {
        ShowError("Invalid value of Name");
        return;
    }
    Array.Resize(ref meetings, meetings.Length + 1);
    
    File.AppendAllText(FileName, $"{startTime}, {duration}, {room}, {name}" + Environment.NewLine);
   
}
void Delete () 
{

    string[] readText = File.ReadAllLines(FileName);
    Console.WriteLine(" Wich string delete");
    string delete = Console.ReadLine();
    
    foreach (string str in readText)
    {
        
        if (str.Contains(delete))

        {
            StringBuilder sb = new StringBuilder(str);
            sb.Clear();
            Console.WriteLine("line ", str);
            /* string? newLine = Console.ReadLine();
             StringBuilder deleteLine = new StringBuilder(delete);
             deleteLine.Remove(0, delete.Length);
             Console.WriteLine("Add another");
             string? newLine2 = Console.ReadLine();
             StringBuilder changeLine = new StringBuilder(newLine2);
             changeLine.Clear();
             changeLine.Append(newLine2);
             //var replace = line.Replace(line, newLine);
             // Console.WriteLine(line);*/
            break;
        }
        else
        {
            Console.WriteLine("This date is not listed");
        }
        
    }

    Console.ReadLine();
}

/*void BinarSearch(Array readText , string delete)
{
    Array.Sort(readText);
    int index = Array.BinarySearch(readText, "vvv");
    ShowWhere(readText, index);
    Console.ReadLine() ;
    index = Array.BinarySearch(readText, delete); 
    ShowWhere(readText, index);
}*/

 /* void ShowWhere <Array>(Array[] array, int index)
{
    if (index < 0)
    {
        index = ~index;
        Console.WriteLine("Not found");
        if (index == index)
            Console.WriteLine("Beginning of array");
        else Console.WriteLine("{0} and ", array[index - 1]);

        if (index == array.Length)
            Console.WriteLine("end of array");
        else
            Console.WriteLine("{0}", index);
    }
    else
    {
        Console.WriteLine("Found at index {0} ", index);
    }
}*/

void Exit ()
{
    Environment.Exit(0);
}
void Menu()
{
    Console.Clear ();
    Console.WriteLine("4.Binar searching");
    Console.WriteLine("3. Delete meeting");
    Console.WriteLine("2. Show all meetings");
    Console.WriteLine("1. Add mitting");
    Console.WriteLine("0. Exit calendar");
    
}
while (true)
{
    Menu();
    var keyInfo = Console.ReadKey ();
    switch (keyInfo.Key)
    {
        case ConsoleKey.D0:
            Exit(); 
            break;
            case ConsoleKey.D1:
            AddMeeting ();
            break;
            case ConsoleKey.D2:
            ShowAll ();
            break;
            case ConsoleKey.D3:
            Delete();
            break;
            case ConsoleKey.D4 :
            
        default:
            break;
    }
}



