using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using aplicacao_asp.net_mvc.Models; // <- importa a pasta Models

namespace aplicacao_asp.net_mvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Adiciona a tabela Tipos
        public DbSet<Tipo> Tipos { get; set; } = null!;

        // Adiciona a tabela Tarefas
        public DbSet<Tarefa> Tarefas { get; set; } = null!;
    }
}
