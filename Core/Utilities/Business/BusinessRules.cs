using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
  public  class BusinessRules
    {
        //params birden fazla parametreleri almayı sağlıyor ve IResult içinde dizi haline getiriyor
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                //iş kurallarından başarısız olanı business a gönderiyoruz
                if (!logic.Success)
                {
                    return logic;
                }

            }
            return null;

        }
    }
}
