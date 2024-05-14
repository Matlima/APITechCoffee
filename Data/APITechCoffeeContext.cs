using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APITechCoffee.Models.CRM;
using APITechCoffee.Models.Jobs;
using APITechCoffee.Models.Geral;

namespace APITechCoffee.Data
{
    public class APITechCoffeeContext : DbContext
    {
        public APITechCoffeeContext (DbContextOptions<APITechCoffeeContext> options)
            : base(options)
        {
        }
        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<Projeto>? Projeto { get; set; }
        public DbSet<Servico>? Servico { get; set; }
        public DbSet<ItemProjetoServico>? ItemProjetoServico { get; set; }
        public DbSet<Atividade>? Atividade { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        

       
    }
}
