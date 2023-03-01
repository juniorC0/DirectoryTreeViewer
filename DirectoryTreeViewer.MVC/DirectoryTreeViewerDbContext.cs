using Microsoft.EntityFrameworkCore;

namespace DirectoryTreeViewer.MVC
{
    public class DirectoryTreeViewerDbContext : DbContext
    {
        public DirectoryTreeViewerDbContext(DbContextOptions<DirectoryTreeViewerDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Catalog> Catalogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalog>()
                .HasOne(x => x.ParentCatalog)
                .WithMany(x => x.ChildCatalogs)
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
