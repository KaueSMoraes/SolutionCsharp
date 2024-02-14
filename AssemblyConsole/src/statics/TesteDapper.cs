using AssemblyConsole.Entities.Interfaces;
using Microsoft.Data.SqlClient;
using AssemblyConsole.Entities.Models;
using Dapper;
using System.Data.Common;

namespace AssemblyConsole.src.statics;

//Classe de teste manipulando dados com Dapper. Um Mirco-ORM
public class TesteDapper : ICrudDb
{
    public static void Master()
    {
       const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$; TrustServerCertificate=True";
       var TesteDapper = new TesteDapper();

        try{
            using(var connection = new SqlConnection(connectionString))
            {
                TesteDapper.CreateCategory(connection);
                TesteDapper.UpdateCategory(connection);
                TesteDapper.ReadCategory(connection);
                TesteDapper.DeleteCategory(connection);      
            }
        }catch(Exception e){
            Console.WriteLine("Ocorreu um erro no CRUD, sugiro verificar" + e.Message);
        }    
    }

    public void CreateCategory(SqlConnection connection)
    {
        var category = new Category("Amazon AWS", "amazon", "Categoria destinada a serviços do AWS", 8, "AWS Cloud", false);
        var insertsql = @"INSERT INTO  [Category] VALUES( @Id, @Title, @Url, @Summary, @Order, @Description, @Featured ) "; //Metodologia para evitar SQL Injection
        var rows = connection.Execute(insertsql, category);

        Console.WriteLine(rows + " linhas inseridas");
        Console.WriteLine();
    }
    public void UpdateCategory(SqlConnection connection)
    {
        var updatequery = "UPDATE [Category] SET [Title] = @Title WHERE [Id]= @id";
        var rows = connection.Execute(updatequery, new {   //Criando um objeto anônimo
            id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
            title = "Frontend 2021"
        });
        Console.WriteLine(rows + " Linhas Atualizadas");
        Console.WriteLine();
    }
    public void ReadCategory(SqlConnection connection)
    {
        var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [CATEGORY]"); //Retorna uma collection
        Console.WriteLine("LISTA DE RETORNO DAS CATEGORIAS");
        foreach(var c in categories){
            Console.WriteLine("ID: " + c.Id +  "  Title: " + c.Title);
        }
    }
    public void DeleteCategory(SqlConnection connection)
    {
        var deleteCategory ="DELETE [Category] WHERE [Id]=@id";
        var rows = connection.Execute(deleteCategory, new{
            id = new Guid("befec97e-5d4d-4132-9752-81b30f9086f3"),
        }); 
        Console.WriteLine(rows + " Registros excluídos");
    }
}
