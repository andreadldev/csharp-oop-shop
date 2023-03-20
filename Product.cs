public class Product
{
    public int id { get; } = new Random().Next(1000, 9999);
    public string name { get; set; }
    public string description { get; set; }
    public string price { get; set; }
    public int vat { get; set; }

    public Product(string name, string description, string price, int vat)
    {
        this.name = name;
        this.description = description;
        this.price = price;
        this.vat = vat;
    }
};

//1.
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random

//2.
//Il codice prodotto sia accessibile solo in lettura

//3.
//Gli altri attributi siano accessibili sia in lettura che in scrittura

//4.
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva

//5.
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome