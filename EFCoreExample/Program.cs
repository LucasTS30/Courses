using System.Reflection.Metadata;
using EFCoreExample.Contexts;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

var db = new AppDbContext();

//INSERCAO
// var cliente = new Cliente
// {
//     Nome = "Lucas Tavares",
//     Cpf = "123.456.789-12"
// };
// db.Add(cliente);
// //db.AddRange(cliente1, cliente2)
// db.SaveChanges();

//LEITURA
// foreach (var cliente in db.Clientes)
// {
//     Console.WriteLine(cliente);
// }
// var cliente = db.Clientes.Find(1);
// Console.WriteLine(cliente);
//var cliente = db.Clientes.Where(c => c.Nome.Contains("Lucas")).Select(c => c.Nome).SingleOrDefault();
//Console.WriteLine(cliente);

//EDIÇÃO
// var cliente = db.Clientes.Find(1);
// cliente.Cpf = "987.654.321-21";
// db.SaveChanges();
// var cliente = new Cliente
// {
//     Id = 1,
//     Nome = "Lucas Tavares de Souza",
//     Cpf = "987.654.321-21"
// };
// db.Update(cliente); //ou db.Entry(cliente).State = EntityState.Modified;
// db.SaveChanges();

//EXCLUSÃO
// var cliente = db.Clientes.First(); //ou var cliente = new Cliente { Id = 1};
// db.Remove(cliente); //ou db.RemoveRange(cliente1, cliente2);
// db.SaveChanges();

//CADASTRO ENTIDADE RELACIONAMENTO 1:1
// var endereco = new Endereco
// {
//     Estado = "SC",
//     Cidade = "Florianópolis",
//     Bairro = "Córrego Grande",
//     Logradouro = "Rua Teste",
//     Numero = "1",
//     ClienteId = 3
// };
// db.Add(endereco);
// db.SaveChanges();
// //ou
// var cliente = new Cliente{
//     Nome = "Viviam Josviack",
//     Cpf = "234.345.456-78",
//     Endereco = new Endereco
//     {
//         Estado = "SC",
//         Cidade = "Florianópolis",
//         Bairro = "Córrego Grande",
//         Logradouro = "Rua Teste",
//         Numero = "1"
//     }
// };
// db.Add(cliente);
// db.SaveChanges();

//CADASTRO ENTIDADE RELACIONAMENTO 1:N
// var cliente = db.Clientes.First();
// cliente.Pedidos.Add(new Pedido
// {
//     Descricao = "Meu primeiro pedido",
//     Data = DateTime.Now
// });
// cliente.Pedidos.Add(new Pedido
// {
//     Descricao = "Meu segundo pedido",
//     Data = DateTime.Now
// });
// db.SaveChanges();
// //ou
// var pedido = new Pedido
// {
//     Descricao = "Meu primeiro pedido",
//     Data = DateTime.Now,
//     ClienteId = 4
// };
// db.Add(pedido);
// db.SaveChanges();
// //ou
// var cliente = db.Clientes.First();
// var pedido = new Pedido
// {
//     Descricao = "Meu terceiro pedido",
//     Data = DateTime.Now,
//     Cliente = cliente
// };
// db.Add(pedido);
// db.SaveChanges();

// var produto1 = new Produto
// {
//     Nome = "Notebook",
//     Valor = 3000
// };

// var produto2 = new Produto
// {
//     Nome = "PC Gamer",
//     Valor = 5000
// };

// var produto3 = new Produto
// {
//     Nome = "Cadeira Gamer",
//     Valor = 1500
// };

// db.AddRange(produto1, produto2, produto3);
// db.SaveChanges();

//CADATRO ENTIDADE N:N
var produto1 = db.Produtos.Find(1);
var produto2 = db.Produtos.Find(2);
var pedido = db.Pedidos.First();

pedido.Produtos.Add(produto1);
pedido.Produtos.Add(produto2);
db.SaveChanges();