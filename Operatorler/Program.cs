int birinciSayi = 10;

int ikinciSayi = 20;


// İLİŞKİSEL OPERATÖRLER


// büyük küçük operatörü

bool isBuyuk = ikinciSayi > birinciSayi;

bool isKucuk = ikinciSayi < birinciSayi;

// büyük veya eşitmi ?

bool büyükEsitmi = ikinciSayi >= birinciSayi;

bool kücükEsitmi = birinciSayi <= ikinciSayi;


// esit mi yada eşit değil mi ?

// esit ise true eşit değise false
bool esitmi = birinciSayi == ikinciSayi;


// eşit değilse true eşit ise false
bool esitDegilmi = birinciSayi != ikinciSayi;


// and ve or operatörü

int ucuncuSayi = 60;
int dorduncuSayi = 80;


// MANTIKSAL OPERATÖRLER
bool sonuc = ucuncuSayi > birinciSayi && ikinciSayi != dorduncuSayi;


bool sonuc1 = ucuncuSayi < birinciSayi || dorduncuSayi < ikinciSayi;


int sayi1 = 60;
int sayi2 = 50;
int sayi3 = 40;
int sayi4 = 10;

// ve operatöründe koşullardan herhangi bir tanesinden false dönerse tüm koşul false dönecektir.
bool sonuc2 = sayi1 == sayi4 && sayi2 > sayi3;
Console.WriteLine(sonuc2);

// veya operatöründe koşullardan herhangi bir tanesi true değer üretirse sonuc true'dir
bool sonuc3 = sayi1 == sayi4 || sayi2 > sayi3;



Console.WriteLine(sonuc3);

// Çoklu olarakta kullanmak mümkündür.
bool sonuc4 = (sayi1 == sayi4 && sayi2 > sayi3) && (sayi1 == sayi4 || sayi2 > sayi3);

Console.WriteLine(sonuc4);


// ATAMA OPERATÖRLERİ

int deger = 15;

deger = deger + 5;

Console.WriteLine(deger);


// farklı kullanım


// 5 artırdık
deger += 5;

Console.WriteLine(deger);


// 10 çıkartık
deger -= 10;

Console.WriteLine(deger);

// ikiye böldük
deger /= 2;

Console.WriteLine(deger);

// 5 çıkarttık
deger -= 5;

Console.WriteLine(deger);

// 10 ile çaptık
deger *= 10;


Console.WriteLine(deger);



// TEKLİ OPERATÖRLER


int sayi10 = 10;

// ++ sağda olduğunda değer diğer değişkene atanır ve sonra ++ ifadesi ile değişkenin değeri bir artar
int sayi11 = sayi10++;


// ++ solda olduğu için önce ++ operatörü çalışır ve değişkenin değeri artar ve sonra atama gerçekleştirilir
int sayi12 = ++sayi10;

// sayiyi bir azalttık
sayi12--;



bool isNot = true;


// ! not operatörü bool değişkenlerin değerlerini ters çevirmek için kullanılır
bool isNot2 = !isNot;

// değişkenin değeri true iken ! not koyarak false değerine çevirdik

Console.WriteLine(isNot2);


// ARİTMETİK OPERATÖRLER


int rakam1 = 11;
int rakam2 = 5;
int topla = rakam1 + rakam2;
int cikar = rakam2 - rakam1;
int bol = rakam2 / rakam1;
int carp = rakam1*rakam2;

int mod = rakam1 % rakam2;

Console.WriteLine(mod);