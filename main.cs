//ARRAY (VETORES)
using utilidades.Matematica;

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
// Mesmo sem usar coleções complexas, dá para enteder: 
    // Array -> Tamanho fixo
    // List <T> -> Tamanho dinâmico

using System.Collections.Generic;

List<string> nomes = new List<string>();
nomes.Add("Caio");
nome.Add("Kaka");
Console.WriteLine(nomes[0]);

// NULL SAFETY (PORTEÇÃO CONTRA VALORES NULOS)
string? nome = null; // pode ser nulo
if (nome != null)
    Console.WriteLine(nome.ToUpper());
    //Com o operador condicional
    Console.WriteLine(nome?.ToUpper() ?? "Sem nome");


//---FUNDAMENTOS INTERMEDIÁRIOS DO C# (ANTES DA POO)//
// stack = gavetas pequenas e rápidas (guarda valores simples e temporários)
// Heap = armário grande e lento (guarda objetos, listas, strings etc )
int x = 10; // armazenado na stack
int[] numeros = {1, 2}; // referência na stack, mas os dados ficam na heap

/*🧠 1. Memória no C#: Stack x Heap

Essa é uma das partes mais importantes pra entender o comportamento real do código.

Tipo	Onde é armazenado	Exemplo	Quando é limpo
Stack (Pilha)	Memória rápida e pequena	int, double, bool, struct	Automaticamente, quando sai do escopo
Heap	Memória grande e lenta	class, string, array, List<T>	Gerenciada pelo Garbage Collector (GC)MEMÓRIA NO C#: STACK X HEAP */

// STRUCT VS CLASS
struct Ponto
{
    public int X;
    public int Y;
}
Ponto p1 = new Ponto { X = 10, Y = 20};
Ponto p2 = p1;
p2.X = 99;

Console.WriteLine(p1.X); // 10 -> Cópia independente



// MÉTODOS ESTÁTICOS VS DE INSTÂNCIA
    /* ESTÁTICO
    Pertence á classe, não a um objeto*/
class calculadora
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }
}

int resultado1 = calculadora.Somar(2, 3);

    // DE INSTÂNCIA (NÃO USAR STATIC)
class Pessoa
{
    public string Nome;

    public void Falar()
    {
        Console.WriteLine($"Olá, eu sou {Nome}");
    }
}
Pessoa p = new Pessoa {Nome = "Caio"};
p.Falar();

/**Dica:
Use static para utilidades, como Math.Sqrt(), Console.WriteLine() etc.
Use métodos normais quando o comportamento depende do estado do objeto.*/


// TIPOS ESPECIAIS DE PARÂMENTROS(REF, OUT, PARAMS)
    //REF => envia o valor por referência | Permite alterar a variável original. 
    void Dobrar(ref int numero)
{
    numero *= 2;
}

int x = 5;
Dobrar(ref x);
Console.WriteLine(x); // 10

    //OUT -> semelhante a ref, mas usado apenas para retorno
bool TentarConverter(string texto, out int resultado)
{
    return int.TryParse(texto, out resultado);    
}
if (TentarConverter("123", out int valor))
{
    Console.WriteLine($"Valor convertido: {valor}");
}

    //PARAMS --> Permite número variável de argumentos
int Somar(params int[] numeros)
{
    int soma = 0;
    foreach (int n in numeros)
        soma += n;
    return soma;
}

Console.WriteLine(Somar(1, 2, 3, 4, 5)); // 15

//Enumerações(enum)
enum DiaDaSemana
{
    Segunda,
    Terça,
    Quarta,
    Quinta,
    Sexta,
    Sabado,
    Domingo
}
DiaDaSemana hoje = DiaDaSemana.Quinta;
Console.WriteLine(hoje); // Quinta

// RECORDS
public record Pessoa(string Nome, int Idade);

var p1 = new Pessoa("Caio", 24);
var p2 = p1 with { Idade = 26};

Console.WriteLine(p1); // Pessoa {Nome = Caio, idade = 24}
Console.WriteLine(p2); // Pessoa {Nome = Caio, idade = 26}

// NAMESPACES E ASSEMBLIES
/*Namespace: Organização Lógica(como uma pasta virtual)
Assembly: Arquivo físico compilado (.dll ou  .exe)*/

namespace utilidades.Matematica
{
    public class calculos
    {
        public static int Dobrar(int n) => n * 2;
    }
}
using utilidades.Matematica;
Console.WriteLine(calculos.Dobrar(10));


// ARGUMENTOS DE LINHA DE COMANDO
/*dotnet run argumento1 argumento2*/
static void Main(string[] args)
{
    Console.WriteLine($"Primeira: {args[0]}");
    Console.WriteLine($"Segundo: {args{1}}");
}

// MANIPULAÇÃO DE ARQUIVOS(SYTEM.IO)
    // Criar Arquivo:
using System.IO;
File.WriteAllText("dados.txt", "Olá mundo");

    // Ler um arquivo:
string conteudo = File.ReadAllText("dados.txt");
Console.WriteLine(conteudo);

    // Adicionar Linhas:
File.AppendAllText("dados.txt", "\nNova linha adicionada");

    // Vericar existência:
if (file.Exists("dados.txt"));
    Console.WriteLine("Arquivo existe!");

// NULLABLE TYPES (VALORES NULOS EM TIPOS PRIMITIVOS)
/*Por padrão, int, bool, double não aceitam null
Mas é possível torná-los opcionais:*/
int? idade = null;

if (idade.HasValue)
    Console.WriteLine(idade.Value);
else 
    Console.WriteLine("Sem valor definido");

int idadeFinal = idade ?? 18; // usa 18 se for null

