using Microsoft.EntityFrameworkCore;
using AppointmentServer.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppointmentServer.Infrastructure.Configurations
{
    internal sealed class AppUserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(k => new { k.UserId, k.RoleId });
        }
    }
}
