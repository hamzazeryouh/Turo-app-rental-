

namespace Turo.Application.Maping
{
    using AutoMapper;
    using Turo.Application.Dtos.Cars;
    using Turo.Domain.Entities;
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarDto>()
                .ForMember(dest => dest.PhotoUrls, opt => opt.MapFrom(src => src.Photos.Select(p => p.Url)))
                .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src => src.Reviews.Any() ? src.Reviews.Average(r => r.Rating) : 0))
                .ForMember(dest => dest.ReviewCount, opt => opt.MapFrom(src => (src.Reviews.Count)));
            CreateMap<CreateCarDTo, Car>()
               .ForMember(dest => dest.Photos, opt => opt.Ignore()); // Assuming photos are handled separately

            // Mapping from UpdateCarDto to Car
            CreateMap<UpdateCarDTo, Car>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null)); // Only update non-null properties
        }
    }
}
