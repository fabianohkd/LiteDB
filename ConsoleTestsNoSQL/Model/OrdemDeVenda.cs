using LiteDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestsNoSQL.Model
{
    public class OrdemDeVenda
    {
        public ObjectId Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Cliente Cliente { get; set; }
        public IList Products { get; set; }
    }
}
