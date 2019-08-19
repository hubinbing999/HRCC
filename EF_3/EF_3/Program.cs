using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EF_3.Model;
namespace EF_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDbContext mc = new MyDbContext()) {
                mc.Database.Log = (sql) => {
                    Console.WriteLine(sql);
                };
                //新增----------------------------------------------------------------------------------------------------------------------------------
                /*Classs c = new Classs() {
                    Name = "草帽海贼团"
                };
                Student st = new Student()
                {
                    Name = "路飞",
                    Sex = "男",
                    Classs = c
                    };
                    Console.WriteLine(mc.Entry(st).State);
                    //mc.Students.Add(st);
                    mc.Entry(st).State = EntityState.Added;
                    Console.WriteLine(mc.Entry(st).State);
                    mc.SaveChanges();
                    Console.WriteLine(mc.Entry(st).State); */

                //修改----------------------------------------------------------------------------------------------------------------------------------

                /*Student st = new Student() {
                        Id=2,
                        Name = "索隆",
                        Sex = "男"
                    };
                    Console.WriteLine(mc.Entry(st).State);
                    mc.Students.Attach(st);
                    Console.WriteLine(mc.Entry(st).State);
                    mc.Entry(st).State = EntityState.Modified;
                    Console.WriteLine(mc.Entry(st).State);
                    mc.SaveChanges();
                    Console.WriteLine(mc.Entry(st).State);*/

                /*Student st = mc.Students.Where(e => e.Id.Equals(2)).FirstOrDefault();
                Console.WriteLine(mc.Entry(st).State);
                st.Name = "索隆";
                Console.WriteLine(mc.Entry(st).State);
                mc.SaveChanges();
                Console.WriteLine(mc.Entry(st).State);*/

                //删除----------------------------------------------------------------------------------------------------------------------------------

                /* Student st = new Student() {
                         Id=3
                     };
                     mc.Students.Attach(st);
                     Console.WriteLine(mc.Entry(st).State);
                     mc.Students.Remove(st);
                     Console.WriteLine(mc.Entry(st).State);
                     mc.SaveChanges();
                     Console.WriteLine(mc.Entry(st).State);*/

                /*Student st = mc.Students.Where(e => e.Id.Equals(4)).FirstOrDefault();
                Console.WriteLine(mc.Entry(st).State);
                mc.Students.Remove(st);
                Console.WriteLine(mc.Entry(st).State);
                mc.SaveChanges();
                Console.WriteLine(mc.Entry(st).State);*/

                /*Student st = new Student()
                {
                    Id = 5
                };
                mc.Students.Attach(st);
                Console.WriteLine(mc.Entry(st).State);
                mc.Entry(st).State = EntityState.Deleted;
                Console.WriteLine(mc.Entry(st).State);
                mc.SaveChanges();
                Console.WriteLine(mc.Entry(st).State);*/

                //查询全部----------------------------------------------------------------------------------------------------------------

                /*var result = (from e in mc.Students select e).ToList();
                    Console.WriteLine("*****************************************************");
                    foreach (var item in result)
                    {
                        Student st = new Student()
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Sex = item.Sex
                        };
                        Console.WriteLine(item.Id + ":" + item.Name + ":" + item.Sex);
                    }*/

                /*var result = mc.Students.Select(e => e);
                Console.WriteLine("*****************************************************");
                foreach (var item in result)
                {
                    Student st = new Student()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Sex = item.Sex
                    };
                    Console.WriteLine(item.Id + ":" + item.Name + ":" + item.Sex);
                }*/

                //带条件查询----------------------------------------------------------------------------------------------------------------

                /*var result = from e in mc.Students where e.Name.Contains("路") && e.Sex.Equals("男") select e;
                    Console.WriteLine("*****************************************************");
                    foreach (var item in result)
                    {
                        Student st = new Student()
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Sex = item.Sex
                        };
                        Console.WriteLine(item.Id + ":" + item.Name + ":" + item.Sex);
                    }*/

                /*var result = mc.Students.Where(e => e.Name.Contains("索") && e.Sex.Equals("男")).Select(e=>new {Id = e.Id,Name = e.Name,Sex = e.Sex });
                 Console.WriteLine("*****************************************************");
                 foreach (var item in result)
                 {
                     Student st = new Student()
                     {
                         Id = item.Id,
                         Name = item.Name,
                         Sex = item.Sex
                     };
                     Console.WriteLine(item.Id + ":" + item.Name + ":" + item.Sex);
                 }*/

