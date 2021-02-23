using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.IU.Web.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<DbContext> options) :
            base(options)
        {
        }
    }
}
