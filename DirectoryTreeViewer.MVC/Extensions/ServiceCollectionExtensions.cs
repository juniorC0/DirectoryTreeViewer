using Microsoft.EntityFrameworkCore;

namespace DirectoryTreeViewer.MVC.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<DirectoryTreeViewerDbContext>(optionBuilder =>
            {
                optionBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DirectoryTreeViewerDb;Integrated Security=True");
            });
        }
    }
}
