bool IsCompareResult (string str , string str1 )
{

    
    if (str == str1)
    {
        return true;
    }
    
    return false;
    
}
Console.WriteLine(IsCompareResult("second", "one")); // false

int Return (string str)
{
    return str.Length;
}
Console.WriteLine($"Length of string: {Return("   first")}"); //8

string SortMethod (string str)
{
    string litters = str;

    char[] littersToChar = litters.ToCharArray();
    
    
    
    for (int i = 0; i < littersToChar.Length; i++)
    {
        for (int j = 0; j < littersToChar.Length-1-i; j++)
        {
            if (littersToChar[j] > littersToChar[j+1])
            {
                var sort = littersToChar[j];
                littersToChar[j] = littersToChar[j+1];
                littersToChar[j + 1] = sort;
            }
            
        }
    }
    var stringFromChar = new string (littersToChar);
    return stringFromChar;
        
}
string newString = "giugiugliuipplkbbfvcxee";
Console.WriteLine( $" Sort by alphabit : {SortMethod(newString)}");