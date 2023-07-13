using Domain.SectionAggregate;
using Domain.SectionAggregate.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Persistence
{
    public interface ISectionRepository
    {
        Task AddAsync(Section section);

        Task UpdateAsync(Section section);

        Task DeleteAsync(SectionId sectionId);

        Task<Section?> GetByIdAsync(SectionId sectionId);

        Task<bool> ExistsAsync(SectionId sectionId);

        Task<List<Section>> GetAllAsync();
    }
}