                //排序----------------------------------------------------------------------------------------------------------------------------------

                /* var result = from e in mc.Students orderby e.Id descending select e;
                 Console.WriteLine("*****************************************************");
                 foreach (var item in result)
                 {
                     Student st = new Student()
                     {
                         Id = item.Id,
                         Name = item.Name,
                         Sex = item.Sex
                     };
                     Console.WriteLine(item.Id + ":" + item.Name + ":" + item.Sex);
                 }*/

                /*var result = mc.Students.OrderBy(e => e.Id).Select(e => e).ToList();
                Console.WriteLine("*****************************************************");
                foreach (var item in result)
                {
                    Student st = new Student()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Sex = item.Sex
                    };
                    Console.WriteLine(item.Id + ":" + item.Name + ":" + item.Sex);
                }*/

                //分组----------------------------------------------------------------------------------------------------------------------------------

                /* var result = from e in mc.Students group e by e.Sex;
                 Console.WriteLine("*****************************************************");
                 foreach (var item in result)
                 {
                     Console.WriteLine(item.Key + ":" + item.Count());
                 }*/

                /* var result = mc.Students.GroupBy(e => e.Sex);
                 Console.WriteLine("*****************************************************");
                 foreach (var item in result)
                 {
                     Console.WriteLine(item.Key + ":" + item.Count());
                 }*/

                //执行的是查询sql语句----------------------------------------------------------------------------------------------------------------------------------

                /* var result = mc.Database.SqlQuery<Student>("select * from Student");
                 Console.WriteLine("*****************************************************");
                 foreach (var item in result)
                 {
                     Student st = new Student()
                     {
                         Id = item.Id,
                         Name = item.Name,
                         Sex = item.Sex
                     };
                     Console.WriteLine(item.Id + ":" + item.Name + ":" + item.Sex);
                 }*/

                //执行的是增删改的sql语句------------------------------------------------------------------------------------------------------------

                //删除----------------------------------------------------------------------------------------------------------------------------------
                /*int result = mc.Database.ExecuteSqlCommand("delete from Student where Id = 9");
                if (result>0) {
                    Console.WriteLine("ok");
                }*/
                //新增----------------------------------------------------------------------------------------------------------------------------------
                /*int result = mc.Database.ExecuteSqlCommand("insert into [dbo].[Student](Name, Sex) values('乔巴','男')");
                if (result > 0)
                {
                    Console.WriteLine("ok");
                }*/
                //修改----------------------------------------------------------------------------------------------------------------------------------
                /*int result = mc.Database.ExecuteSqlCommand("update [dbo].[Student] set Name='乔巴', Sex='女' where Id = 10");
                if (result > 0)
                {
                    Console.WriteLine("ok");
                }*/
                //分页----------------------------------------------------------------------------------------------------------------------------------

                /* var result = mc.Students.OrderBy(e => e.Id).Skip((2-1)*2).Take(2).ToList();
                 Console.WriteLine("*****************************************************");
                 foreach (var item in result)
                 {
                     Student st = new Student()
                     {
                         Id = item.Id,
                         Name = item.Name,
                         Sex = item.Sex
                     };
                     Console.WriteLine(item.Id + ":" + item.Name + ":" + item.Sex);
                 }*/

                //多表----------------------------------------------------------------------------------------------------------------------------------

                /* var result = from e in mc.Classss join cc in mc.Students on e.Id equals cc.ClassId select new { e.Name, cc.Id, xname = cc.Name };
                    Console.WriteLine("*****************************************************");
                    foreach (var item in result)
                    {
                        ClassStudent cs = new ClassStudent() {

                            Id = item.Id,
                            Cname = item.Name,
                            Xname = item.xname
                        };
                        Console.WriteLine(item.Id + ":" + item.Name + ":" + item.xname);
                    }*/

                var result = mc.Students.Join(mc.Classss, e => e.ClassId, p => p.Id, (e, p) => new { e.Name, p.Id, xname = p.Name }).ToList();
                Console.WriteLine("*****************************************************");
                foreach (var item in result)
                {
                    ClassStudent cs = new ClassStudent()
                    {

                        Id = item.Id,
                        Cname = item.Name,
                        Xname = item.xname
                    };
                    Console.WriteLine(item.Id + ":" + item.Name + ":" + item.xname);
                }
            }
            Console.ReadKey();
        }
        
    }
}
