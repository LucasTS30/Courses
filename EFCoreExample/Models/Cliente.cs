namespace EFCoreExample.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;

    public virtual Endereco Endereco { get; set; } = null!;
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public override string ToString()
    {
        return $"{Id}. {Nome} - {Cpf}";
    }
}