using AutoMapper;

namespace CleanArch.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            var autoMapperConfig = new MapperConfiguration(cfg =>
           {
               cfg.AddProfile(new ViewModelToDomainProfile());
               cfg.AddProfile(new DomainToViewModelProfile());
           });

            return autoMapperConfig;
        }
    }
}
