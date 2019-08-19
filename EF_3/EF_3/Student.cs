using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_3
{
   public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int ClassId { get; set; }
        public virtual Classs Classs { get; set; }
    }
}
