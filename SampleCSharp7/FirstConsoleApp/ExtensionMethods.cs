namespace FirstConsoleApp
{
    public static class ExtensionMethods
    {
        public static bool CheckIfBelowAverage(this double classAverage, int threshold)
        {
            return (classAverage < threshold);
        }

    }
}
