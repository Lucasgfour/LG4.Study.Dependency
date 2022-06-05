using LG4.Study.Data.Models;
using LG4.Study.Repository.Maps;
using Microsoft.EntityFrameworkCore;

namespace LG4.Study.Repository {
    public class Context : DbContext {

        public Context(DbContextOptions<Context> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration<Pessoa>(new PessoaMap());

        }

        public DbSet<Pessoa> Pessoa { get; set; }

    }
}
