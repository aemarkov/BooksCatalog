using AutoMapper;
using BooksCatalog.Models;
using BooksCatalog.ViewModels;

namespace BooksCatalog.Utils
{
    /// <summary>
    /// Configure mapping for automapper
    /// </summary>
    public static class AutoMapperConfig
    {
        public static IMapper Config()
        {
            var config = new MapperConfiguration
            (
                cfg=>cfg.CreateMap<Category, SideMenuViewModel>()
                    .ForMember(dest=>dest.ControllerName, opt=>opt.UseValue("Books"))
                    .ForMember(dest=>dest.ActionName, opt=>opt.UseValue("Category"))
                    .ForMember(dest=>dest.Text,opt=>opt.MapFrom(src=>src.CategoryName))
                    .ForMember(dest => dest.RouteValue, opt => opt.MapFrom(src => src.Id))
             );

            return config.CreateMapper();
        }
    }
}