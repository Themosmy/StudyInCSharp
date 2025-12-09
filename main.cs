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
public class pessoa
{
    public string Nome { get; set; } // Leitura e escrita pública
    public int Idade { get; private set;} // Só leitura pública; escrita só detnro da classe

    // Property com backing field para validação
    private decimal _salario;
    public decimal _salario
    {
        get => _salario;
        set
        {
            if(value < 0) throw new ArgumentException("Salário não pode ser negativo");
            _salario = value;
        }
    }

    // Propriedade computada 
    public bool EhAdulto => Idade >= 18; // Expression - bodied

    // Init-Only (C# 9+): permite set apenas ao inicializar o objeto
    public string CPF { get; init; }

    // Exemplo de notificação de mudança (simplificado)
    private string _email;
    public string Email
    {
        get => _email;
        set
        {
            if(_email != value)
            {
                _email = value;
                OnEmailChanged();
            }
        }

    }
    protected void OnEmailChanged(){ /*Dispara evento ou INotifyPropertyChanged*/}

}
/*Boas práticas:

Use auto-properties quando não precisar de lógica no setter/getter.

Use backing field quando precisar validação, lazy init ou lógica.

Prefira private set / init para imutabilidade parcial.

Para UIs (WPF, Xamarin, MAUI) implemente INotifyPropertyChanged para bindings.

Como praticar:

Reescreva classes que usam campos públicos para usar propriedades com validação.

Construa um ViewModel simples que notifique mudanças e ligue a uma UI fake (console ou WPF).*/



// ENCAPSULAMENTO
/*Encapsulamento é a ideia de ocultar detalhes internos e expor uma interface mínima, controlando 
acesso e mantendo invariantes do objeto. Em C#, isso é feito com modificadores de acesso 
(private, protected, internal, public), propriedades e métodos.

Principais pontos:

- Campos privados e propriedades públicas protegem o estado.
- Forneça métodos para operações que preservam invariantes (em vez de permitir alterações diretas).
- Use readonly/const para dados imutáveis.
- internal controla visibilidade dentro do assembly.*/

public class ContaBancaria
{
    private decimal _saldo; // campo encapsulado

    public decimal saldo => _saldo; // Leitura apenas

    public void Depositar(decimal valor)
    {
        if(valor <= 0) throw new ArgumentException("Valor Inválido");
        _saldo += valor;
    }

    public bool Sacar(decimal valor)
    {
        if(valor <= 0 ) return false;
        if(valor > _saldo) return false;
        _saldo -= valor;
        return true;
    }
}
 /*Armadilhas comuns:

Expor coleções internas diretamente (ex.: public List<T> Items) — prefere IReadOnlyList<T> ou retornar uma cópia/AsReadOnly().

Tornar tudo public demais — reduz encapsulamento.

Como praticar:

Pegue uma classe com muitos campos/variáveis públicas e transforme em uma API encapsulada com métodos claros e testes de unidade que validem invariantes.*/


// HERANÇA
/*Herança permite que uma classe (subclasse/derived) reutilize e especialize comportamento de outra (base). Em C#: class Filho : Pai.

Conceitos principais:

virtual em membro da base permite override.

override na subclasse altera comportamento.

sealed impede herdabilidade de uma classe ou override de um método.

abstract define membros/métodos que devem ser implementados nas subclasses.

Construtores: chamamos base(...) para inicializar a parte base.

Exemplo simples:*/

public abstract class Animal
{
    public string Nome { get; set; }
    public Animal(string nome) => Nome = nome;

    public virtual string EmitirSom() => "..."; // Comportamento padrão (Override Opcional)
    public abstract void Comer();
}

public class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome) { }
    
    public override string EmitirSom() => "Au Au";
    public override void Comer() => Console.WriteLine($"{Nome} come ração");
}
public sealed class PastorAlemao: Cachorro
{
    public PastorAlemao(string nome) : base(nome) { }
}
/*Quando usar:

Use herança quando existir uma relação “é um” clara e quando deseja compartilhar implementação.

Se só precisa compartilhar contratos, prefira interfaces (ou composição) em vez de herança múltipla (C# não permite herança múltipla de classes).

Armadilhas:

Herança excessiva leva a hierarquias complicadas e fracas a mudanças (fragile base class problem).

Preferir composição quando possível (has-a) — "composição sobre herança".

Como praticar:

Modele hierarquias simples (Veículo → Carro, Moto) e depois refatore para usar composição se notar duplicação.*/

/* POLIMORFISMO
Polimorfismo = “muitas formas”. Em C# há duas formas principais:

Polimorfismo em tempo de compilação (overloading / generics)

Method overloading: mesmo nome, assinaturas diferentes.

Polimorfismo em tempo de execução (overriding)

Usando virtual / override e chamando via referência de base para executar a implementação da subclasse.*/

//Overloading(compile-time)
public class calculadora
{
    public int Soma(int a, int b) => a + b;
    public double Soma(double a, double b) => a + b;
}

//Runtime Polymorphism
public abstract class Forma
{
    public abstract double Area();
}

public class Retangulo : Forma
{
    public double Largura { get; set;}
    public double Altura { get; set;}
    public override double Are() => Largura * Altura;
}

public class Circulo : Forma
{
    public double Raio { get; set; }
    public override double Area() => Math.PI * Raio * Raio;
}

Forma f1 = new Retangulo { Largura = 2, Altura = 3 };
Forma f2 = new Circulo {Raio = 1 };
Console.WriteLine(f1.Area()); // 6 -> Chama Rentangulo.Area()
Console.WriteLine(f2.Area()); // π -> chama Circulo.Area()

/*Outros pontos:

Interfaces também suportam polimorfismo: você pode ter IRepositorio com múltiplas implementações.

Covariância/Contravariância em genéricos permite certo polimorfismo em tipos genéricos (IEnumerable<Derived> → IEnumerable<Base> é covariante).

Armadilhas:

Misturar new (esconder método) com override pode confundir — new oculta membro da base, não substitui em tempo de execução.

Lembre de marcar virtual na base se quiser permitir override.

Como praticar:

Faça um conjunto de formas (círculo, quadrado, triângulo) e processe-os via uma coleção de Forma chamando Area() — observe o dispatch dinâmico.*/

// TIPOS ANÔNIMOS

/*Tipos anônimos em C# são úteis para criar objetos com propriedades nomeadas sem declarar uma classe. 
São imutáveis (propriedades somente leitura), tipados anonimamente e normalmente usados com var e com LINQ.

Sintaxe: */

var anon = new { Nome = "Caio", Idade = 30 };
Console.WriteLine(anon.Nome); // "Caio"
// anon.Nome = "outro"; // Erro: propriedade eé get-Only

// Com LINQ

var pessoas = new[]
{
    new { Nome = "Ana", Idade = 25, Cidade = "SP"},
    new { NOme = "Beto", Idade = 30, Cidade = "RJ"}
};

var projeccao = pessoas.Select(p => new {p.Nome, AnoNascimento = DataTime.Now.Year - p.Idade });

foreach(var x in projeccao)
    Console.WriteLine($"{x.Nome} nasceu em {x.AnoNascimento}");

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
 










