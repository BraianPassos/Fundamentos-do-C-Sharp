struct Product
{
    public int Id;
    public string Name;
    public double Price;

    public Product(int id,string name, double price)
    {
        Id = id;
        Name = name;
        Price = princeInDolar(price);
    }
    public double princeInDolar(double price, double dolar = 5.66f)
    {
        return price * dolar;
    }
}

struct Funcionario
{
    public int Id;
    public string Name;
    public string Setor;
}