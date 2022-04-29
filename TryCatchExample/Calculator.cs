namespace TryCatchExample
{
    public class Calculator
    {
        public double Division(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0 && firstNumber != 0)
                throw new DivideByZeroException($"Attenzione: Impossibile dividere {firstNumber} per Zero!");
            if (secondNumber == 0 && firstNumber == 0)
                throw new ArgumentZero();
            return firstNumber / secondNumber;
        }
    }
}
