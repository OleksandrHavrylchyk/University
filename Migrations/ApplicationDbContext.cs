using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using University.Migrations.EntityConfigurations;
using University.Models;

namespace University.Migrations
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
        public DbSet<UserDtoModel> UserListView { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDtoModel>((userList =>
            {
                userList.HasNoKey();
                userList.ToView("DashboardUserList_View");
            }));
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new CoursesConfiguration());
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
        }
    }
}
