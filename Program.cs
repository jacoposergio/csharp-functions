////Funzioni

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write("elemento " + array[i] + ", ");
        else
            Console.Write("elemento " + array[i]);
    }
    Console.Write("]");
}

int Quadrato(int likeToSquare)
{
    return likeToSquare * likeToSquare;
}


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arraySquared = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arraySquared[i] = Quadrato(array[i]);
    }
    return arraySquared;
}


int SommaElementiArray(int[] array)
{
    int sommaTotaleElementi = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sommaTotaleElementi += array[i];
    }
    return sommaTotaleElementi;
}

////Applicazione funzioni

//int[] arrayTest = { 2, 6, 7, 5, 3, 9 };

//StampaArray(arrayTest);
//Console.WriteLine("\r\n");
//int[] arrayAlQuadrato = ElevaArrayAlQuadrato(arrayTest);
//StampaArray(arrayAlQuadrato);
//Console.WriteLine("\r\n");
//StampaArray(arrayTest);
//Console.WriteLine("\r\n");
//int sommaTuttiNumeri = SommaElementiArray(arrayTest);
//Console.WriteLine("La somma di tutti i numeri è " + sommaTuttiNumeri);
//Console.WriteLine("\r\n");
//Console.WriteLine("La somma di tutti i numeri al quadrato è " + Quadrato(sommaTuttiNumeri));

//iterativa 

//int CalcoloFattoriale(int numero)
//{
//    for (int i = numero - 1; i > 0; i--)
//    {
//        numero *= i;
//    }
//    return numero;
//}

//int numberTest = 4;
//Console.WriteLine("Il risultato del fattoriale è: " + CalcoloFattoriale(numberTest));

//ricorsiva

//int CalcoloFattoriale(int numero)
//{

//    if (numero == 0)
//        return 1;
//    else if (numero == 1)
//        return 1;
//    else
//    {
//        int fattoriale = 0;
//        fattoriale = CalcoloFattoriale(numero - 1) * numero;
//        return fattoriale;
//    }
//}

//int numberTest = 4;
//Console.WriteLine("Il risultato del fattoriale è: " + CalcoloFattoriale(numberTest));

//fibonacci

//int[] CalcoloFibonacci(int numero)
//{
//    int[] array = new int[numero + 1];
//    for(int i = 0; i <= numero; i++)
//    {
//        if(i == 0)
//            array[i] = 0;
//         else if (i == 1)
//            array[i] = 1;
//        else
//        {
//            int numeroFibonacci = array[i - 1] + array[i - 2];
//            array[i] = numeroFibonacci;
//        }
//    }
//        return array;
//}

//int numberTest = 8;
//int[] fibonacciArray = CalcoloFibonacci(numberTest);
//Console.Write("La successione di Fibonacci è : ");
//StampaArray(fibonacciArray);
//Console.WriteLine("\r\n");
//Console.WriteLine( " il numero di fibonacci è " + fibonacciArray[fibonacciArray.Length - 1]);

