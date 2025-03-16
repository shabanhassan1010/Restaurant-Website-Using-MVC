using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVC_PROJECT.Data
{
    public class ResturantDBContext : IdentityDbContext
    {
        public ResturantDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
