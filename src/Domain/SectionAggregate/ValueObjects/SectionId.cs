using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavMobile.Domain.Common.Models;

namespace Domain.SectionAggregate.ValueObjects
{
    public sealed class SectionId : AggregateRootId<Guid>
    {
        private SectionId(Guid value) : base(value)
        {
        }

        public static SectionId CreateUnique()
        {
            return new SectionId(Guid.NewGuid());
        }

        public static SectionId Create(Guid sectionId)
        {
            return new SectionId(sectionId);
        }
    }
}