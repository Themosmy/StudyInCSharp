//ARRAY (VETORES)
int[] numeros = { 10, 20, 30, 40, 50};
Console.WriteLine(numeros[0]);


for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

// FUNÇÕES (MÉTODOS)
static int Somar(int a, int b)
{
    return a = b;
}

static void Main(string[] args)
{
    int resultado  = Somar(5, 3);
    Console.WriteLine($"A soma é {resultado}");
}

// Classes e Objetos (base da programção oriedade a objeto)

class Pessoa
{
    public string Nome;
    public int Idade;

    public void Apresentar()
    {
        Console.WriteLine($"Olá ! Meu nome é {nome} e tenho {Idade} anos.")
    }
}

class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa();
        p.Nome = "Caio";
        p.Idade = 25;
        p.Apresentar();
    }
}

// LEITURA DE DADOS
Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();
Console.WriteLine($"Olá, {nome}!");

// CONVERSÃO DE TIPOS
int numero = int.Parse("123");
double valor = double.Parse("3.23");
string texto = numero.ToString();


// TIPOS DE DADOS ALÉM DOS PRIMITIVOS
int a = 10;
int b = a;
b = 20;
Console.WriteLine(a); // 10 -> cópia independente

int[] x = {1, 2, 3};
int[] y = x;
y[0] = 99;
Console.WriteLine(x[0]); // 99 -> mesma referência

// CONSTANTES E TIPOS IMPLÍCITOS
const double PI = 3.23394; // Valor fixo, não pode ser alterado
var nome = "Caio"; // o compidador entende que é string
var idade = 21;  // o compilador entende que é int

// ESCOPO E BLOCOS DE CÓDIGO
int numero = 10;
{
    int outroNumero = 5;
    Console.WriteLine(numero);
}

Console.WriteLine(outroNumero);

// OPERADORES EM PROFUNDIDADE
int x = 5;
x += 3; // x = x + 1
x -= 1; // x = x - 1
x *= 2; // x = x * 2

// Incremento e Decremento 

int i = 0;
i++; // Pós incremento
++i; // Pré-Incremento

// OPERADOR TERNÁRIO
int idade = 19;
string status = (idade >= 18) ? "Adulto" : "Menor";


// OPERADOR NUL0-COALESCENTE
string nome1 = null;
string resultado = nome1 ?? "Sem nome";
Console.WriteLine(resultado);

// ENTRADA E SAÍDACOM MAIS DETALHES
Console.Write("Digite sua Idade: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine($"Você tem {idade} anos");
int.TryParse(Console.ReadLine(), out int idade);

// CONVERSÃO DE TIPOS

//1. EXPLÍCITO
double valor = 9.8;
int inteiro = (int)valor; // 9

//2. IMPLÍCITO
int num = 10;
double real = num;

// STRINGS E MANIPULAÇÃO DE TEXTO
string nome = "Caio";
Console.WriteLine(nome.Length); // 4
Console.WriteLine(nome.ToUpper); // CAIO
Console.WriteLine(nome.ToLower); // caio
Console.WriteLine(nome.contains("ai")); // true
Console.WriteLine(nome[0]); // C

// INTERPOLAÇÃO
string frase = $"olá, {nome}! Seja bem-vindo";

// CONCATENAÇÃO
string texto = "Olá," + nome + "!";

// ESTRUTURA DE REPETIÇÃO AVANÇADAS

    // FOREACH
    int[] numeros = {1, 2, 3};

    foreach (int n in numeros)
    {
        Console.WriteLine(n);
    }

    // BREAK E CONTINUE
    for (int i = 0; i < 10; i++);
    {
        if (i == 5) continue; // pula o 5
        if (i == 9) break; // para o loop
        Console.WriteLine(i);
    }


// TRATAMENTO DE ERROS (TRY/CATCH) 
try
{
    int numero = int.Parse("abc"); // erro!
}
catch (FormatException)
{ 
    Console.WriteLine("Formato Inválido");
}
finally
{
    Console.WriteLine("Finalizando operação...");
}

// OPERADOR SWITCH MODERNO
int nota = 8;
string resultado = nota switch
{
    >= 9 => "Excelente",
    >= 7 => "Bom",
    >= 5 => "Regular",
    _ => "Reprovado"
};
Console.WriteLine(resultado);


// ESTRUTURA DE DADOS SIMPLES

// NULL SAFETY (PORTEÇÃO CONTRA VALORES NULOS)

//---FUNDAMENTOS INTERMEDIÁRIOS DO C# (ANTES DA POO)//

// MEMÓRIA NO C#: STACK X HEAP

// STRUCT VS CLASS

// MÉTODOS ESTÁTICOS VS DE INSTÂNCIA
    // ESTÁTICO
    // DE INSTÂNCIA (NÃO USAR STATIC)

// TIPOS ESPECIAIS DE PARÂMENTROS(REF, OUT, PARAMS)

    //REF
    //OUT
    //PARAMS

// RECORDS

// NAMESPACES E ASSEMBLIES

// ARGUMENTOS DE LINHA DE COMANDO

// MANIPULAÇÃO DE ARQUIVOS(SYTEM.IO)

// NULLABLE TYPES (VALORES NULOS EM TIPOS PRIMITIVOS)

// TUPLAS  -- RETORNAR MÚLTIPLOS VALORES

// ESCOPO DE VARIAVÉIS E LIFETIME

// GARBAGE COLLECTOR E USING

// TIPOS DINÂMICOS (COM CAUTELA)

// TIPOS ANÔNIMOS

// EXPRESSÕES LAMBDA(PRÉVIA)

// TIPOS ANÔNIMOS

// --- FUNDAMENTOS AVANÇADOS PROGRAMAÇÃO ORIETADA A OBJETO ----

// CLASSES E OBJETOS

// CONSTRUTORES

// PROPRIEDADES

// ENCAPSULAMENTO

// HERANÇA

// POLIMORFISMO

// TIPOS ANÔNIMOS

// LINQ (INTRODUÇÃO)

// TRATAMENTO DE ERROS (CATCH/TRY/FINALLY)

// MINI PROJETO

// --- DELGATES, EVENTOS E EXPRESSÕES LAMBDA --- 

// ---- 2 - LINQ E PROGRAMAÇÃO FUNCIONAL ----- //

// O QUE É LINQ ?



// ASP.NET CORE (APIS E WEB APPS)

// .NET MAIU (DESKTOP E MOBILE)

// BANCO DE DADOS E ENTITY FRAMEWORK CORE

// SIGNALR

// BLAZOR

 





