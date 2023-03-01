namespace DirectoryTreeViewer.MVC.DataSeed
{
    public class CatalogSeed
    {
        public static async Task Seed(DirectoryTreeViewerDbContext dbContext)
        {
            if (!dbContext.Catalogs.Any())
            {
                var creatingDigitalImages = new Catalog
                {
                    Name = "Creating Digital Images"
                };

                var resources = new Catalog
                {
                    Name = "Resources",
                    ParentCatalog = creatingDigitalImages
                };

                var evidence = new Catalog
                {
                    Name = "Evidence",
                    ParentCatalog = creatingDigitalImages
                };

                var graphicsProducts = new Catalog
                {
                    Name = "Graphics Products",
                    ParentCatalog = creatingDigitalImages
                };

                var primarySources = new Catalog
                {
                    Name = "Primary Sources",
                    ParentCatalog = resources
                };

                var secondarySources = new Catalog
                {
                    Name = "Secondary Sources",
                    ParentCatalog = resources
                };

                var process = new Catalog
                {
                    Name = "Process",
                    ParentCatalog = graphicsProducts
                };

                var finalProduct = new Catalog
                {
                    Name = "Final Product",
                    ParentCatalog = graphicsProducts
                };


                dbContext.Catalogs.Add(creatingDigitalImages);
                dbContext.Catalogs.Add(resources);
                dbContext.Catalogs.Add(evidence);
                dbContext.Catalogs.Add(graphicsProducts);
                dbContext.Catalogs.Add(primarySources);
                dbContext.Catalogs.Add(secondarySources);
                dbContext.Catalogs.Add(process);
                dbContext.Catalogs.Add(finalProduct);


                await dbContext.SaveChangesAsync();
            }
        }
    }
}
