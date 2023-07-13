using Domain.SectionAggregate.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavMobile.Domain.Common.Models;

namespace Domain.SectionAggregate
{
    public sealed class Section : AggregateRoot<SectionId, Guid>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int No { get; private set; }

        private Section(SectionId sectionId, string name, string description, int no) : base(sectionId)
        {
            Name = name;
            Description = description;
            No = no;
        }

        public static Section Create(string name, string description, int no)
        {
            return new Section(SectionId.CreateUnique(), name, description, no);
        }

#pragma warning disable CS8618

        private Section()

        {
        }

#pragma warning restore CS8618
    }
}