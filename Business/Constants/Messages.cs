using Entities.Concerete;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages 
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime= "sistem bakımda";
        public static string ProductListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists=" bu isimde zaten başka bir ürün var var";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz Yok!";
        internal static string CategoryListed="category lsitelendi";
    }
}