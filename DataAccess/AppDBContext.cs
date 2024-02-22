using Microsoft.EntityFrameworkCore;
using Models.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppDBContext: DbContext
    {
        public AppDBContext( DbContextOptions<AppDBContext> options): base(options) { }

        public virtual DbSet<Censo>? censo { get; set; }
    }
}
