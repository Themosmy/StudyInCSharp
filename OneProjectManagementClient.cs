using system;
using system.Collections.Generic;

class Cliente
{
    public int ID { get; set; }
    public string Nome {get; set; }
    public string Email {get; set; }
}

class Program
{
    static List<Cliente> cliente = new List<Cliente>();
    static int contador = 1;

    static void Main()
    {
        while(true)
        {
            Console.WriteLine("\n1 - Adicionar Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("Escolha: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: AdicionarCliente(); break;
                case 2: ListarClientes(); break;
                case 3: return;
                default: Console.WriteLine("Opção Inválida!"); break;
        }
    }
}

static void AdicionarCliente()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        cliente.Add(new Cliente {ID = contador++, Nome = nome, Email = Email});
        Console.WriteLine("Cliente adicionado com sucesso !" );
    }

static void ListarClientes()
    {
        Console.WriteLine("\n--- LISTA DE CLIENTES ---");
        foreach (var c in clientes)
        {
            Console.WriteLine($"{c.ID} - {c.Nome} ({c.Email})");
        }
    }
}
/*Esse projetinho te ensina:

Entrada e saída de dados;

Manipulação de listas;

Estrutura de classes;

Lógica de repetição + controle;

Boas práticas básicas de CRUD.*/