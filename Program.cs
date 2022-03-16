// Söz dizimi
// class SinifAdi
//{
//      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
//      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
//      {
//      Metot Komutları
//      }
//}


// Erişim Belirleyiciler
// *Public 
// *Private
// *Internal
// *Protected



Calisan calisan1 = new Calisan();
calisan1.Ad = "Hakkı";
calisan1.Soyad = "Ayman";
calisan1.No = 1234567890;
calisan1.Departman ="Developer";

calisan1.CalisanBilgileri();

Console.WriteLine("\n");

Calisan calisan2 = new Calisan();
calisan2.Ad = "Deniz";
calisan2.Soyad = "Arda";
calisan2.No = 234567890;
calisan2.Departman = "IK";

calisan2.CalisanBilgileri();


class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;


    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}",Ad);
        Console.WriteLine("Çalışanın Soyadı:{0}",Soyad);
        Console.WriteLine("Çalışanın Numarası:{0}",No);
        Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
    }
}