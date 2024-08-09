using Hafta4KapanisPratigi;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Telefon üretmek için 1'e, Bilgisayar üretmek için 2'ye basınız.");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Telefon telefon = new Telefon();

                Console.Write("Seri Numarası: ");
                telefon.SeriNumarasi = Console.ReadLine();

                Console.Write("Ad: ");
                telefon.Ad = Console.ReadLine();

                Console.Write("Açıklama: ");
                telefon.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                telefon.IsletimSistemi = Console.ReadLine();

                Console.Write("TR Lisanslı mı? (Evet/Hayır): ");
                string trLisansli = Console.ReadLine();
                telefon.TrLisansli = trLisansli.ToLower() == "evet";

                Console.WriteLine("\nÜrün başarıyla üretildi.");
                telefon.BilgileriYazdir();
                Console.WriteLine(telefon.UrunAdiGetir());
            }
            else if (secim == "2")
            {
                Bilgisayar bilgisayar = new Bilgisayar();

                Console.Write("Seri Numarası: ");
                bilgisayar.SeriNumarasi = Console.ReadLine();

                Console.Write("Ad: ");
                bilgisayar.Ad = Console.ReadLine();

                Console.Write("Açıklama: ");
                bilgisayar.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                bilgisayar.IsletimSistemi = Console.ReadLine();

                Console.Write("USB Giriş Sayısı (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bluetooth var mı? (Evet/Hayır): ");
                string bluetooth = Console.ReadLine();
                bilgisayar.Bluetooth = bluetooth.ToLower() == "evet";

                Console.WriteLine("\nÜrün başarıyla üretildi.");
                bilgisayar.BilgileriYazdir();
                Console.WriteLine(bilgisayar.UrunAdiGetir());
            }
            else
            {
                Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                continue;
            }

            Console.WriteLine("\nBaşka bir ürün üretmek istiyor musunuz? (Evet/Hayır)");
            string devam = Console.ReadLine();
            if (devam.ToLower() != "evet")
            {
                Console.WriteLine("İyi günler!");
                break;
            }
        }
    }
}