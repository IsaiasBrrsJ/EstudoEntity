using Dao.SqlServer;
using modelo;
using System.Data.SqlTypes;

namespace EEFEstudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Dao.MYSQL.Class1 msql = new Dao.MYSQL.Class1();
          Dao.SqlServer.Class1 msql2 = new Dao.SqlServer.Class1();
         Produtos p = new Produtos();
            p.Id = 1;
            p.Nome = "Teste";
            p.Cor = "BlueHat";

            Funcoes.Update(p);

          using(SqlContext ctx = new SqlContext())
          {
            ctx.Produtos.ToList().ForEach(Console.WriteLine);
          }

            Console.Read();
        }
    }
}