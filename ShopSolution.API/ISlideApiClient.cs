using ShopSolution.ViewModels.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopSolution.API
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}