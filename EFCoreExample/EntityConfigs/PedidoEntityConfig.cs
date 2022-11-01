using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PedidoEntityConfig : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        builder.ToTable("pedidos");

        builder.Property(p => p.Id)
            .HasColumnName("id");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Descricao)
            .HasColumnName("descricao")
            .HasColumnType("varchar(max)")
            .IsRequired();
        
        builder.Property(p => p.Data)
            .HasColumnName("data")
            .HasColumnType("datetime2")
            .IsRequired();

        builder.HasOne(p => p.Cliente)
            .WithMany(p => p.Pedidos)
            .HasForeignKey(p => p.ClienteId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}