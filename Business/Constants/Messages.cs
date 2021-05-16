using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda.";
        public static string ProductsListed="Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Kategoride 10'dan fazla ürün olamaz. ";

        public static string ProductNameAlreadyExist = "Böyle bir ürün zaten var. ";

        public static string CategoryLimitExceeded = "Category ekleme limiti aşıldı. ";
    }
}
