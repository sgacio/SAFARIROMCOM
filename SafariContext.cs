using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace SAFARIROMCOM
{
  public partial class SafariContext : DbContext
  {
    public SafariContext()
    {
    }

    public SafariContext(DbContextOptions<SafariContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        optionsBuilder.UseNpgsql("server=localhost;database=safariromcom;User Id=postgres;Password=1Gmanrocks4");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
    }
    public DbSet<Safari> Trip { get; set; }



  }
}
