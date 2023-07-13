using Application.Common.Persistence;
using Domain.SectionAggregate;
using Domain.SectionAggregate.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private readonly TavMobileDbContext _dbContext;

        public SectionRepository(TavMobileDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Section section)
        {
            _dbContext.Add(section);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(SectionId sectionId)
        {
            _dbContext.Remove(sectionId);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(SectionId sectionId)
        {
            return await _dbContext.Sections.AnyAsync(section => section.Id == sectionId);
        }

        public async Task<List<Section>> GetAllAsync()
        {
            return await _dbContext.Sections.ToListAsync();
        }

        public async Task<Section?> GetByIdAsync(SectionId sectionId)
        {
            return await _dbContext.Sections.FirstOrDefaultAsync(section => section.Id == sectionId);
        }

        public async Task UpdateAsync(Section section)
        {
            _dbContext.Sections.Update(section);
            await _dbContext.SaveChangesAsync();
        }
    }
}