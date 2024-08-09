using Microsoft.EntityFrameworkCore;
namespace CMPG323_PROJECT2_39990966.Models
{
    public class TelementryDbContext: DbContext
    {
        public TelementryDbContext(DbContextOptions<TelementryDbContext> options):base(options)
        {
            
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; };
    }
}
