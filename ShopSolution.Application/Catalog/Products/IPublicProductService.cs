using ShopSolution.ViewModels.Catalog.Products;
using ShopSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId,  GetPublicProductPagingRequest request);
        
        //Task<List<ProductViewModel>> GetAll(string languageId);
    }
}
