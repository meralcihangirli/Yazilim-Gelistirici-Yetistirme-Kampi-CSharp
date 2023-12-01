using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {//public oldugu için ProductAdded büyük harfle başladı,private olsaydı küçük harfle başlardı
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductAlert = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string UnitPriceInvalid = "hatalı urun fiyati";
        public static string ProductCountOfCategory = "bir kategoride en fazla 10 adet ürün olabilir";
        public static string ProductNameAlreadyExist = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "kategori limiti asıldıgı için yeni ürüün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
