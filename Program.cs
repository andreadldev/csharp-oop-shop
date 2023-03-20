Console.OutputEncoding = System.Text.Encoding.UTF8;

Product phone = new Product("Samsung Galaxy S22", "Smartphone con sistema operativo Android", 438.00, 22);
Console.WriteLine(phone.getExtendedName());
Console.WriteLine($"\nCodice: {phone.id}");
Console.WriteLine($"Nome prodotto: {phone.name}");
Console.WriteLine($"Descrizione: {phone.description}");
Console.WriteLine($"Prezzo: {phone.getPriceNoVAT()}");
Console.WriteLine($"Prezzo + iva: {phone.getPriceVAT()}");
