using AutoMapper;

namespace SGFR_Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewlModelMappings"; }
        }
    }
}
