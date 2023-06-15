using modelo;

namespace Dao.SqlServer
{
    public class Class1
    {
        public Class1()
        {
            Console.WriteLine("Camdada 2- sqlServer");        
            
           
                Produtos prod = new Produtos();
                prod.Id = 2;
                prod.Nome = "Shoe";
                prod.Cor = "RedHat";



            Console.WriteLine("-------\n" + Funcoes.Update(prod) + "\n---------------");
            
        }
    }
}