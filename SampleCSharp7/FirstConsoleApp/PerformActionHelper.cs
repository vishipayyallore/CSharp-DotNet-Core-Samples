using ClassesAndGenerics;

namespace FirstConsoleApp
{
    public class PerformActionHelper
    {
        public PerformActionHelper PerformIntAction(int value)
        {
            var performAction = new PerformAction<int>(value);
            performAction.IdentityDataType();
            return this;
        }

        public PerformActionHelper PerformDecimalAction(decimal value)
        {
            var performAction = new PerformAction<decimal>(value);
            performAction.IdentityDataType();
            return this;
        }

        public PerformActionHelper PerformStringAction(string value)
        {
            var performAction = new PerformAction<string>(value);
            performAction.IdentityDataType();
            return this;
        }

        public PerformActionHelper PerformAction<T>(T value)
        {
            var performAction = new PerformAction<T>(value);
            performAction.IdentityDataType();
            return this;
        }
    }
}
