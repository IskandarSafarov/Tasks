using System.Text;

while (true)
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("Показать список продуктов: a");
    Console.WriteLine("Добавить новый продукт: b");
    Console.WriteLine("Продать продукт: c");
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
        string newlyadded =Console.WriteLine;
        int count = 10;
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

        added[products.Length] = "Нок 20";

        File.WriteAllLines("store.txt", added, Encoding.UTF8);
    }
    else if (option == "c")
    {

    }
    else
    {

    }
    

    

    


  
}