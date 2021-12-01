using Core.Entities.Concrete;
using Entities.Concrete;
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
        public static string MaintenanceTime = " Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi ";
        public static string ProductCountOfCategoryError = "Kategorideki olması gereken ürün sayısını aştınız";
        public static string ProductNameAlreadyExists = "Bu isimde ürün var";
        public static string CategoryLimitExceeded = "Kategori limiti aşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıtlı";
        public static string UserNotFound = "Kullanıc bulunamadı";
        public static string PasswordError = "Şifre yanlış";
        public static string UserAlreadyExists = "Böyle bir kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string SuccessfulLogin = "Giriş başarılı";
    }
}
