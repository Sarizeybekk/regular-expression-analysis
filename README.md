
 # 🛠️ Regex ve Morfolojik Analiz 

Bu proje, Türkçe metin dosyaları üzerinde **RegEx aramaları** ve **morfolojik analizler** gerçekleştiren bir masaüstü uygulamasıdır. Proje, C# programlama dili ile geliştirilmiş olup, **Visual Studio** ortamında çalışmaktadır. Uygulama, metin içeriğinin düzenlenmesi, analiz edilmesi ve detaylı sonuçların kullanıcıya sunulmasını sağlamaktadır.

---

## 🎯 Proje Amaçları

- Kullanıcıların bilgisayarlarından `.txt` uzantılı dosyaları seçip analiz yapabilmesini sağlamak.
- Kullanıcının girdiği **RegEx ifadesi** ile metinde arama yapma ve sonuçları görselleştirme.
- Metindeki hatalı yazımları düzeltme, noktalama işaretlerini temizleme ve metni hazırlama.
- Metindeki benzersiz kelimelerin **kök** ve **morfem analizlerini** yaparak eşsiz kelime sayılarını hesaplama.

---

## 🛠️ Özellikler

1. **📂 Dosya Yönetimi**:
   - Kullanıcı, bilgisayarından bir `.txt` dosyası seçerek işlem başlatabilir.
   - Seçilen dosya adı ve yolu, uygulamada görselleştirilir.

2. **🔍 RegEx Arama**:
   - Kullanıcı, girdiği **RegEx ifadesi** ile metinde arama yapabilir.
   - Arama sonuçları, ayrı bir pencerede detaylı olarak listelenir.

3. **🔧 Morfolojik Analiz**:
   - Metindeki yazım hatalarını düzeltir ve noktalama işaretlerini kaldırır.
   - Kelimelerin kök ve morfem yapıları analiz edilir.
   - Eşsiz kelime sayıları, kök alma öncesi ve sonrası karşılaştırmalı olarak gösterilir.

---

## 🧩 Proje Detayları

### 1. **Dosya Seçme**
- **Fonksiyon**: `dosyaEkleBtn_Click`
- Kullanıcı, `.txt` uzantılı bir dosya seçerek işlem başlatır.
- Seçilen dosyanın adı ve yolu, ekranda görüntülenir.

### 2. **RegEx Arama**
- **Fonksiyon**: `rgxAraBtn_Click`
- Kullanıcı, metinde belirli bir **RegEx desenine** göre arama yapabilir.
- Sonuçlar, yeni bir form ekranında listelenir.

### 3. **Morfolojik Analiz**
- **Fonksiyon**: `morfolojikAnalizBtn_Click`
- Metindeki hatalar düzeltilir, noktalama işaretleri temizlenir.
- Kelimelerin kök ve morfem yapıları analiz edilir.
- **Zemberek** kütüphanesi kullanılarak kelimeler üzerinde detaylı analiz yapılır.

---

## 📚 Kullanılan Teknolojiler

- **Programlama Dili**: C#
- **Geliştirme Ortamı**: Visual Studio
- **Doğal Dil İşleme (NLP)**: Zemberek Kütüphanesi
- **Regex İşlemleri**: .NET Regular Expressions

---

## 🚀 Kurulum ve Çalıştırma

1. **Kaynak Kodları İndir**:
   ```bash
   git clone https://github.com/<your-repo-name>/RegexMorphologyAnalyzer.git
   cd RegexMorphologyAnalyzer

![image](https://github.com/Sarizeybekk/regular-expression-analysis/assets/85437211/27303f81-4f8a-4fb6-baca-21e78e582a3c)
![image](https://github.com/Sarizeybekk/regular-expression-analysis/assets/85437211/04a2d8ea-f55d-4ff0-9388-3cf08f1bdcf8)
![image](https://github.com/Sarizeybekk/regular-expression-analysis/assets/85437211/a4584d54-0987-493a-a11c-cf8716e92e05)

