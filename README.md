# Programlama Vize Çalışmaları

Bu proje, C# programlama dili ile geliştirilmiş temel düzeyde iki farklı uygulamayı (Rehber ve Hesap Makinesi) içeren bir konsol projesidir. Eğitim amaçlı "Programlama Vize Çalışmaları" kapsamında hazırlanmıştır.

## Proje İçeriği

Uygulama çalıştırıldığında kullanıcıyı karşılayan ana menü üzerinden iki farklı modüle erişim sağlanabilir:

1.  **Rehber Uygulaması:** Kişi bilgilerini kaydeden, dosya üzerinde saklayan ve listeleyen bir sistem.
2.  **Hesap Makinesi:** Temel aritmetik işlemleri gerçekleştiren bir araç.

---

## Modül Özellikleri

### 1. Rehber Uygulaması (`Rehber.cs`)
Bu modül, basit bir telefon rehberi işlevi görür:
* **Kişi Ekleme:** Kullanıcıdan ad, soyad ve telefon numarası bilgilerini alır.
* **Veri Saklama:** Girilen bilgiler `rehber.txt` dosyasına satır bazlı olarak kaydedilir, böylece veriler kalıcı hale gelir.
* **Listeleme:** Dosyada kayıtlı olan tüm kişileri okuyarak konsol ekranında listeler.
* **Veri Yapısı:** Bilgiler, `kisi` isimli bir sınıf (class) yapısı kullanılarak yönetilir.

### 2. Hesap Makinesi (`hesap-makinesi.cs`)
Kullanıcıdan alınan sayılarla temel matematiksel işlemleri yapar:
* **İşlem Seçenekleri:** Toplama (+), Çıkarma (-), Çarpma (*) ve Bölme (/) işlemlerini destekler.
* **Hata Denetimi:** Bölme işleminde paydanın (ikinci sayı) 0 olması durumunda kullanıcıya "Bölen sıfır olamaz" uyarısını verir.
* **Döngü Yapısı:** Geçersiz bir işlem karakteri girildiğinde, kullanıcı doğru karakteri girene kadar seçim yapmaya zorlanır.

---

## Teknik Özellikler

* **Programlama Dili:** C#
* **Hedef Çerçeve:** .NET Framework 4.7.2
* **Proje Tipi:** Console Application (Konsol Uygulaması)
* **Kullanılan Temel Kütüphaneler:** * `System.IO`: Dosya okuma ve yazma işlemleri için.
    * `System.Linq`: Veri sorgulama ve koleksiyon işlemleri için.

---

## Kurulum ve Çalıştırma

1.  Projeyi bir IDE (Visual Studio, JetBrains Rider vb.) ile açın.
2.  `Peogramlama-vize-calismalari.slnx` veya `.csproj` dosyasını kullanarak projeyi derleyin.
3.  Uygulamayı başlattığınızda konsol ekranındaki yönlendirmeleri takip edin:
    * `1` tuşu ile Rehber modülüne geçiş yapın.
    * `2` tuşu ile Hesap Makinesi modülüne geçiş yapın.
    * `3` tuşu ile programdan güvenli çıkış yapın.

---
*Bu proje vize hazırlık çalışmaları kapsamında kodlanmıştır.*
