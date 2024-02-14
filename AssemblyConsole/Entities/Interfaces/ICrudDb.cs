using Microsoft.Data.SqlClient;

namespace AssemblyConsole.Entities.Interfaces;
public interface ICrudDb
{
    public void CreateCategory(SqlConnection connection);
    public void UpdateCategory(SqlConnection connection);
    public void ReadCategory(SqlConnection connection);
    public void DeleteCategory(SqlConnection connection);

}
