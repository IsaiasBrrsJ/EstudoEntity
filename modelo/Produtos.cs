using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Produtos
    {

        public Produtos()
        {
            ProdutoCategoria = new HashSet<ProdutoCategoria>();
        }
        public int Id { get; set; } 

        public string Nome { get;set; } = string.Empty; 

        public string Cor { get;set;} = string.Empty;

        public virtual Estoque ? Estoque { get; set; } 

        public virtual ICollection<ProdutoCategoria> ? ProdutoCategoria { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}\nNome: {Nome}\nCor: {Cor}";
        }
    }
}
