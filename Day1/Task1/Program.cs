using System.Text;

while (true)
{
    Console.WriteLine(@"Выберите действие:
    Показать список продуктов: a
    Добавить новый продукт: b
    Продать продукт: c");
    Console.WriteLine("Выберите действие a b c:");

    var option = Console.ReadLine();

    string[] products = File.ReadAllLines("store.txt", Encoding.UTF8);
    
    if (option == "a")
    {
        foreach (var item in products)
        {
            Console.WriteLine(item);
        }
    }
    else if (option == "b")
    {
        Console.WriteLine("Имя продукта");
        string newlyadded =Console.ReadLine();
        Console.WriteLine("Количество продукта");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < products.Length; i++)
        {
            string product = products[i];
            var splitted = product.Split(' ');

            string productName = splitted[0];
            int countOfProduct = int.Parse(splitted[1]);
            if (productName == newlyadded)
            {
                countOfProduct += count;
            }
            products[i] = $"{productName} {countOfProduct}";
        }

        string[] added = new string[products.Length + 1];
        for (int i = 0; i < products.Length; i++)
        {
            added[i] = products[i];
        }

        added[products.Length] = $"{newlyadded} {count}";

        File.WriteAllLines("store.txt", added, Encoding.UTF8);
    }
    else if (option == "c")
    {
        Console.WriteLine("Имя продукта");
        string newlyadded = Console.ReadLine();
        Console.WriteLine("Количество продукта");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < products.Length; i++)
        {
            string product = products[i];
            var splitted = product.Split(' ');

            string productName = splitted[0];
            int countOfProduct = int.Parse(splitted[1]);
            if (productName == newlyadded)
            {
                countOfProduct -= count;
                products[i] = $"{productName} {countOfProduct}";
                break;
            }
        }
        File.WriteAllLines("store.txt", products, Encoding.UTF8);
    }
    else
    {

    }
}