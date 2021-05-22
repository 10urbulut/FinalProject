using Core.Entities.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Kategoride 10'dan fazla ürün olamaz. ";

        public static string ProductNameAlreadyExist = "Böyle bir ürün zaten var. ";

        public static string CategoryLimitExceeded = "Category ekleme limiti aşıldı. ";

        public static string AuthorizationDenied = "Yetkiniz yok .";

        public static string UserRegistered = "Kayıt oldu ";
        public static string UserNotFound = "Kullanıcı bulunamadı ";
        public static string PasswordError = "Parola hatası ";
        public static string SuccessfulLogin = "Giriş başarılı ";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
       
}

