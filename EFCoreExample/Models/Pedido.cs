using Microsoft.EntityFrameworkCore.Design;

namespace EFCoreExample.Models;

public class Pedido
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime Data { get; set; }
    public int ClienteId { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}