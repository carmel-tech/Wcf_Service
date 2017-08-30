using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Service
{
   
    [ServiceContract]
    public interface IWCF_Service
    {
        [OperationContract]
        Int32 Add(Int32 num1,Int32 num2);

        [OperationContract]
        Int32 Subtract(Int32 num1, Int32 num2);

        [OperationContract]
        Int32 Multiply(Int32 num1, Int32 num2);

        [OperationContract]
        Int32 Divide(Int32 num1, Int32 num2);
    }
}
