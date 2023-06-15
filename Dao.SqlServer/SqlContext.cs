using Microsoft.EntityFrameworkCore;
using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.SqlServer
{
    public class SqlContext : DbContext
    {

        //public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public SqlContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connetion = @"
            Data Source=localhost;Initial Catalog=Cliente01;User Id=sa;Password=estudos@2023;TrustServerCertificate=True";
           
        
                optionsBuilder.UseSqlServer(connetion); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutoCategoria>().HasKey(c => new { c.ProdutoId, c.CategoriaId });
        }

        public DbSet<Produtos> Produtos { get; set; } = null!;
        public DbSet<Categoria> Categorias { get; set; } = null!;

        public DbSet<Estoque> Estoques { get; set;} = null!;

        public DbSet<ProdutoCategoria> ProdutoCategorias { get; set; } = null!;
    }
}
