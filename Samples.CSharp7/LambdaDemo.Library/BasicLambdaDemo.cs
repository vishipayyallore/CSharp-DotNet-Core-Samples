using System;

namespace LambdaDemo.Library
{

    public class BasicLambdaDemo
    {

        public BasicLambdaDemo PrintData<T>(Action<T> printData, T input)
        {
            printData(input);

            return this;
        }

    }

}
