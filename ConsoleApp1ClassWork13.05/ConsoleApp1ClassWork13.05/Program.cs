﻿//1. Add meeting - without walidation
//0. Exit calendar
//2. Show all meeting
using System;
using System.IO.Enumeration;
using static System.Net.Mime.MediaTypeNames;

Typle<string, int ,string, string>[] meetings = new Typle<string, int, string, string>[0];
const string FileName = "meetings.csv";

void SaveToFile()
{

}
void ShowAll()
{
    Console.WriteLine($"Duration ", 25);
    Console.WriteLine($"Room ", 25);
    Console.WriteLine($"Name ", 25);
    Console.WriteLine();
    var fileContent= File.ReadAllLines(FileName);
    foreach (var line in fileContent)
    {
        var meetingContent = line.Split(',');
        Console.WriteLine($"{meetingContent[0], 20}"
            +$"{meetingContent [1], 20}"
            + $"{meetingContent[2], 20}");
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

void ShowError (string error)
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
    

    
    File.AppendAllText(FileName, $"{startTime}, {duration}, {room}, {name}" + Environment.NewLine);
}
void Exit ()
{
    Environment.Exit(0);
}
void Menu()
{
    Console.Clear ();
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
        default:
            break;
    }
}


