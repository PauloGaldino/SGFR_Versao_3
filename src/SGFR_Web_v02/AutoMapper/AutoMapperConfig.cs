using AutoMapper;

namespace SGFR_Web_v02.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
               {
                   x.AddProfile<DomainToViewModelMappingProfile>();
                   x.AddProfile<ViewModelToDomainMappingProfile>();
               });
        }
    }
}
