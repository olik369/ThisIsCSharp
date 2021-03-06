using static System.Console;

class Employee
{

    private string Name;
    private string Position;

    public void SetName(string Name)
    {
        this.Name = Name;
    }

    public string GetName()
    {
        return this.Name;
    }

    public void SetPosition(string Position)
    {
        this.Position = Position;
    }

    public string GetPosition()
    {
        return this.Position;
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        Employee pooh = new Employee();
        pooh.SetName("Pooh");
        pooh.SetPosition("Waiter");
        WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

        Employee tigger = new Employee();
        tigger.SetName("Tigger");
        tigger.SetPosition("Cleaner");
        WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
    }
}