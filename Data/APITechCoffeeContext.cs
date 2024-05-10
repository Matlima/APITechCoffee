using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APITechCoffee.Models;
using APITechCoffee.Model;

namespace APITechCoffee.Data
{
    public class APITechCoffeeContext : DbContext
    {
        public APITechCoffeeContext (DbContextOptions<APITechCoffeeContext> options)
            : base(options)
        {
        }
        public DbSet<APITechCoffee.Models.Usuario>? Usuario { get; set; }
        public DbSet<APITechCoffee.Models.Projeto>? Projeto { get; set; }
        public DbSet<APITechCoffee.Models.Servico>? Servico { get; set; }
        public DbSet<APITechCoffee.Models.ItemProjetoServico>? ItemProjetoServico { get; set; }
        public DbSet<APITechCoffee.Models.Atividade>? Atividade { get; set; }
        public DbSet<APITechCoffee.Model.Cliente>? Cliente { get; set; }
        

       
    }
}
