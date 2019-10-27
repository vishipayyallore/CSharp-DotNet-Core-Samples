using System.Numerics;
using LogicPrograms.Interfaces;

namespace LogicPrograms.Logics
{

    public class Math : IMath
    {

        public BigInteger GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * GetFactorial(number - 1);
        }

    }

}
