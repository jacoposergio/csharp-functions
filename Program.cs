////Funzioni

//void StampaArray(int[] array)
//{
//    Console.Write("[");
//    for (int i = 0; i < array.Length; i++)
//    {
//        if(i < array.Length - 1)
//        Console.Write("elemento " + array[i] + ", ");
//        else
//            Console.Write("elemento " + array[i] );
//    }
//    Console.Write("]");
//}

//int Quadrato(int likeToSquare)
//{
//    return likeToSquare * likeToSquare;
//}


//int[] ElevaArrayAlQuadrato(int[] array)
//{
//    int[] arraySquared = new int[array.Length];

//    for (int i = 0; i < array.Length; i++)
//    {
//        arraySquared[i] = Quadrato(array[i]);
//    }
//    return arraySquared;
//}


//int SommaElementiArray(int[] array)
//{
//    int sommaTotaleElementi = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        sommaTotaleElementi += array[i];
//    }
//    return sommaTotaleElementi;
//}

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


int CalcoloFattoriale(int numero)
{
    for (int i = numero - 1; i > 0; i--)
    {
        numero *= i;
    }
    return numero;
}

int numberTest = 4;
Console.WriteLine("Il risultato del fattoriale è: " + CalcoloFattoriale(numberTest));


