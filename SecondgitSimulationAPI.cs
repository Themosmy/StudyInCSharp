interface IRepositorio<T>
{
    void Adicionar(T item);
    IEnumerable<T> Listar();
}

class Cliente
{
    public string Nome {get; set; }
}

class RepositorioCliente : IRepositorio<Cliente>
{
    private List<Cliente> clientes = new();

    public void Adicionar(Cliente Item)
    {
        clientes.Add(item);
        Console.WriteLine($"Cliente{Item.Nome} adicionado.");
    }

    public IEnumerable<Cliente> Listar() => clientes;
}

class Program
{
    static void Main()
    {
        IRepositorioCliente> Repo = new RepositorioCliente();
        repo.adicionar(new Cliente { Nome = "Caio"});
        repo.Adicionar(new Cliente { Nome = "Lucas"});

        foreach (var c in repo.listar())
            Console.WriteLine($"Cliente:{c.Nome}");
    }
}
/*Aqui você aplica:

- Interface genérica
- Lista interna
- Boas práticas de encapsulamento
- Base para arquiteturas reais (ex: Repository Pattern)*/