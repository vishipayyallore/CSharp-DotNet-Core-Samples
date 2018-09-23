using LambdaDemo.Library;
using System;
using static System.Console;

namespace CSharp7.DemoApp.ExecuteMethods
{

    public class ShowLambdaDemos
    {
        private readonly ExecuteMethodsHelper _executeMethodsHelper;

        public ShowLambdaDemos()
        {
            _executeMethodsHelper = new ExecuteMethodsHelper();
        }

        public ShowLambdaDemos ShowSimpleLambdaDemo()
        {
            var basicLambdaDemo = new BasicLambdaDemo();

            _executeMethodsHelper.ShowHeader("ShowLambdaDemos::Show Simple Lambda Demo");

            basicLambdaDemo.PrintData(data =>
            {
                WriteLine("Adding Data to Data!!!");
                data += data;
                WriteLine(data);
            }, 123.56f);

            basicLambdaDemo.PrintData(data =>
            {
                WriteLine(data);
            }, true);

            basicLambdaDemo.PrintData(data =>
            {
                WriteLine(data);
            }, 'A');

            basicLambdaDemo.PrintData(data =>
            {
                WriteLine(data);
            }, DateTime.Now);

            basicLambdaDemo.PrintData(data =>
            {
                WriteLine("Adding Data to Data!!!");
                data += data;
                WriteLine(data);
            }, 123.56f);

            return this;
        }

        //public ShowLambdaDemos ShowLambdaDemoWithGenericMethod<T>(Action<T> printData)
        //{
        //    // (Action<T> printData, T input)
        //    var basicLambdaDemo = new BasicLambdaDemo();

        //    basicLambdaDemo.PrintData(printData, "Shiva Sai");
        //    basicLambdaDemo.PrintData(PrintActionGeneric, 125);
        //    basicLambdaDemo.PrintData(PrintActionGeneric, 123.45f);
        //    basicLambdaDemo.PrintData(PrintActionGeneric, 123.45M);
        //    basicLambdaDemo.PrintData(PrintActionGeneric, 'A');
        //    basicLambdaDemo.PrintData(PrintActionGeneric, DateTime.Now);

        //    return this;
        //}

    }

}
