using ClassMetotDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.Name = "Mikail";
        musteri1.LastName = "Lale";
        musteri1.Price = 100;
        Musteri musteri2 = new Musteri();
        musteri2.Name = "Tuncay";
        musteri2.LastName = "Lale";
        musteri2.Price = 1000;
        Musteri musteri3 = new Musteri();
        musteri3.Name = "Muhammed";
        musteri3.LastName = "Lale";
        musteri3.Price = 1205;
        Musteri musteri4 = new Musteri();
        musteri4.Name = "Fatıma";
        musteri4.LastName = "Lale";
        musteri4.Price = 4500;

        

        Musteri[] musteriler = new Musteri[]
        {
            musteri1, musteri2, musteri3, musteri4
        };
        Console.WriteLine("Müşteriler Listelendi \n ------------------------");
        MusteriManager musteriManager = new MusteriManager();
        foreach (var item in musteriler)
        {
            musteriManager.Listele(item);
        }

        musteriManager.Ekle(musteri1);
        Console.WriteLine("--------------");
        musteriManager.Sil(musteri3);
    }
}