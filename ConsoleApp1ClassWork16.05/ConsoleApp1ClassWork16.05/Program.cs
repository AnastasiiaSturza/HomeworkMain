using System.Data;
using System.Linq.Expressions;
/*try
{
    var zero = 0;
    //var i = 10 / zero;
    var thouthands = 100000000000;
    //throw new Exception("Some error happend");
    throw new NotFiniteNumberException("");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"Divede by zero found at : {e.StackTrace}");
}

catch (Exception e)
{
    Console.WriteLine($"Error {e.Message} and {e.StackTrace}");
    // add messsege log
    throw;
}
finally
{
    Console.WriteLine("Block finaly");
}*/

void ShowError (string error) // homework for  showerror method
{
    throw new Exception (error);
}
Guid guid = Guid.NewGuid();
Console.WriteLine(guid);