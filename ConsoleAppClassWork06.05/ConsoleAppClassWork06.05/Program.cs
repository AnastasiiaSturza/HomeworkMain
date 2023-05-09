
int SumOfnumbersRec(int a, int b )
{
    int result = 0; 
    if( a <= b )
    {
        result += a + SumOfnumbersRec(a + 1, b);
    }
    /*else
    {
        result += b + SumOfnumbersRec(a, b + 1);
    }*/
    return result;
}