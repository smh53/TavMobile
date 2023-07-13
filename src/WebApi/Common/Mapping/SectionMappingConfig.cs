using Application.Sections.Commands.CreateSection;
using Application.Sections.Queries;
using Domain.Contracts.Sections;
using Domain.SectionAggregate;
using Mapster;

namespace WebApi.Common.Mapping
{
    public class SectionMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateSectionRequest, CreateSectionCommand>()
            .Map(dest => dest, src => src);

            config.NewConfig<Section, SectionResponse>()
                .Map(dest => dest.Id, src => src.Id.Value.ToString())
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Description, src => src.Description)
                .Map(dest => dest.No, src => src.No);
        }
    }
}