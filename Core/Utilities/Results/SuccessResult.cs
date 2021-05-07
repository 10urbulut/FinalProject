using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuccessResult:Result
    {
        //base inherit edilen sınıfa veri göndermemiz için
        public SuccessResult(string message) : base(true,message)
        {

        }
        public SuccessResult():base(true)//success result olduğu için true yu default vermiş olduk
        {

        }
    }
}
