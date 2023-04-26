using Globomantics.Math;
namespace ConsoleCalculator;

internal class Program
{
    static void Main(string[] args)
    {
        //Assembly .dll or .exe files default to project name
        //Microsoft suggests to consider the fomat of the assembly name as <company>.<product>.<module (dll or exe)>
        //Namespace Globomantics.Data.DTO
        //Assembly Globomantics.Data.Entity
        //Assembly Globomantics.Data.Validation
        //Class library Project: Globomantics.Data > Globomantics.Data.dll

        Arithmatic.Add(1, 2);
        Arithmatic.Subtract(1, 2);
        Arithmatic.Multiply(1, 2);
        Arithmatic.Divide(1, 2);        
        
    }
}