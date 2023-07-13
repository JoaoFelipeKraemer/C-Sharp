public class Account
{
    public decimal _balance;

    public Client Owner { get; set; }
    public decimal Balance
    {
        get => _balance;
        private set
        {
            if (value < 0)
                throw new ArgumentException("Balance can't be negative!");
            _balance = value;
        }
    }

    public Account(Client owner)
    {
        Owner = owner;
    }

    public virtual void Deposit(decimal amount) => Balance += amount;
    public void Withdraw(decimal amount) => Balance -= amount;
}

public class DigitalAccount : Account
{
    public OperatingSystem AccountCreationOS { get; }
    public DateTime AccountCreationDate { get; } = DateTime.Now;

    public DigitalAccount(Client owner, OperatingSystem OS) : base(owner)
    {
        AccountCreationOS = OS;
    }
    // Quando há a necessidade de modificar a implementação de algum método ou
    //  propriedade herdada de outra classe, podemos utilizar o modificador override
    public override void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"New balance is {Balance}");
    }
}

// Nesse caso, é importante destacar que, além de definir a relação de herança
//  DigitalAccount : Account
//   nós também definimos no construtor uma chamada com a palavra-chave base. 
//   Essa palavra-chave é utilizada para passar ao construtor da superclasse
//    o parâmetro recebido no construtor da subclasse.


// Entretanto, o override só funciona caso o membro sobrescrito da superclasse 
// seja definido como abstract ou virtual através de um modificador próprio, veja em detalhes:

// abstract: modificador que define uma classe ou membro como abstrato.

// Apenas classes abstratas podem ter métodos abstratos.
// Métodos abstratos não possuem implementação e devem sempre ser sobrescritos.
// virtual: modificador que define um membro como virtual.

// Classes não podem receber o modificador virtual.
// Métodos virtuais possuem implementação, que pode ou não ser sobrescrita nas classes derivadas.
