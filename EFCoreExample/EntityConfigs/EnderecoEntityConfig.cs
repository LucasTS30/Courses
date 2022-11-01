namespace EFCoreExample.EntityConfigs;

using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EnderecoEntityConfig : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.ToTable("enderecos");

        builder.Property(e => e.Id)
            .HasColumnName("id")
            .HasColumnType("int");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Estado)
            .HasColumnName("estado")
            .HasColumnType("nvarchar(2)")
            .IsRequired();

        builder.Property(e => e.Cidade)
            .HasColumnName("cidade")
            .HasColumnType("nvarchar(100)")
            .IsRequired();

        builder.Property(e => e.Bairro)
            .HasColumnName("bairro")
            .HasColumnType("nvarchar(100)")
            .IsRequired();

        builder.Property(e => e.Logradouro)
            .HasColumnName("logradouro")
            .HasColumnType("nvarchar(max)")
            .IsRequired();
        
        builder.Property(e => e.Numero)
            .HasColumnName("numero")
            .HasColumnType("nvarchar(10)")
            .IsRequired();

        builder.HasOne<Cliente>()
            .WithOne(cliente => cliente.Endereco)
            .HasForeignKey<Endereco>(endereco => endereco.ClienteId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}