using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDBConnect.Models;

namespace WebDBConnect.DBContext
{
    public class NoteDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BasicNoteDB;Uid=sa;Pwd=sa1234;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
