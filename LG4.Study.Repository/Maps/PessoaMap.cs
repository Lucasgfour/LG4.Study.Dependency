using LG4.Study.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Study.Repository.Maps {
    public class PessoaMap : IEntityTypeConfiguration<Pessoa> {
        
        public void Configure(EntityTypeBuilder<Pessoa> builder) {

            builder.ToTable("dep_pessoa");

            builder.HasKey(x => x.id);

            builder.Property(x => x.name).HasMaxLength(70).IsRequired();

            builder.Property(x => x.email).HasMaxLength(70).HasDefaultValue("");

            builder.Property(x => x.phone).HasMaxLength(30).HasDefaultValue("");
        
        }
    }
}
