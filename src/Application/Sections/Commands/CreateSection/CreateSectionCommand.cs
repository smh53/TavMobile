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
    public record CreateSectionCommand
    (
        string Name,
        string Description,
        int No
    ) : IRequest<ErrorOr<Section>>;
}