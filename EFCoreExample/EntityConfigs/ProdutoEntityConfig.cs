using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreExample.EntityConfigs;
public class ProdutoEntityConfig : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("produtos");

        builder.Property(p => p.Id)
            .HasColumnName("id");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nome)
            .HasColumnName("descricao")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(p => p.Valor)
            .HasColumnName("valor")
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.HasMany(p => p.Pedidos)
            .WithMany(p => p.Produtos);
    }
}