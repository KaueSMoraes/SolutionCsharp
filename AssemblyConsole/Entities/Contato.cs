using AssemblyConsole.Entities.Interfaces;

namespace AssemblyConsole.Entities;

public class Contato : IContato
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Phone { get; set; }

    public Contato(string name, string email, int phone)
    {
        Name = name;
        Email = email;
        Phone = phone;
    }
}
