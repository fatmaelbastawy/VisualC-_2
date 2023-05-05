using Lab2_Zoo;

internal class Program
{
    public static IEnumerable<object> animals { get; private set; }

    private static void Main(string[] args)
    {


        Lion lion = new Lion();
        Sparrow sparrow = new Sparrow();
        Elephant elephant = new Elephant();
        Pigeon pigeon = new Pigeon();

        Zoo zoo = new Zoo();

        zoo.Add(lion);
        zoo.Add(sparrow);
        zoo.Add(elephant);
        zoo.Add(pigeon);
        Console.WriteLine("Animals");
        Console.WriteLine("---");
        foreach (var item in zoo.animals)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("---------------------");
        Console.WriteLine("Birds");
        Console.WriteLine("---");

        foreach (var item in zoo.Birds)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("---------------------");
        Console.WriteLine("Mammels");
        Console.WriteLine("---");

        foreach (var item in zoo.Mammels)
        {
            Console.WriteLine(item.Name);
        }
     PhoneBook phonebook = new PhoneBook();
    phonebook[123]="fatma";
        
    phonebook["nesma"]=456;
    int phone = phonebook["fatma"];
}


   

}