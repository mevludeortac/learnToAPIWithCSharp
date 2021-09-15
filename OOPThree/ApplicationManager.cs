using System;
using System.Collections.Generic;

namespace OOPThree
{
    public class ApplicationManager
    {
        public void MakeApplication(ICreditManager creditManager)
        {
            creditManager.Calculate();
        }
        public void MakeCreditPreInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
