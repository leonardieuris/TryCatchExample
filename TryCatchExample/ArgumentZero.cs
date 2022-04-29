namespace TryCatchExample
{
    public class ArgumentZero : Exception
    {
        public ArgumentZero(string message) : base(message)
        { 
        
        }

        public ArgumentZero() : base("Entrambi gli input hanno come valore ZERO")
        {

        }
    }
}
