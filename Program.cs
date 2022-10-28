//void StampaArray(int[] array): che preso un array di numeri interi, 
//    stampa a video il contenuto dell’array in questa forma
//    “[elemento 1, elemento 2, elemento 3, ...]“.

//int[] arrayTest = { 1, 2, 3, 4, 5 };
//StampaArray(arrayTest);

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("elemento" + array[i] + ", ");
    }
    Console.Write("]");
}

// *****fare l'ultimo elemento dell'array con l'if ******


//********************************************************************************************************

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro. 


int Quadrato(int likeToSquare)
{
    return likeToSquare * likeToSquare;
}

//Console.WriteLine("Inserisci un numero");
//int userNumber = Convert.ToInt32(Console.ReadLine());
//int userNumberSquare = Quadrato(userNumber);

//Console.WriteLine("numero al quadrato: " + userNumberSquare);


//********************************************************************************************************

//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti
//    gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come 
//    parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arraySquared = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arraySquared[i] = Quadrato(array[i]);
    }
    return arraySquared;
}

int[] arrayTest = { 1, 2, 3, 4, 5 };
int[] arrayTestSquared = ElevaArrayAlQuadrato(arrayTest);






