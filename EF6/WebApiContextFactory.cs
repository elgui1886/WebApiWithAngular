using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6
{
    public class WebApiContextFactory : IDbContextFactory<WebApiContext>
    {
        public WebApiContext Create()
        {
            return new EF6.WebApiContext("Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        }
    }
}
