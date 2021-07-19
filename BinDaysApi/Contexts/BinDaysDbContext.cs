using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BinDaysApi.Models;

namespace BinDaysApi.Contexts
{
    public class BinDaysDbContext : DbContext
    {
        public DbSet<BinDay> BinDays { get; set; }        
    }
}