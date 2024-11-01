// Formas de declarar o vetor
int [] vetor1 = new int[5];
// Sem estabelcer tamanho
int [] vetor2 = new int[] {1, 2, 3, 4, 5};
int [] vetor3 = {1, 2, 3, 4, 5};
int [] vetor4 = {} // vetor vazio

// Acessando elementos
System.Console.WriteLine(vetor2[4]);

// Alterando elementos
vetor2[6] = 10;
System.Console.WriteLine(vetor2[4]);

// Percorrendo o vetor
for (int i = 0; i < vetor2.Length; i++)
{
    System.Console.WriteLine(vetor2[i]);
}

// Percorrendo o vetor com foreach
foreach (int item in vetor2)
{
    System.Console.WriteLine(item);
}

// Percorrendo o vetor com while
int j = 0;
while (j < vetor2.Length)
{
    System.Console.WriteLine(vetor2[j]);
    j++;
}

// Percorrendo o vetor com do while
int k = 0;
do
{
    System.Console.WriteLine(vetor2[k]);
    k++;
} while (k < vetor2.Length);