Console.OutputEncoding = System.Text.Encoding.UTF8;

Product[] products = new Product[3];
products[0] = new Product("Samsung Galaxy S22", "Smartphone Samsung con sistema operativo Android", 438.00, 22);
products[1] = new Product("Asus Zenfone 9", "Smartphone Asus con sistema operativo Android", 492.00, 22);
products[2] = new Product("Apple iPhone 14", "Smartphone Apple con sistema operativo iOS", 659.00, 22);

for (int i = 0; i < products.Length; i++)
{
    if (i > 0)
    {
        Console.WriteLine();
    }
    Console.WriteLine(products[i].getExtendedName().ToUpper());
    Console.WriteLine($"Codice: {products[i].id}");
    Console.WriteLine($"Nome prodotto: {products[i].name}");
    Console.WriteLine($"Descrizione: {products[i].description}");
    Console.WriteLine($"Prezzo: {products[i].getPriceNoVAT()}");
    Console.WriteLine($"Prezzo + iva: {products[i].getPriceVAT()}");
} 