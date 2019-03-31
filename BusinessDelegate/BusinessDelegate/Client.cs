using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessDelegate
{
    public class Client
    {
        private BusinessDelegate businessDeletate;

        public Client(BusinessDelegate businessDeletate)
        {
            this.businessDeletate = businessDeletate;
        }

        public void DoTask()
        {
            this.businessDeletate.DoTask();
        }

    }
}
