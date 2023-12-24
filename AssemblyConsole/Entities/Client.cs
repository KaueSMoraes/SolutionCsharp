using System.Security.Cryptography.X509Certificates;

namespace AssemblyConsole.Entities;

public class Client
{
    public string Name { get; set; }
    public string Email {get; private set;}
    public DateTime BirthDate { get; private set; }

    public Client(string name, string email, DateTime birthdate)
    {
        Name = name;
        Email = email;
        BirthDate = birthdate;
    }
    public override string ToString()
    {
        return "Client: " + Name + "(" + BirthDate + ")" +
        " - " + Email;
    }
}
