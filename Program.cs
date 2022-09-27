internal class Program
{
    private static void Main(string[] args)
    {
        //List<T> classs
        //System.Collections.Generic
        //T--> object turundedir.

        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");

        //Count
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);

        //Foreach ve List.ForEach ile elemanlara erişim
        foreach (var item in sayiListesi)
        {
            Console.WriteLine(item);
        }

        foreach (var item in renkListesi)
        {
            Console.WriteLine(item);
        }

        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));

        //Listeden eleman çıkarma
        sayiListesi.Remove(4);
        renkListesi.Remove("Yeşil");

        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));

        //Liste içerisinde Arama
        if(sayiListesi.Contains(10))
            Console.WriteLine("10 liste içerisinde bulundu!");
        
        //Eleman ile indexe erişme
        Console.WriteLine(renkListesi.BinarySearch("Sari"));

        //Diziyi List e çevirme
        string[] hayvanlar = {"Kedi","Köpek","Kuş"};
        List<string> hayvanListesi = new List<string>(hayvanlar);

        //Listeyi nasıl temizleriz
        hayvanListesi.Clear();

        //List içinde nesne tutmak
        List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
        Kullanicilar kullanici1 = new Kullanicilar();
        kullanici1.Isim="Ayse";
        kullanici1.Soyisim="Yilmaz";
        kullanici1.Yas=26;

        Kullanicilar kullanici2 = new Kullanicilar();
        kullanici2.Isim="Özcan";
        kullanici2.Soyisim="Çalışkan";
        kullanici2.Yas=25;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        List<Kullanicilar> yeniListe = new List<Kullanicilar>();
        yeniListe.Add(new Kullanicilar(){
            Isim ="Deniz",
            Soyisim ="Arda",
            Yas = 24
        });

        foreach (var kullanici in kullaniciListesi)
        {
            Console.WriteLine("Kullanici Adi: " + kullanici.Isim);
            Console.WriteLine("Kullanici Soyadi: " + kullanici.Soyisim);
            Console.WriteLine("Kullanici Yasi: " + kullanici.Yas);
        }

    }

    public class Kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Isim { get => isim; set => isim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}