using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EF_3.ExtentionConfig
{
   public class StudentConfig:EntityTypeConfiguration<Student>
    {
        public StudentConfig() {
            this.ToTable(nameof(Student));
            this.Property(e => e.Name).HasMaxLength(20).IsRequired();
            this.Property(e => e.Sex).HasMaxLength(2);
            this.HasRequired(e => e.Classs).WithMany().HasForeignKey(e => e.ClassId);
        }
    }
}
