namespace FirstConsoleApp
{
    public static class ExtensionMethods
    {
        public static bool CheckIfBelowAverage(this double classAverage, int threshold)
        {
            return (classAverage < threshold);
        }

        public static (string originalValue, int number, bool isInteger) ToInt(this string value)
        {
            var result = (originalValue: value, number: 0, isInteger: false);
            if (!int.TryParse(value, out var number)) return result;
            result.number = number;
            result.isInteger = true;
            return result;
        }

    }
}
