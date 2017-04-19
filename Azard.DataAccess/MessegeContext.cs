using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azard.DataAccess
{
    public class MessegeContext : DbContext
    {
        public DbSet<Message> Messeges { get; set; }
    }
}
