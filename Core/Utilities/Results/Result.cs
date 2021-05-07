using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        //this bulunan class demek
        public Result(bool success, string message):this(success)
        /*tek olan constructer da çalışsın diye bu şekilde yazdık
        yani iki değerin dönmesi zorunlu olmasın istedik */
        {
            Message = message;
        }
        public Result(bool success)//overloading
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }//get sadece constructer ile set edilir
    }
}
