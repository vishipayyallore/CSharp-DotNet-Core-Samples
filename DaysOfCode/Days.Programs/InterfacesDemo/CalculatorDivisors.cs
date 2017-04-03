namespace Days.Programs.InterfacesDemo
{
    public class CalculatorDivisors : IAdvancedArithmetic
    {
        public int DivisorSum(int number)
        {
            var sum = 0;
            for (var iCtr = 1; iCtr <= number; iCtr++)
            {
                if (number % iCtr != 0)
                {
                    continue;
                }
                sum += iCtr;
            }
            return sum;
        }
    }
}
