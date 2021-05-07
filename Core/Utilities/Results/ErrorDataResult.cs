using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        /*data ver,
         * mesaj ver*/
        {

        }

        public ErrorDataResult(T data) : base(data, false)
        /*data ver*/
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)
        /*çalıştırılan değişkenin default hali,
         * sadece mesaj gidecek,
         * çok fazla kullanılmaz*/
        {

        }

        public ErrorDataResult() : base(default, false)
        /*hiç bir şey verme, çok fazla kullanılmaz*/
        {

        }
    }
}
