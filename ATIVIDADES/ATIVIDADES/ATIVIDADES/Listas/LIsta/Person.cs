// person.cs

// Aqui criamos uma classe de tipo de dado
// abstrato

public class Person
{
    public string Name {get; set; }

    public int Age {get; set; }

    public CountryEnum Nationality {get; set; }
}

// ENUM = Enumerador
// Difere de classes. É uma lista de valores
public enum CountryEnum
{
    BR, US, AR, PY

}
