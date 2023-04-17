using Microsoft.EntityFrameworkCore;

namespace REST_API.Models
{
    public class ReservationContext : DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options) : base(options)
        {
        }
        public DbSet<Reservations> Reservations { get; set; }
    }
}
