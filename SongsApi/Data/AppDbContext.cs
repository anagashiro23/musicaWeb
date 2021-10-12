using Microsoft.EntityFrameworkCore;
using SongsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsApi.Data
{
    public class AppDbContext : DbContext

    {


        public DbSet<Song> Songs { get; set; } //Llama al modelo (Person) 


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {



        }

    }
}
