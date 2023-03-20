using System.Diagnostics;

public class Product
{
    public int id { get; } = new Random().Next(1000, 9999);
    public string name { get; set; }
    public string description { get; set; }
    public double price { get; set; }
    public double vat { get; set; }

    public Product(string name, string description, double price, double vat)
    {
        this.name = name;
        this.description = description;
        this.price = price;
        this.vat = vat;
    }

    public string getPriceNoVAT()
    {
        var _price = price.ToString("0.00€");
        return _price;
    }
    public string getPriceVAT()
    {
        var _priceWithVat = price + (price / 100) * vat + "€";
        return _priceWithVat;
    }

    public string getExtendedName()
    {
        var extended = $"{id} - {name}";
        return extended;
    }
};