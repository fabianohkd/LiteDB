using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestsNoSQL.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
    }
}
