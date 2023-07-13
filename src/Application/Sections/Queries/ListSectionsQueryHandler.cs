using Application.Common.Persistence;
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
    public class ListSectionsQueryHandler : IRequestHandler<ListSectionsQuery, ErrorOr<List<Section>>>
    {
        private readonly ISectionRepository _sectionRepository;

        public ListSectionsQueryHandler(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public async Task<ErrorOr<List<Section>>> Handle(ListSectionsQuery query, CancellationToken cancellationToken)
        {
            return await _sectionRepository.GetAllAsync();
        }
    }
}