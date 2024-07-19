
//10 adet kere tanımlı yazı ekrana yazdırma
string yazı = "kendime inanıyorum, ben bu yazılım işini hallederim!" ;

for (int i = 0; i < 10; i++) 
{
    Console.WriteLine(yazı);
}
Console.WriteLine("----------------------------------------------- \n --------------------------------------");

//1 ile 20 arasındaki sayıları ekrana yazdırma
for (int i = 1;i < 20; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("----------------------------------------------- \n --------------------------------------");

//1 ile 20 arasındaki sayıları ekrana yazdırma
for (int i = 1; i < 20; i += 2)
{
    Console.WriteLine(i);
}
Console.WriteLine("----------------------------------------------- \n --------------------------------------");
int toplam = 0;

// 50 ile 150 sayıları arasındaki sayıların toplmanını ekrana yazdırma
for (int i = 50; i <= 150; i++)
{
    toplam += i;
}
Console.WriteLine(toplam);
Console.WriteLine("----------------------------------------------- \n --------------------------------------");

// 1 ile 120 sayıları arasındaki çift sayıların toplamını ekrana yazdırma
int cifttoplam = 0; 
for (int i = 0; i<=120; i+= 2)
{
    
    cifttoplam += i;
}
Console.WriteLine(cifttoplam);
Console.WriteLine("----------------------------------------------- \n --------------------------------------");

// 1 ile 120 sayıları arasındaki çift sayıların toplamını ekrana yazdırma
int tektoplam = 0;

for (int i = 1;i<=120; i+=2)
{
    tektoplam += i;
}
Console.WriteLine(tektoplam);