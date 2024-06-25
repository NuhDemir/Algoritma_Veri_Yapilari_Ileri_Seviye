## BİG O NOTASYONU NEDİR?

Büyük O notasyonu, bir algoritmanın **karmaşıklığı**nı veya **zaman karmaşıklığı**nı ifade etmek için kullanılan matematiksel bir gösterimdir. Basitçe söylemek gerekirse, bir algoritmanın ne kadar **hızlı** veya **yavaş** olduğunu gösterir.

Büyük O notasyonu, algoritmanın **giriş boyutu** arttıkça ne kadar **işlem** yapacağını gösterir. Bu, bir algoritmanın **verimliliği**ni değerlendirmek için çok önemlidir, özellikle de büyük veri kümeleriyle çalışırken.
<img src ="https://raw.githubusercontent.com/NuhDemir/Algoritma_Veri_Yapilari_Ileri_Seviye/main/img/BigO.png" width ="640px" height="360px">
**Örnekler:**

**O(1):**

```c#
public int SabitSure(int n)
{
  return n * 0 + 1; // Her zaman 1 birim zamanda çalışır.
}
```

**O(log n):**

```c#
public int LogaritmikSure(int n)
{
  return Math.Log2(n); // n değeri iki katına çıktığında 1 birim artar.
}
```

**O(n):**

```c#
public int DogrusalSure(int n)
{
  int toplam = 0;
  for (int i = 0; i < n; i++)
  {
    toplam += i;
  }
  return toplam; // n değeri iki katına çıktığında 2 katına çıkar.
}
```

**O(n^2):**

```c#
public int KareselSure(int n)
{
  int toplam = 0;
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n; j++)
    {
      toplam += i * j;
    }
  }
  return toplam; // n değeri iki katına çıktığında 4 katına çıkar.
}
```

**O(2^n):**

```c#
public int UstelSure(int n)
{
  if (n == 0)
  {
    return 1;
  }
  else
  {
    return 2 * UstelSure(n - 1); // n değeri iki katına çıktığında katlanarak artar.
  }
}
```

Bu örnekler, Büyük O notasyonunun farklı karmaşıklık seviyelerini nasıl gösterdiğini göstermektedir. Gerçek bir kodda, Büyük O notasyonu genellikle algoritmanın en baskın terimini analiz ederek hesaplanır.

**Not:** Bu örnekler sadece basit birer gösterimdir. Gerçek bir uygulamada, algoritmanın karmaşıklığı daha karmaşık olabilir ve birden fazla faktörü içerebilir.

**Büyük O notasyonu hakkında daha fazla bilgi edinmek için:**

* [https://www.youtube.com/watch?v=Mo4vesaut8g](https://www.youtube.com/watch?v=Mo4vesaut8g)
* [https://medium.com/@ericapantojacs/intro-to-big-o-notation-9a11244a3231](https://medium.com/@ericapantojacs/intro-to-big-o-notation-9a11244a3231)
* [https://www.academia.edu/29878286/Large_scale_Analysis_of_Spoken_Free_verse_Poetry](https://www.academia.edu/29878286/Large_scale_Analysis_of_Spoken_Free_verse_Poetry)

