using UnmanagedCode;

while (true)
{
    Console.WriteLine(@"r - to read
                        w - to write");
    string option = Console.ReadLine();
    if (option == "r")
    {
        using (Application app = new Application("store.txt"))
        {
            Console.WriteLine(app.ReadFromFile());
        }
    }
    else if (option == "w")
    {
        using (Application app = new Application("store.txt"))
        {
            Console.Write("Input something: ");
            string txt = Console.ReadLine();
            app.WriteToFile(txt);
        }

    }
}
/*
using ManagedUnmanaged;

while (true)
{
    Console.WriteLine("Choose operation:");

    var operation = Console.ReadLine();
    if (operation == "enter")
    {
        Console.WriteLine("Name:");
        var name = Console.ReadLine();

        Console.WriteLine("Count:");
        var count = int.Parse(Console.ReadLine());

        using (Application application = new Application())
        {
            application.WriteProduct(name, count);
        }
    }
}
*/
