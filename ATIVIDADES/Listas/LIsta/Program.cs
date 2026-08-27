using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;

ArrayList arrayList = new ArrayList();

arrayList.Add(5);


arrayList.AddRange(new int [] { 1, 2, 3 });

arrayList.Insert(3, 7.8);

//Percorrendo itens da lista de forma genérica
foreach (object obj in arrayList)
{
    Console.WriteLine (obj);
}


// listas genericas

List<double> numbers = new List<double>();
Console.WriteLine("Digite 'sair' para encerrar.");

bool run = true;
do
{
    Console.WriteLine("Digite um numero:");
    string numberStr = Console.ReadLine();

    if(numberStr.Equals("sair"))
    {
        run = false;
        Console.WriteLine("Processo encerrado.");
        break;
    }
    else
    {
       //VALIDADE da entrada do usuario 
       //para checar é de fato um numero

        if(!double.TryParse(
            numberStr, System.Globalization.NumberStyles.Float,
            new NumberFormatInfo(),
            out double number
            )
        ){
            Console.WriteLine("Voce não digitou um número");
            continue;
        }
        
        numbers.Add (number);
        Console.WriteLine("A media dos valores informados é: "
        + numbers.Average()
        );
    }    
}while(run);

// LISTAS DE TIPOS ABSTRATOS(TAD)

List<Person> people = new List<Person>();
 
// Criar uma variável do tipo person
Person p1 = new Person();
p1.Name = "João";
p1.Age = 42;
p1.Nationality = CountryEnum.BR;

people.Add(p1);

//Adicionando a lista inline
people.Add( new Person()
{
    Name = "Mary",
    Age = 39,
    Nationality = CountryEnum.US
});

people.Add( new Person()
{
    Name = "Carlitos",
    Age = 24,
    Nationality = CountryEnum.AR
});

people.Add( new Person()
{
    Name = "Juanito",
    Age = 19,
    Nationality = CountryEnum.PY
});

// Exemplode ordenação de Lista Generica
// Utilizando LINQ
List<Person> results = 
    people.OrderBy(p => p.Name).ToList();

// Percoreeemos a Lista
foreach(Person p in results)
{
    Console.WriteLine(
         $"Nome: {p.Name}, Idade: {p.Age}, Nac: {p.Nationality}"
         );
}