using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.LastName + " Kayıt işlemleri yapıldı");
        }
        public void Sil(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Kaydı silindi.Silinen Müşteri :" + musteri.Name + " " + musteri.LastName);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Ad :"+musteri.Name);
            Console.WriteLine("Soyad :" + musteri.LastName);
            Console.WriteLine("Hesap Bakiyesi :" + musteri.Price);
            Console.WriteLine("________________________");
        }
    }
}
