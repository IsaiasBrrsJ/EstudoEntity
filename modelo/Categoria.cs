using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Categoria
    {
        public Categoria()
        {
            CategoriaProduto = new HashSet<ProdutoCategoria>();
        }
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public virtual ICollection<ProdutoCategoria> ? CategoriaProduto { get; set; }
    }
}
