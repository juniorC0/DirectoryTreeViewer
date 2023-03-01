using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DirectoryTreeViewer.MVC.Controllers
{
    public class CatalogController : Controller
    {
        private readonly DirectoryTreeViewerDbContext _dbContext;

        public CatalogController(DirectoryTreeViewerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int? id = 1)
        {
            var catalog = _dbContext.Catalogs
                .Include(x => x.ParentCatalog)
                .Include(x => x.ChildCatalogs)
                .FirstOrDefault(x => x.Id == id);

            if (catalog == null)
            {
                return View("CatalogNotFound", id);
            }

            return View(catalog);
        }
    }
}
