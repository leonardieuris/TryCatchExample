
// See https://aka.ms/new-console-template for more information
using TryCatchExample;


Console.WriteLine("Inizio Esecuzione");
try
{
    var firstNumber = 0;
    var secondNumber = 0;
    var calculator = new Calculator();
    var result = calculator.Division(firstNumber, secondNumber);
    Console.WriteLine($"Il risultato di {firstNumber} diviso {secondNumber} è {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Attenzione è avvenuta un'eccezione:{ex.Message}");
}
catch (ArgumentZero ex)
{
    Console.WriteLine($"Attenzione è avvenuta un'eccezione: {ex.Message}");
}
catch (Exception ext)
{
    Console.WriteLine($"Attenzione, Eccezione non prevista: {ext.Message}");
}
finally
{
    Console.WriteLine("Fine Esecuzione");
}
Console.ReadLine();
