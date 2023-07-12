namespace Program;

class Rocket
{
    public string Name { get; set; }
    public Foguete(string nome)
    {
        Name = nome;
    }
}

var rocket1 = new Rocket();
var rocket2 = rocket1;

// rocket1.Name = "Apollo 11";
// rocket2.Name = "Falcon 9";

// Console.WriteLine(rocket1.Name);
// # Falcon 9

// Note que, no código acima, ao fazer a atribuição var rocket2 = rocket1;, apenas copiamos
//  para rocket2 a referência à instância de foguete criada na atribuição da variável rocket1.
//  Assim, não temos dois foguetes diferentes, mas uma mesma instância de foguete sendo referida
//  por duas variáveis diferentes!

// Entretanto, o mesmo não acontece com tipos de valor, como é o caso dos números inteiros:

var number1 = 1;
var number2 = number1;

// number2 = 2;

// Console.WriteLine(number1);
// # 1

// Isso ocorre porque, diferente das variáveis de reference type, as variáveis de value type
//  salvam a própria informação na variável, então na atribuição var number2 = number1;
//   copiamos o próprio valor do número salvo em number1 para a variável number2, de modo
//    que alterações subsequentes não irão se refletir na variável original.
// -------------------------------------------------
// Utilizando construtores
// Construtores são métodos chamados toda vez que uma instância de uma classe 
// é criada, ou seja, mesmo que não tenhamos definido um construtor customizado 
// para determinada Classe, ela terá um construtor padrão, o qual não aceitará 
// nenhum parâmetro nem definirá nenhuma propriedade.


// Porém talvez se queira receber parametros e definir propriedades entao precisamos
// definir um método construtor para isso

//  A palavra-chave public que precede o construtor é necessária caso você queira criar uma instância da 
//  classe a partir de outro lugar que não seja a própria classe.

// Nos casos em que for necessário (ou conveniente) estabelecer o mesmo
//  nome para um campo da classe e para um parâmetro recebido pelo construtor,
//  utilizando-os sem que isso gere ambiguidade, podemos usar o operador this:


class Rocket
{
    string nome;

    public Foguete(string nome)
    {
        this.nome = nome;
        // ou   _nome = nome;
    }
}

