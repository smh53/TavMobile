using Application.Common.Persistence;
using Domain.SectionAggregate;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sections.Commands.CreateSection
{
    public class CreateSectionCommandHandler : IRequestHandler<CreateSectionCommand, ErrorOr<Section>>
    {
        private readonly ISectionRepository _sectionRepository;

        public CreateSectionCommandHandler(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public async Task<ErrorOr<Section>> Handle(CreateSectionCommand command, CancellationToken cancellationToken)
        {
            var section = Section.Create(
                command.Name,
                command.Description,
                command.No
                );
            await _sectionRepository.AddAsync(section);
            return section;
        }
    }
}