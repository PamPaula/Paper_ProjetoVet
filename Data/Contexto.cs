using Microsoft.EntityFrameworkCore;
using ProjetoVetMVCNew.Models;

namespace ProjetoVetMVCNew.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Animais> Animais { get; set; }
    }
}
