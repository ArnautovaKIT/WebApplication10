using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using WebApplication10.model;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Orders> Orderss { get; set; }
    public DbSet<partnetu> partnetus { get; set; }
    public DbSet<cotrydniki> cotrydnikis { get; set; }
    public DbSet<Productsimport> productsimport { get; set; }
    public DbSet<Productmaterialsimport> productmaterialsimports { get; set; }
    public DbSet<Producttypeimport> producttypeimports { get; set; }

    public DbSet<Materialsimport> materialsimports { get; set; }
    public DbSet<Materialtypeimport> materialtypeimports { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Role>(e =>
        {
            e.HasKey(e  => e.Id);
            e.HasMany(e => e.users).WithOne(p => p.Role).HasForeignKey(k => k.RoleId);


        });

        

        modelBuilder.Entity<Orders>(k =>
        {
            k.HasKey(d => d.Id);
            k.HasOne(t => t.partnetu).WithMany(g => g.Orderss).HasForeignKey(l => l.partnetuId);
            k.HasMany(i =>i.producttypeimports).WithOne(j => j.Orderss).HasForeignKey(l => l.OrdersId);

        });
       

        modelBuilder.Entity<partnetu>(g =>
        {
            g.HasKey(d => d.Id);


        });

       

        modelBuilder.Entity<cotrydniki>(t =>
        {
           t.HasKey(e => e.Id);
            t.HasMany(u => u.productsimport).WithOne(i => i.cotrydniki).HasForeignKey(k => k.cotrydnikiId);

        });


        modelBuilder.Entity<Productsimport>(t =>
        {
            t.HasKey(e => e.Id);
            t.HasOne(c => c.productmaterialsimport).WithMany(d => d.productsimports).HasForeignKey(y => y.ProductmaterialsimportId);
        });


        modelBuilder.Entity<Productmaterialsimport>(t =>
        {
            t.HasKey(e => e.Id);
            t.HasMany(l => l.materialsimports).WithOne(g => g.productmaterialsimport).HasForeignKey(y => y.ProductmaterialsimportId);
            t.HasOne(s => s.producttypeimport).WithMany(o => o.productmaterialsimports).HasForeignKey(g => g.ProducttypeimportId);
        });


        modelBuilder.Entity<Materialsimport>(t =>
        {
            t.HasKey(e => e.Id);
            t.HasOne(k => k.Materialtypeimport).WithMany(g => g.Materialsimports).HasForeignKey(g => g.MaterialtypeimportId);
        });
    }




}
