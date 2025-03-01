# Myhomework_1
Acunmedya C# Homework

1. Abstraction (Soyutlama) ve Abstract Class (Soyut Sınıf) Nedir?
 Abstarction konusunu ve Abstract Classları anlamak için temelde programcılar bu olguları ortaya çıkarırken 'nasıl bir kolaylık sağlamak istediler?' veya 'programlamaya nasıl bir özellik katmak istediler?' gibi sorular sormak gerektiğini düşünüyorum. Diyelim ki, kişisel arabası olan ve arabalara pek ilgisi olmayan sadece ulaşım ihtiyacını gidermek için araba kullanan bir insanı düşünelim. Bu kişi için önemli olan olgular basitçe  arabanın A noktasında B noktasına gidebilmesi, gaz pedalının ve fren pedalının düzgün çalışmasıdır, diyebiliriz.  Motorun içinde nasıl bir mekanizma olduğu veya gaz pedalına basınca arkada neler döndüğünü bilmesi gerekmez. Tam bu noktada programlamada  abstaction'ın  bir nesnenin veya sistemin sadece önemli özelliklerine odaklanabilmeyi. aslında kodun daha anlaşılır, yönetilebilir ve yeniden kullanılabilir olmasını sağladığını sonuç olarak çıkabiliriz.
Abstract Class'ı anlamak içinse 10 tane araba üreteceğimizi ve bu arabaların sadece iskeleti olduğunu hayal edelim. Bu 10 arabanın 4 tane tekerleği olacağını veya 4 kapılı olacağı gibi özelliklerin ortak olacağını düşünebiliriz ama motorunun özellikleri, iç döşemesinin nasıl olacağı gibi şeyler daha belli değildir. Abstract Class'ın bu noktada devreye girdiğini söyleyebiliriz.Sonuç olarak, Abstract class ortak bir şablon yoluyla bu özellikleri her araba için eklememizi sağlayacak.Abstract sınıfların temel amacını basitçe böyle anlatabiliriz.

2. Polymorphism (Çok Biçimlilik) Nedir?
Polymorphism konusunun işlevini, ayrıntılarını ve inceliklerini öğrenmemiz için temelde 'polymorphisim olmasaydı ne olurdu?' sorusunu yanıtlamak gerektiğini düşünüyorum.
Bu nedenle, öncelikli olarak aşağıdaki kodu inceleyim.
---------------------------------
public class Araba
{
    public void Calis()
    {
        Console.WriteLine("Araba çalışıyor.");
    }
}
---------------------------------
public class Sedan : Araba
{
    public void SedanCalis()
    {
        Console.WriteLine("Sedan araba çalışıyor.");
    }
}
----------------------------------
public class SUV : Araba
{
    public void SuvCalis()
    {
        Console.WriteLine("SUV araba çalışıyor.");
    }
}
----------------------------------
public class Program
{
    public static void Main(string[] args)
    {
        Sedan sedanAraba = new Sedan();
        SUV suvAraba = new SUV();
        sedanAraba.SedanCalis();
        suvAraba.SuvCalis();
        Araba normalAraba= new Araba();
        normalAraba.Calis();
         }
-------------------------------
Görüldüğü üzere, Araba(Base) Class'ını oluşturduk ve bu class'tan 2 farklı araba türü(sub_class) oluşturduk. Sonrasında base class'ta Calis metodunu yazdık ve her sub class için tekrardan ayrı bir calis metodu yazmak durumunda kaldık.
Şimdi ise polymorphisim kullanarak aynı kodu nasıl yazabiliriz bakalım.

public class Araba
{
    public void Calis()
    {
        Console.WriteLine("Araba çalışıyor.");
    }
}
-------------------------------
public class Sedan : Araba
{
    public new void Calis()
    {
        Console.WriteLine("Sedan araba çalışıyor.");
    }
}
-------------------------------
public class SUV : Araba
{
    public new void Calis()
    {
        Console.WriteLine("SUV araba çalışıyor.");
    }
}
-------------------------------
public class Program
{
    public static void Main(string[] args)
    {
        Araba sedan = new Sedan();
        Araba suv = new SUV();
        sedan.Calis();
        suv.Calis();
        Araba normalAraba = new Araba();
        normalAraba.Calis();
    }
}
-------------------------------

Yukardaki örnekte polimorfizm kullanarak base(Araba) class'ta  bir "Calis" metodu tanımladık.Alt sınıflarda (Sedan, SUV) aynı isimde (Calis) metotlar tanımladık.
'new anahtar' kelimesini kullanarak alt sınıfın base class'taki metodu geçersiz kılacağını belirttik. Bunu yapmamızın sebebi ise aslında ilk önce geçersiz kıldık ve sonrasında aynı işlevi subclassa özgü yerine getirmesi için tekrar aktif hale getirdik. Sonrasında sedan.Calis() ve suv.Calis() çağrıları, ilgili alt sınıfların "Calis" metotlarını çalıştırdı. Base (Araba) class tipinde oluşturulan nesnelerin calis fonksiyonu çağrıldığında o tipte ki classların fonksiyonu çalıştı.
Sonuç olarak temel farka bakacak olursak: Polimorfizm, farklı nesnelerin aynı arayüz üzerinden farklı davranışlar sergilemesini sağladı.
