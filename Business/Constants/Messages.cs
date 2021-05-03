using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameİnvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakım zamanı";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string GetProduct = "Ürün getirildi";

        public static string ProductCountOfCategoryError = "Bu kategorideki ürünlerin sayısı 10dan fazla olamaz";
        public static string ProductNameAlreadyExist = "Bu isim daha önce kullanıldığı için kullanamazsın";
        public static string CategorLimitedExceed = "Kategori sayısı 15den fazla olduğu için ürün ekleyemezsin";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserRegistered = "Kullanıcı gerekli";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Password Hatalı";
        public static string UserAlreadyExists = "Kullanıcı Zaten var";
        public static string AccessTokenCreated = "Bağlantı sağlandı";

    }
}
