using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ReportBuilderAPI.Domain.Entities;

namespace ReportBuilderAPI.Persistence.Context;

public class ProjectDbContext(DbContextOptions<ProjectDbContext> options) : DbContext(options)
{

    public DbSet<Harmanlama> std_tbl_rapor_harmanlama { get; set; }
    public DbSet<Recete> std_tbl_recete { get; set; }
    public DbSet<Hammadde> std_tbl_hmmd { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Harmanlama>().ToTable("std_tbl_rapor_harmanlama");
        modelBuilder.Entity<Recete>().ToTable("std_tbl_recete");
        modelBuilder.Entity<Hammadde>().ToTable("std_tbl_hmmd");
    }
}
