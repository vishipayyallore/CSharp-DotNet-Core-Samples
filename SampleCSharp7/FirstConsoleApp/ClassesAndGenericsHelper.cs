using ClassesAndGenerics;

namespace FirstConsoleApp
{
    public class ClassesAndGenericsHelper
    {
        public void CreateLion(LionColorSpectrum lionColor)
        {
            var lion = new Lion(lionColor);
            lion.Hunt()
                .Eat()
                .Sleep();
        }

        public void CreateTiger(TigerColorSpectrum tigerColor)
        {
            var tiger = new Tiger(tigerColor);
            tiger.Hunt()
                .Eat()
                .Sleep();
        }
    }
}
