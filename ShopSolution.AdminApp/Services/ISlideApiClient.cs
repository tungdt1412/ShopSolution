using ShopSolution.ViewModels.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopSolution.AdminApp.Services
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}