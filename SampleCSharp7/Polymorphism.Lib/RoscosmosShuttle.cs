using static System.Console;

namespace Polymorphism.Lib
{
    public class RoscosmosShuttle : Shuttle
    {
        public override double Twr()
        {
            WriteLine($"-----{GetType().Name}::{System.Reflection.MethodBase.GetCurrentMethod().Name}()-----");
            return 0.0;
        }
    }
}