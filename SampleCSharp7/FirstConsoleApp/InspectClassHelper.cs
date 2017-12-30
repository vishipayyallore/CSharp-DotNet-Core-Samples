using ClassesAndGenerics;
using static System.Console;

namespace FirstConsoleApp
{
    public class InspectClassHelper
    {
        public void DisplayProperties()
        {
            var invoice1 = new Invoice();
            var inspectClass = new InspectClass<Invoice>(invoice1);
            WriteLine("----Properties-----");
            foreach (var property in inspectClass.GetPropertyList())
            {
                WriteLine(property);
            }
        }

    }
}
