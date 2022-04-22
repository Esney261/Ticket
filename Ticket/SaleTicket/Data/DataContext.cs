using Microsoft.EntityFrameworkCore;
using SaleTicket.Data.Entities;

namespace SaleTicket.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Entrance> Entrances { get; set; }
    }
}
