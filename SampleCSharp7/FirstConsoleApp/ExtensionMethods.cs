namespace FirstConsoleApp
{
    public static class ExtensionMethods
    {
        public static bool CheckIfBelowAverage(this int classAverage, int threshold)
        {
            return (classAverage < threshold);
        }

    }
}
