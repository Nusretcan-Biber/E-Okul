using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ExeptionControl
{
    public class Exeptions
    {
        string exeptionText;
        public string NullExeption()
        {
            exeptionText = "Boş değer girilemez";
            return exeptionText;
        }
        public string NegativeExeption()
        {
            exeptionText = "Negatif değer girlemez";
            return exeptionText;
        }


        public string NumberExeption()
        {
            exeptionText = "Rakam girilemez";
            return exeptionText;

        }
        public string SizeExepption(string whitchMethod)
        {
            switch (whitchMethod)
            {
                case "MinimumOne":
                    MinimumOne();
                    break;

                case "MinimumTwo":
                    MinimmumTwo();
                    break;
                case "MaximumFifty":
                    MaximumFifty();
                    break;
            }
            string MinimumOne()
            {
                exeptionText = "Bir harften kısa değer grilemez";
                return exeptionText;

            }
            string MinimmumTwo()
            {
                exeptionText = "İki harften kısa değer grlemez";
                return exeptionText;
            }
            string MaximumFifty()
            {
                exeptionText = "Elli harften uzun değer girilemez";
                return exeptionText;
            }
            return exeptionText;
        }
        public string IsExistIdExeption()
        {
            exeptionText = "Bu Id daha önce kullanılmış lütfen benzersiz bir Id kullanın";
            return exeptionText;

        }
        public string IsNotExistIdExeption()
        {
            exeptionText = "Veritabanında böyle bir ID yok";
            return exeptionText;
        }
        public string IsExistNumberExeption()
        {
            exeptionText = "Girmiş olduğunuz Id dolu";
            return exeptionText;
        }

        public string SuccessExeption()
        {
            exeptionText = "İşleminiz başarı ile gerçekleşti. :)";
            return exeptionText;
        }
        public string FailtureExeption()
        {
            exeptionText = "İşleminiz başarısız olmuştur. :(";
            return exeptionText;
        }

        public string LenghtExeption()
        {
            exeptionText = "Girilen değerin bir hücreden büyük, elli hücreden küçük olmasına dikkat edin";
            return exeptionText;
        }

        public string EmptyTable()
        {
            exeptionText = "Tablo henüz boş. Tabloya veri eklemeyi veya farklı bir işlem yapmayı deneyebilirsiniz";
            return exeptionText;
        }

        public string WrongRangeExeption()
        {
            exeptionText = "Lütfen 0'dan büyük, 100'den küçük sayı giriniz.";
            return exeptionText;
        }
    }
}
