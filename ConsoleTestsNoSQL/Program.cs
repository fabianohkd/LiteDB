using ConsoleTestsNoSQL.Model;
using LiteDB;
using System;

namespace ConsoleTestsNoSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abrir banco de dados (ou cria se não existir)
            using (var db = new LiteDatabase(@"nosql.db"))
            {
                // Obter coleção do cliente
                var clientes = db.GetCollection<Cliente>("clientes");

                // Crie sua nova instância de cliente
                var cliente = new Cliente
                {
                    Nome = "Mikaela de Morais",
                    IsActive = true
                };

                // Inserir novo documento do cliente (Id será auto-incrementado)
                clientes.Insert(cliente);

                // Atualize um documento dentro de uma coleção
                cliente.Nome = "Mika";

                // Indice usando uma propriedade de documento
                clientes.EnsureIndex(x => x.Nome);

                // Use Linq para consultar documentos
                var results = clientes.Find(x => x.Nome.StartsWith("Jo"));


                var ordens = db.GetCollection<OrdemDeVenda>("ordens");
                var ov = new OrdemDeVenda() { OrderDate = DateTime.Now, Cliente = cliente };
                ordens.Insert(ov);


                cliente.Ordem = ov;

                clientes.Update(cliente);
            }
        }


    }
}
