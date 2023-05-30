using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TryCatch_Yapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try catch
            //programda oluşan hataları son kullanıcıya mesaj olarak göstermek için kullanılar yapıdır.

            //int sayi;
            //Console.Write("Sayı Girin : ");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //Console.Write(sayi * 2);

            //try
            //{
            //    Console.Write("Sayı Girin : ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    int sonuc = sayi * sayi;
            //    Console.Write("Kare : " + sonuc);
            //}
            //catch
            //{
            //    Console.WriteLine("bir hata oluştu");
            //}

            try
            {
                int sayi;
                Console.Write("Sayı Girin : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayının 3. Kuvveti : " + (sayi * sayi * sayi));
            }
            catch (ArgumentNullException error1) // genellikle sqldewn dönene null sonuçları yakalar
            {
                Console.WriteLine("Değer Girilmedi");
            }
            catch (FormatException eror2)
            {
                Console.WriteLine("Hatalı veri formatı girildi");
                Console.Write(eror2.ToString());
            }
            catch (OverflowException eror3)
            {
                Console.WriteLine("Girdiğiniz değer çok büyük veya çok küçük");
                Console.Write(eror3.ToString()); // hata mesajı detayları
            }
            Console.ReadLine();
        }
    }
}
