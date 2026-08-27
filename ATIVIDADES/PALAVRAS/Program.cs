using System.Numerics;

string firstName = "Everson";
string lastName = "João dos Santos";

string note = lastName.ToUpper()
        + " " + firstName;

string initials = lastName[0] +" "
                + firstName[0];

                Console.WriteLine("" + initials);

// Formatação de String
string texto = string.Format (
    "{0} {1} nascido em {2}",
    firstName,
    lastName,
    "2006"
);

Console.WriteLine(texto);

// C# é uma linguagem do C++
// Totalmente orientada a objetos
// Portanto, tudo dentro do C é descendente
// do tipo Object

int age = 20;
object ageBoxing = age;
int ageUnboxing = (int) ageBoxing;

/*
vetores uni-dimensionais
sintaxe: type[] name;
*/

// declação sem inicialização
// obs.: variavel alocada nas nulas

int[] numbers;

// inicializandos o vetor
numbers = new int[5];

// atribuindo valores ao vetor
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

// e possivel declarar o vetor e
//ja definir e atribuir

int [] number2 = 
    new int [] { 100, 200, 300 };
int[] number3 = 
    { 1000 ,2000 ,3000 ,4000 };

// Percorrendo um vetor e adcionando
// Valores dinimicamente

Console.WriteLine(
    "Iniciando com vetores.");
Console.WriteLine
    ("Informe o tamamho do vetor de inteiros: ");

int size = Convert.ToInt32(Console.ReadLine());

int[] mArray = new int[size];
int total = 0; //acumulador
int counter = 0;

for(int i = 0;i < mArray.Length; i++)
{
    Console.WriteLine(
        "Digite para [" + i + "]: "
    );
    mArray[i] = Convert.ToInt32(
        Console.ReadLine()
    );

    total += mArray[i];
    counter++;
    }

    Console.WriteLine(
        "Contage = " + counter
    );