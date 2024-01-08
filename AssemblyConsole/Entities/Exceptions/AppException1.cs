namespace AssemblyConsole.Entities.Exceptions;

public class AppException1 : ApplicationException
{

    //Construindo Exception que no construtor (Throw) dela, seja passado uma string como argumento.
    //Pois o construtor da Superclasse só recebe uma string como argumento.
    public AppException1(string message) :base(message)
    {
    }
}
