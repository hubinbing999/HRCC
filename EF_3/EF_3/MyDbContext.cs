using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
namespace EF_3
{
    class MyDbContext:DbContext
    {
        public MyDbContext() : base("name=sql") {
            Database.SetInitializer<MyDbContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Classs> Classss { get; set; }
    }
}
