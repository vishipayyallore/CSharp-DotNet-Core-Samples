namespace FirstConsoleApp
{
    public static class MathHelper
    {
        public static int GetLargest(int number1, int number2)
        {
            return (number1 > number2) ? number1 : number2;
        }

        public static ref int GetLargest(ref int number1, ref int number2)
        {
            if (number1 > number2)
            {
                return ref number1;
            }
            return ref number2;
        }
    }
}
