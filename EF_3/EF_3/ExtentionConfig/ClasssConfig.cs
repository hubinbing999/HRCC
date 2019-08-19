using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EF_3.ExtentionConfig
{
   public class ClasssConfig:EntityTypeConfiguration<Classs>
    {
        public ClasssConfig() {
            this.ToTable(nameof(Classs));
            this.Property(e => e.Name).HasMaxLength(20).IsRequired();

        }
    }
}
