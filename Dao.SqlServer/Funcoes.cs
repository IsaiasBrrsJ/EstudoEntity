using Microsoft.EntityFrameworkCore;
using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.SqlServer
{
    public static class Funcoes
    {
       
        public static bool Update(Produtos P )
        {
            using (SqlContext ctx = new SqlContext())
            {
                
                if(P != null)
                {
 
                    ctx.Entry(P).State = EntityState.Modified;
                    ctx.SaveChanges();

                    return true;
                    
                }

                return false;
            }
        }

        public static bool Delete(Produtos P )
        {
            using(SqlContext ctx = new SqlContext())
            {
                if(P is not null)
                {
                    ctx.Entry(P).State = EntityState.Deleted;
                    ctx.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }
}
