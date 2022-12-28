// See https://aka.ms/new-console-template for more information
// 0 ın faktöriyeli 1
int sayi, n;
//faktöriyeli 0 olarak verseydim sonuç hep sıfır olurdu.
int faktöriyel = 1;
Console.WriteLine("Sayı değerini giriniz : ");
sayi = Convert.ToInt32(Console.ReadLine());
for (n = 1; n <= sayi; n++)
{
    //1*2*3*4*5 olması gerekiyor.Yani 1 den girilen sayıya kadar olan sayıların çarpımı faktöriyeli verir.
    faktöriyel = faktöriyel * n;
}
Console.WriteLine("Faktöriyel : " + faktöriyel);




