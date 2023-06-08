while (true)
{
    Product pr = new Product();
    Console.WriteLine(@"Выберите действие:
    Показать список продуктов: a
    Добавить новый продукт: b
    Продать продукт: c");
    string userInput = Console.ReadLine();

    if (userInput == "a")
    {
        foreach (var item in Product.GetPorducts("store.txt"))
        {
            Console.WriteLine(item);
        }
    }
    else if (userInput == "b")
    {
        Console.Write("Имя продукта: ");
        string newProductName = Console.ReadLine();
        Console.Write("Количество продукта: ");
        int newProductQuantity = int.Parse(Console.ReadLine());

        if (Product.ProductExists(newProductName, "store.txt"))
        {
            pr.ChangeNumber(newProductName, newProductQuantity);
        }
        else
        {
            pr.SaveToFile(newProductName, newProductQuantity);
        }
    }
    else if (userInput == "c")
    {
        Console.Write("Имя продукта который хотите продать: ");
        string productName = Console.ReadLine();
        Console.Write("Количество продукта: ");
        int productQuantity = int.Parse(Console.ReadLine());

        pr.ChangeNumber(productName, -1 * productQuantity);
    }
}