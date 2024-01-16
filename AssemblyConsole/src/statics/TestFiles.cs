using System.IO;
using AssemblyConsole.Entities;

namespace AssemblyConsole.src;
public class TestFiles
{
    public static void Master()
    {
        System.Console.Write("Digite o caminho do arquivo: ");
        string sourcepath = Console.ReadLine();

        try{
            string[] lines = File.ReadAllLines(sourcepath); //Transforma todas as linhas num Array com conteúdo de cada linha
            string targetpath = Path.GetDirectoryName(sourcepath) + @"\out"; //Pega o Diretório e armazena mais subpasta numa variável
            string targetFilePath = targetpath + @"\sumary.csv"; //Armazena local do arquivo

            //Crio diretório novo
            Directory.CreateDirectory(targetpath);
            using(StreamWriter sw = File.AppendText(targetFilePath)) //Utiliza StreamWriter para escrever no arquivo de saída
            {
                foreach(string line in lines)
                {
                    string[] arrayLine = line.Split(','); //Separo o contéudo da linha num outro Array
                    string name = arrayLine[0];
                    double price = double.Parse(arrayLine[1]);
                    int quantidade = int.Parse(arrayLine[2]);
                
                    Product p = new(name,price,quantidade); //Instancio a classe de Produto
                    sw.WriteLine(p.NameProduct + ", R$" + p.Quantidade * p.PriceProduct);
                }
            }
        }catch (IOException e)
        {
            Console.WriteLine("Ocorreu um erro de Exceção durante a manipulação de arquivos");
            Console.WriteLine(e.Message);

        }catch(Exception e)
        {
            Console.WriteLine("Ocorreu um erro de Exceção da Aplicação:");
            System.Console.WriteLine(e.Message);
        }
    }
}
