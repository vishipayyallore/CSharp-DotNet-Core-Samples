using ClassesAndGenerics;
using static System.Console;

namespace FirstConsoleApp
{
    public class InspectClassHelper
    {
        public InspectClassHelper DisplayProperties(AcmeObject acmeObject)
        {
            var inspectClass = new InspectClass<AcmeObject>(acmeObject);
            WriteLine($"----Propertie {acmeObject.GetType().Name}-----");
            foreach (var property in inspectClass.GetPropertyList())
            {
                WriteLine(property);
            }
            return this;
        }

    }
}