// TUPLAS  -- RETORNAR MÚLTIPLOS VALORES
(string nome, int idade) ObterPessoa1()
{
    return ("Caio", 25);
}

var pessoa = ObterPessoa1();
Console.WriteLine($"{pessoa.nome}, {pessoa.idade} anos");
/*Ideal para funções simples sem precisar criar uma classe só pra retorno*/


// ESCOPO DE VARIAVÉIS E LIFETIME
if (true)
{
    int numero = 5; // existe somente aqui
}
Console.WriteLine(numero); // ERRO
/*Mas objetos em heap (como new) vivem até o garbage Collector liberar*/

// GARBAGE COLLECTOR E USING
using (SteamWriter sw = new SteamWriter("log.txt"))
{
    sw.WriteLine("Gravando log...");
} // aqui o GC chama dispose() automaticamente -- Sem using, o arquivo ficaria "preso" na memória até o GC agir

// TIPOS DINÂMICOS (COM CAUTELA)
dynamic x = 10;
x = "texto";
Console.WriteLine(x);
/*Evite usar dynamic sem necessidade, pois perde a checagem de tiop em tempo de compilação - o que reduz segunrança e performance.*/


// TIPOS ANÔNIMOS
var pessoa2 = new { Nome = "Caio", Idade = 25 };
Console.WriteLine(pessoa2.Nome);


// EXPRESSÕES LAMBDA(PRÉVIA)
Func<int, int> dobrar = x => z * 2;
Console.WriteLine(dobrar(5)); // 10;


/*MINI PROJETO
Memória:
  Stack → valores simples
  Heap → objetos e strings

Tipos:
  Struct → valor
  Class → referência
  Enum → conjunto fixo
  Record → dados imutáveis

Métodos:
  static → da classe
  instance → do objeto
  ref/out/params → controle de parâmetros

Arquivos:
  System.IO → leitura e escrita

Segurança:
  Nullable, TryParse, using → boas práticas

*/


// --- FUNDAMENTOS AVANÇADOS PROGRAMAÇÃO ORIETADA A OBJETO ----

// CLASSES E OBJETOS
/*Uma classe é um molde, modelo, planta, blueprint

Ela descreve:
- Quais dados um objeto terá(atributo/propriedades
- Quais ações ele pode realizar (método/funções)
- Como ele deve se comportar

Exemplo de modelo mental:
Classe = planta de uma casa
Objeto = Casa construída baseada nessa planta

*/

/*O que é um objeto?
Objeto é criar instância de uma classe
Voce criar objeto com New.*/
Pessoa3 p = new Pessoa3();
// Aqui pessoa é a Classe, p é um objeto real na memória

// Estrutura completa de uma classe em C#
class Pessoa4
{
    //1. Atributos (dados internos)
    public string Nome;
    public int Idade;

    //2. Propriedades (forma moderna de expor dados)
    public string Email { get; set;}

    //3. Métodos (comportamentos)
    public void falar()
    {
        Console.WriteLine("Olá !");
    }
    //4. Construtor
    public Pessoa4(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
// atributos VS propriedades
// Atributos (campos)
//Usados para dadsos internos, raramente expostos publicamente
public int idade;

//propriedades - A forma moderna, segura e recomendada
public int Idade5 {get; set;}

// as propriedades podem ter lógica
private int _idade;
public int Idade
    {
        get => _idade;
        set
        {
            if(value < 0 throw new Exception("Idade inválida"));
            _idade = value;
        }
    }
// MÉTODOS - O COMPORTAMENTO DA CLASSE
public void Apresentar()
{
    console.WriteLine($"Meu nome é {Nome} e tenho {idade}")
}

// CONSTRUTORES
Pessoa p = new Pessoa("Caio", 25);

public Pessoa(string nome, int idade)
{
    nome = nome;
    idade = idade;
}
//Construtor sem parâmentros
public Pessoa() {}

// construtor com parâmetros opcionais;
public pessoa(string nome = "Sem nome"){ }

// Instanciando objetos
Pessoa pessoa = new Pessoa ("Ana", 21);
pessoa.Apresentar();

// Palavra-Chave this
// this se refere ao objeto atual
public Pessoa(string nome)
{
    this.Nome = nome;
}

// PROPRIEDADES


// ENCAPSULAMENTO

// HERANÇA

// POLIMORFISMO

// TIPOS ANÔNIMOS

// LINQ (INTRODUÇÃO)

// TRATAMENTO DE ERROS (CATCH/TRY/FINALLY)

// MINI PROJETO

// --- DELGATES, EVENTOS E EXPRESSÕES LAMBDA --- 

//  ---- PADRÕES MODERNOS

// INTERFACES - O CONTRATO ENTRE CLASSES

// ABSTRAÇÃO

// GENÉRICOS

//COLEÇÕES E LINQ AVANÇADA

// MANIPULAÇÃO DE ARQUIVOS

// MANIPULAÇÃO DE JSON (DADOS ESTRUTURADOS)

// ASSÍCRONO (ASYNC / AWAIT)

// PADRÃO MVC (MODEL - VIEW - CONTROLLER)

// INJEÇÃO DE DEPENDÊNCIA (DI)

// ARQUITETURA E BOAS PRATICAS

// TESTE UNITÁRIOS (INTRODUÇÃO)

// EXERCÍCIO PRÁTICA - MINI API SIMULADA (SEM SERVIDOR)


// ---- 2 - LINQ E PROGRAMAÇÃO FUNCIONAL ----- //

// O QUE É LINQ ?



// ASP.NET CORE (APIS E WEB APPS)

// .NET MAIU (DESKTOP E MOBILE)

// BANCO DE DADOS E ENTITY FRAMEWORK CORE

// SIGNALR

// BLAZOR

 










