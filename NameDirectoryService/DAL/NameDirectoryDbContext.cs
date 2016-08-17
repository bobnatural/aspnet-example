using NameDirectoryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;

namespace NameDirectoryService.DAL
{
    public class NameDirectoryDbContext : DbContext
    {
        ConnectionSettings connectionSettings;
        string webRootPath;

        public NameDirectoryDbContext(IOptions<ConnectionSettings> settings, string webRootPath)
        {
            this.connectionSettings = settings.Value;
            this.webRootPath = webRootPath;
        }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (connectionSettings.DriverClassName == "postgre")
                optionsBuilder.UseNpgsql(connectionSettings.DefaultConnection);
            else if (connectionSettings.DriverClassName == "sqlight")
                optionsBuilder.UseSqlite("FileName=" + this.webRootPath + @"\data\sqlight_db.db");
            else
                optionsBuilder.UseSqlServer(connectionSettings.DefaultConnection);
        }

        public DbSet<NameDirectory> NameDirectory { get; set; }        
    }
}