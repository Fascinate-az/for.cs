int[] numeriRandom = new int [50];

Random number = new Random();



for(int i = 0;i< numeriRandom.Length; i++)
{
    numeriRandom[i] = number.Next(1,101);
}
Array.Sort(numeriRandom);


for (int i = 0; i < numeriRandom.Length; i++)
{
    
   Console.WriteLine(numeriRandom[i]);
}

long somma = 0;

foreach(int i in numeriRandom)
{
    somma += i; 

    
}
Console.WriteLine($"la somma totale dei numeri estratti è di {somma}");

double media = (double)somma/ 50;

Console.WriteLine($"la media  dei numeri estratti è di {media}");



int posizioneMin = 0;
int contatore = 0;

for(int i = 0;i < numeriRandom.Length; i++)
{
    if (numeriRandom[i] < numeriRandom[posizioneMin]){
        posizioneMin = i;
        
    }


}

for (int i = 1; i < numeriRandom.Length; i++)
{
    if (numeriRandom[i] == numeriRandom[posizioneMin])
    {
        contatore++;
    }
}
Console.WriteLine($"il numero piu piccolo è {numeriRandom[posizioneMin]}, è uscito {contatore} volte");

Console.ReadKey();
