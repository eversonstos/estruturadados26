using System.Collections;

Hashtable phoneBook 
    = new Hashtable()
{
    { "Edson Arantes do Nasciomento", "0000"},
    { "Ronaldo Nazáro dos Santos", "1111"},
    { "Luiz Inácio Lula da Silva", "2222"}
};


// Adicionando em tempo de execução
phoneBook["Acelino Popó de Freitas"] = "3333";

// Tratando possível erro de duplicidade
// de chave

try{
    phoneBook.Add("Edson Arantes do Nasciomento", "000000");
}
catch(System.ArgumentException ae){
    Console.WriteLine ("Chave ja existe: " + ae.Message);
} 
catch (System.Exception ex){
    Console.WriteLine("Erro inesperado" + ex.Message);
}

// Percorrendo valores TabelaHash
Console.WriteLine ("Carderninho de telefone:");
if(phoneBook.Count == 0) {
    Console.WriteLine("Agenda vazia");
}else {
    int i = 1;
    foreach(DictionaryEntry entry in phoneBook)
    {
        Console.WriteLine($"{i}. {entry.Key} - {entry.Value}");
        i++;
    }
}

// Busca em chave
Console.WriteLine("");
Console.WriteLine("Busca por nome:");
string name = Console.ReadLine ();

if(phoneBook.Contains (name))
{
    string number = (string)phoneBook[name];
}
else
{
    Console.WriteLine($"{name} não encontrado");
}

/*
  DICIONÁRIOS
*/

Dictionary<string, string> dic = 
    new Dictionary<string, string> ()
{
    { "Dom Pedrão II", "123456"},
    { "Joaquim José da Silva Xavier", "112233"}
};

// Obtendo o valor do dicionário
string value = dic["Dom Pedrão II"];

dic["Dom Pedrão II"] = "666"; 

foreach(KeyValuePair<string, string> pair in dic)
{
    Console.WriteLine("" + pair.Key + " " + pair.Value);
}