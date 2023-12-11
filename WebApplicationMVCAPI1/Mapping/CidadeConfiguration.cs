using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplicationMVCAPI1.Models;

namespace WebApplicationMVCAPI1.Mapping
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {

        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("tbl_geral_cidade");

            builder.HasKey(x => x.cidadeCodigo);

            builder.Property(x => x.cidadeCodigo).HasColumnName("cidade_codigo");

            builder.Property(x => x.cidadeDescricao).HasColumnName("cidade_descricao");

           // builder.Property(x => x.estadoCodigo).HasColumnName("estado_codigo");

           /// builder.HasOne(x => x.estado).WithMany().HasForeignKey(x => x.estadoCodigo);
        }
    }
}
