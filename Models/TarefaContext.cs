using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;

namespace TarefasApi.Models;

public class TarefaContext : DbContext
{
    public TarefaContext(DbContextOptions<TarefaContext> options)
        : base(options)
    {
    }
    public DbSet<TarefaItem> TarefaItems { get; set; } = null!;
    public DbSet<Aluno> Alunos { get; set; } = null!;
    public DbSet<Nota> Notas { get; set; } = null!;
}