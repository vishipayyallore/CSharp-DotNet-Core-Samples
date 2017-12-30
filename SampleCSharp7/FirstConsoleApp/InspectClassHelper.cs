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

        public InspectClassHelper DisplayPropertiesV1<T>(T acmeObject) where T: AcmeObject
        {
            var inspectClass = new InspectClass<T>(acmeObject);
            WriteLine($"----Propertie V1 {acmeObject.GetType().Name}-----");
            foreach (var property in inspectClass.GetPropertyList())
            {
                WriteLine(property);
            }
            return this;
        }

    }
}
