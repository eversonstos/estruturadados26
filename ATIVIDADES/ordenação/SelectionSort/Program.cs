using SelectionSort;    

int[] integerValues = 
 {-11, 12, -42, 0, 1, 90, 6, -9};

Console.WriteLine("Vetor Original");
Console.WriteLine(
    string.Join("|", integerValues)
);

 SelectionSort
 .SelectionSort.Sort(integerValues);
Console.WriteLine("Vetor Ordenado:");
Console.WriteLine(
    string.Join("|", integerValues)
);



string[] stringValues = 
 {"Chernobyl", "Eudes", "Mayckon", "Fernandes", "Serjão1", "Gorgulho", "Matheus", "Christhian"};

Console.WriteLine("Vetor Original");
Console.WriteLine(
    string.Join("|", stringValues)
);

 SelectionSort
 .SelectionSort.Sort(stringValues);
Console.WriteLine("Vetor Ordenado:");
Console.WriteLine(
    string.Join("|", stringValues)
);