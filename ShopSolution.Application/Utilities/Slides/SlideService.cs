using ShopSolution.Application.System.Roles;
using ShopSolution.Data.EF;
using ShopSolution.Data.Entities;
using ShopSolution.ViewModels.System.Roles;
using ShopSolution.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSolution.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly ShopDBContext _context;

        public SlideService(ShopDBContext context)
        {
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}