// See https://aka.ms/new-console-template for more information


Console.WriteLine("1. Aşama : Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim");
}

Console.WriteLine("-----------------------------");

Console.WriteLine("2. Aşama : 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");

for (int i = 1;  i <= 20; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("-----------------------------");

Console.WriteLine("3. Aşama : 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");

for (int i = 0; i <= 20; i+=2)
{
    Console.WriteLine(i);
}

Console.WriteLine("-----------------------------");

Console.WriteLine("4. Aşama : 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");

int toplam = 0;
for (int i = 50; i <= 150; i++)
{
    toplam = toplam + i;
}
Console.WriteLine("Toplam : " + toplam);


Console.WriteLine("-----------------------------");

Console.WriteLine("5. Aşama : 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");

int totalT = 0;
int totalC = 0;

for (int i = 0; i <= 120; i++)
{
   if(i%2 == 0)
    {
        totalC += i;
    }
    else
    {
        totalT += i;
    }
}


Console.WriteLine("1 ile 120 sayıları arasındaki çift sayıların toplamı : " + totalC);

Console.WriteLine("1 ile 120 sayıları arasındaki tek sayıların toplamı : " + totalT);

