using ClassesAndGenerics;

namespace FirstConsoleApp
{
    public class ClassesAndGenericsHelper
    {

        public Cat CreateCat(CatType catType)
        {
            switch (catType)
            {
                case CatType.Lion:
                    return new Lion(LionColorSpectrum.White);
                case CatType.Tiger:
                    return new Tiger(TigerColorSpectrum.Blue);
                default:
                    return new NullCat();
            }
        }

        public void PerformCatLife(Cat cat)
        {
            cat.Hunt()
                .Eat()
                .Sleep();
        }

    }
}
