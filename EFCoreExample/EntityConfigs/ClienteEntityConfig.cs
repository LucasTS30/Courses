using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreExample.EntityConfigs;

public class ClienteEntityConfig : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("clientes");

        builder.Property(cliente => cliente.Id)
            .HasColumnName("id")
            .HasColumnType("int");

        builder.HasKey(cliente => cliente.Id);

        builder.Property(cliente => cliente.Nome)
            .IsRequired()
            .HasColumnName("nome")
            .HasColumnType("nvarchar(100)");

        builder.Property(cliente => cliente.Cpf)
            .IsRequired()
            .HasColumnName("cpf")
            .HasColumnType("nvarchar(15)");
    }
}