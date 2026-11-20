using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenDucThang_Day6.Models;

namespace NguyenDucThang_Day6.Data
{
    public class NguyenDucThang_Day6Context : DbContext
    {
        public NguyenDucThang_Day6Context (DbContextOptions<NguyenDucThang_Day6Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenDucThang_Day6.Models.Category> Category { get; set; } = default!;
        public DbSet<NguyenDucThang_Day6.Models.Book> Book { get; set; } = default!;
    }
}
