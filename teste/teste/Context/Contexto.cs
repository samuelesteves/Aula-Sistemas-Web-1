using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace teste.Context
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DBteste")
        {

        }
        
        public DbSet<AlunoModel> Aluno { get; set; }
    }
}