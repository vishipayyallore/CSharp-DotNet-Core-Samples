using System;
using AbstractDemo.Lib;
using Common.Enums;

namespace FirstConsoleApp
{
    public class ClassesAndGenericsHelper
    {

        public Cat CreateCat(CatType catType, Enum catColor)
        {
            switch (catType)
            {
                case CatType.Lion:
                    return new Lion((LionColorSpectrum)catColor);
                case CatType.Tiger:
                    return new Tiger((TigerColorSpectrum)catColor);
                default:
                    return new NullCat();
            }
        }

        public void PerformCatLife(Cat cat) => cat.Hunt()
            .Eat()
            .Sleep();
    }
}
