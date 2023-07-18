//https://www.hackertouch.com/get-all-dates-between-two-dates-in-c-sharp.html
//https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0
//https://code-maze.com/csharp-write-json-into-a-file/

namespace HelloWorld

{ 
    class Program
    {
        static void Main(string[] args)
        {
        generacalendario g = new generacalendario();
        g.create();
           mayanewyear y = new mayanewyear();
           y.create();
        }
    }
}