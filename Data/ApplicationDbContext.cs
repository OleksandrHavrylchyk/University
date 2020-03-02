using University.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace University.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUserEntity>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<CourseEntity> Courses { get; set; }

        public DbSet<CourseSubscribersEntity> CourseSubscribers { get; set; }

    }
}
