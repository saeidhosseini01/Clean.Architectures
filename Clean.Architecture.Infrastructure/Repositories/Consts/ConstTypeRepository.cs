using Clean.Architecture.Application.Exeption;
using Clean.Architecture.Domain.Entities.Common;
using Clean.Architecture.Domain.Exeptions.NotFount;
using Clean.Architecture.Domain.Interfaces.Consts;
using Clean.Architecture.Persistence.ApiDbContext;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Infrastructure.Repositories.Consts
{
    public class ConstTypeRepository : IConstTypeRepository
    {
        private readonly ApiDbContexts _dbContext;

        public ConstTypeRepository(ApiDbContexts dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddConstTypeAsync(ConstType constType, CancellationToken cancellationToken)
        {
         await  _dbContext.AddAsync(constType, cancellationToken);
        }

        public async Task<List<ConstType>> GetAllConstTypeAsync(CancellationToken cancellationToken)
        {
            var res =await  _dbContext.ConstType.ToListAsync();
                return res;
        }

        public async Task<ConstType> GetConstTypeByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var res = _dbContext.ConstType.Where(item => item.Id == id).FirstOrDefaultAsync().Result;
            return res;
        }

        public async Task UpdateConstTypeAsync(ConstType constType, CancellationToken cancellationToken)
        {
            _dbContext.Update(constType);
          await   _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
