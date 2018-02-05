using LiteDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestsNoSQL.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool IsActive { get; set; }

        [BsonRef("ordens")]
        public OrdemDeVenda Ordem { get; set; }
    }
}
