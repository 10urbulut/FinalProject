using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        

        public SuccessDataResult(T data, string message) : base(data, true, message)
        /*data ver mesaj ver*/
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        /*data ver*/
        {

        }
        public SuccessDataResult(string message) : base(default, true, message)
        /*çalıştırılan değişkenin default hali,
         * sadece mesaj gidecek,
         * çok fazla kullanılmaz*/
        {

        }

        public SuccessDataResult() : base(default, true)
            /*hiç bir şey verme, çok fazla kullanılmaz*/
        {

        }

    }
}
