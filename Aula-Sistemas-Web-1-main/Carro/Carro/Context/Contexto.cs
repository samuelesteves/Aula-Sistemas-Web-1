using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Carro.Models;

namespace Carro.Context
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DBcarro")
        {

        }

        public DbSet<CarroModel> Carro { get; set; }
    }
}