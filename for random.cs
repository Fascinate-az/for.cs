Random numGen = new Random();
int conteggio = 0;
estrazzione();
Console.WriteLine($"il ciclo è stato eseguito {conteggio} volta");
Console.ReadKey();



int estrazzione()
{
    for (int i = 0; i < 80; i++)
    {
        int estratto = numGen.Next(1, 212);
        conteggio++;
        Console.WriteLine(estratto);
        if (estratto < 10)
        {
            Console.WriteLine("ciclo finito");
            break;

        }
        return estratto;
    }
    return -1;// -1 significa che non è stato trovato nessun numero al di sotto di 10 in questo caso, ma può anche essere un altro valore per dare esito negativo
}

    
