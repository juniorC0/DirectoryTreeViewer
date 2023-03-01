using DirectoryTreeViewer.MVC.DataSeed;

namespace DirectoryTreeViewer.MVC.Extensions
{
    public static class HostExtension
    {
        public static async Task SeedData(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<DirectoryTreeViewerDbContext>();

                await CatalogSeed.Seed(context);
            }
        }
    }
}
