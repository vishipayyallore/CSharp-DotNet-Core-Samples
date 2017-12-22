namespace FirstConsoleApp
{
    public static class ExtensionMethods
    {
        public static bool CheckIfBelowAverage(this double classAverage, int threshold)
        {
            return (classAverage < threshold);
        }

        public static (string originalValue, int number, bool isInteger)
            ToInt(this string value)
        {
            return null;
        }

    }
}
