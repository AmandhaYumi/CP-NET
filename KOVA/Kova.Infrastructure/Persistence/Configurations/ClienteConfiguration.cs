using Kova.Domain.Entities;

using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
 
namespace Kova.Infrastructure.Persistence.Configurations;
 
public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>

{

    public void Configure(EntityTypeBuilder<Cliente> builder)

    {

        builder.ToTable("Clientes");
 
        builder.HasKey(x => x.Id);
 
        builder.Property(x => x.Nome)

            .IsRequired()

            .HasMaxLength(100);
 
        builder.Property(x => x.Email)

            .IsRequired()

            .HasMaxLength(150);
 
        builder.HasIndex(x => x.Email)

            .IsUnique();
 
        builder.Property(x => x.Telefone)

            .IsRequired()

            .HasMaxLength(11);
 
        builder.Property(x => x.CreatedAt)

            .IsRequired();
 
        builder.Property(x => x.Active)

            .IsRequired();
 
        builder.HasMany(x => x.Pedidos)

            .WithOne(x => x.Cliente)

            .HasForeignKey(x => x.ClienteId)

            .OnDelete(DeleteBehavior.Restrict);

    }

}