using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Sections
{
    public record CreateSectionRequest
    (
        string Name,
        string Description,
        int No
    );
}