class Car
{
    public double TopSpeed { get; set; }
    public bool IsAutomatic { get; set; }
    public int NumberOfSeats { get; set; }

    public int EngineHorsepower { get; set; }
    public int EngineTorque { get; set; }
    public int EngineCapacity { get; set; }
    public bool IsEngineStarted { get; set; }

    public void Drive(double distanceKm, double speed)
    {
        if (speed > TopSpeed)
            Console.WriteLine("Your car can't go that fast!");
        else if (!IsEngineStarted)
            Console.WriteLine("Your car isn't turned on!");
        else
        {
            var time = distanceKm / speed;
            Console.WriteLine($"You arrived in {time} hours.");
        }
    }

    public void StartEngine()
    {
        if (IsEngineStarted)
            Console.WriteLine("The engine is already started!");
        else
            IsEngineStarted = true;
    }

    public void StopEngine()
    {
        if (!IsEngineStarted)
            Console.WriteLine("The engine is already stopped!");
        else
            IsEngineStarted = false;
    }
}

// a primeira coisa a fazer é separar a lógica referente ao motor em uma classe específica chamada Engine:



class Engine
{
    public int Horsepower { get; set; }
    public int Torque { get; set; }
    public int Capacity { get; set; }
    public bool IsStarted { get; set; }

    public void Start()
    {
        if (IsStarted)
            Console.WriteLine("The engine is already started!");
        else
            IsStarted = true;
    }

    public void Stop()
    {
        if (!IsStarted)
            Console.WriteLine("The engine is already stopped!");
        else
            IsStarted = false;
    }
}

// refatorar a classe Car para utilizar Engine através da COMPOSIÇÃO
class Car
{
    public double TopSpeed { get; set; }
    public bool IsAutomatic { get; set; }
    public int NumberOfSeats { get; set; }
    public Engine Engine { get; set; } = new Engine();

    public void Drive(double distanceKm, double speed)
    {
        if (speed > TopSpeed)
            Console.WriteLine("Your car can't go that fast!");
        else if (!Engine.IsStarted)
            Console.WriteLine("Your car isn't turned on!");
        else
        {
            var time = distanceKm / speed;
            Console.WriteLine($"You arrived in {time} hours.");
        }
    }

    public void StartEngine() => Engine.Start();

    public void StopEngine() => Engine.Stop();
}

// AGORA PODEMOS UTILIZAR A ENGINE PARA TB CRIAR MOTORCYCE OU AINDA SHIP OU AIRPLANE


class Motorcycle
{
    public double TopSpeed { get; set; }
    public bool CanDoWheelies { get; set; }
    public Engine Engine { get; set; } = new Engine();

    public void Drive(double distanceKm, double speed)
    {
        if (speed > TopSpeed)
            Console.WriteLine("Your bike can't go that fast!");
        else if (!Engine.IsStarted)
            Console.WriteLine("Your bike isn't turned on!");
        else
        {
            var time = distanceKm / speed;
            Console.WriteLine($"You arrived in {time} hours.");
        }
    }

    public void DoWheelie()
    {
        if (!CanDoWheelies)
            Console.WriteLine("Your bike can't do wheelies!");
        else if (!Engine.IsStarted)
            Console.WriteLine("Your bike isn't turned on!");
        else
            Console.WriteLine("Your bike is doing a wheelie!");
    }

    public void StartEngine() => Engine.Start();

    public void StopEngine() => Engine.Stop();
}