using Domain.SectionAggregate;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sections.Queries
{
    public record ListSectionsQuery : IRequest<ErrorOr<List<Section>>>;
}