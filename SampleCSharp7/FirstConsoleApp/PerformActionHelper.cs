using System;
using System.Collections.Generic;
using System.Text;
using ClassesAndGenerics;

namespace FirstConsoleApp
{
    public class PerformActionHelper
    {
        public void PerformIntAction(int value)
        {
            var performAction = new PerformAction<int>(value);
            performAction.IdentityDataType();
        }

    }
}
