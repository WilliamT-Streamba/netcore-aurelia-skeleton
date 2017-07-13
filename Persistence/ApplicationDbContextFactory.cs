using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.AppDbContext;

namespace Persistence
{
    public class ApplicationDbContextFactory : IDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext Create()
        {
            return new ApplicationDbContext("server=localhost\\sqlexpress;Initial Catalog=ETransport;Integrated Security=True");
        }
    }
}
