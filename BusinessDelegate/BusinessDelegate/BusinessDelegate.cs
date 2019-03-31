using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessDelegate
{
    public class BusinessDelegate
    {
        private BusinessLookUp lookup = new BusinessLookUp();
        private IBusinessService service;
        private string serviceType;

        public void SetService(string serviceType)
        {
            this.serviceType = serviceType;
        }

        public void DoTask()
        {
            lookup.getBusinessService(this.serviceType).doProcessing();
        }


    }
}
