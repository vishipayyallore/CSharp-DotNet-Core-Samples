using System;

namespace LambdaDemo.Library
{

    public class BasicLambdaDemo
    {
        public void PrintData<T>(Action<T> printData, T input)
        {
            printData(input);
        }

    }

}
