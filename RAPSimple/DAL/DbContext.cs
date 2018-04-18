using RAPSimple.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Generic;

namespace RAPSimple.DAL
{
    public class RAPInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RAPDbContext>
    {
        protected override void Seed(RAPDbContext context)
        {
            var students = new List<Participant>
            {
            new Participant{FirstMidName="Carson",LastName="Alexander", Details="Test user"},
            new Participant{FirstMidName="Meredith",LastName="Alonso", Details="Test user"}
            };

            students.ForEach(s => context.Participants.Add(s));
            context.SaveChanges();
        }
    }

    public class RAPDbContext : DbContext
    {
        public RAPDbContext()
            : base("DBContext")
        {
        }
//        public DbSet<Participant> Persons { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<File> Files { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Participant>().ToTable("Participant");
            modelBuilder.Entity<File>().ToTable("File");

        }
    }
}