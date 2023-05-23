using System.Text;

Console.WriteLine("Выберите действие:");
Console.Write("Показать список продуктов: a");
var a = double.Parse(Console.ReadLine());
Console.Write("Добавить новый продукт: b");
var b = double.Parse(Console.ReadLine());
Console.Write("Продать продукт: c");
var c = double.Parse(Console.ReadLine());

string[] products = File.ReadAllLines("store.txt", Encoding.UTF8);

string newlyadded = "Себ1";
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

Console.ReadLine();