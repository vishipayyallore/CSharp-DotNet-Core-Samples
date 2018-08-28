using System.Reflection;

namespace GenericsDemo.Library
{

    public class GenericTryParse
    {

        public void TryParse<T>(ref T inputType, string value)
        {
            var dataType = inputType.GetType();
            var tryParseMethod = dataType.GetMember("TryParse");
            object[] parametersArray = new object[] { value, null };
            var output = ((MethodInfo)tryParseMethod[0]).Invoke(dataType, parametersArray);
            inputType = ((bool)output) ? (T)parametersArray[1] : inputType;
        }

    }

}
