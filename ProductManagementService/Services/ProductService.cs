using ProductManagementService.Models;
using ProductManagementService.Repositories;
using KiraExpress.Areas.MarketPlace.DataTransferObjects;
using System.Threading.Tasks;

public class ProductService
{
    private readonly IRepository<Product> _productRepository;

    public ProductService(IRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> AddProductAsync(ProductDto model)
    {
        var product = new Product
        {
            Name = model.Name,
            Description = model.Description,
            Price = model.Price,
            CreatedAt = model.CreatedAt
        };
        return await _productRepository.AddAsync(product);
    }
}