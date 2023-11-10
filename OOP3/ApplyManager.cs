using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class ApplyManager
    {

        public void Apply(ICreditManager creditManage, List<ILoggerService> loggerServices)
        {

            creditManage.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void CreditPreliminaryInformation(List<ICreditManager> creditManagers)
        {
            foreach (var item in creditManagers)
            {
                item.Calculate();
            }
        }
    }
}
