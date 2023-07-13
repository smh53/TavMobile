using Application.Sections.Commands.CreateSection;
using Application.Sections.Queries;
using BuberDinner.Api.Controllers;
using Domain.Contracts.Sections;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ErrorOr;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class SectionController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly ISender _mediator;

        public SectionController(IMapper mapper, ISender mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSection(
       CreateSectionRequest request
      )
        {
            var command = _mapper.Map<CreateSectionCommand>(request);

            var createSectionResult = await _mediator.Send(command);

            return createSectionResult.Match(
                menu => Ok(_mapper.Map<SectionResponse>(menu)),
                errors => Problem(errors));
        }

        [HttpGet]
        public async Task<IActionResult> ListSections()
        {
            //var query = _mapper.Map<ListSectionsQuery>();

            var listSectionsResult = await _mediator.Send(new ListSectionsQuery());

            return listSectionsResult.Match(
                menus => Ok(menus.Select(menu => _mapper.Map<SectionResponse>(menu))),
                errors => Problem(errors));
        }
    }
}