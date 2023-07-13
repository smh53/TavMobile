using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.DomainErrors
{
    public static partial class Errors
    {
        public static class Section
        {
            public static Error InvalidSectionId => Error.Validation(
           code: "Section.InvalidId",
           description: "Section ID is invalid");

            public static Error NotFound => Error.NotFound(
                code: "Section.NotFound",
                description: "Section with given ID does not exist");
        }
    }
}