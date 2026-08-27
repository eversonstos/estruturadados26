int[] pares = new int[10];
int[] impares = new int[10];

int qtdPares = 0;
int qtdImpares = 0;

for(int i=0;i<10;i++)
{
    Console.Write("Digite um número: ");
    int numero=int.Parse(Console.ReadLine());
     if (numero % 2 == 0)
     {
        pares[qtdPares] = numero;
        qtdPares++;
     }
     else
     {
        impares[qtdImpares] = numero;
        qtdImpares++;
     }
}

Console.WriteLine("\nPares:");
for (int i=0;i < qtdPares; i++)
{
    Console.Write(pares[i]+" ");
}

Console.WriteLine("\nÍmpares:");
for (int i=0;i < qtdImpares; i++)
{
    Console.Write(impares[i]+" ");
}
