using AutoMapper;
using Clean.Architecture.Application.Dtos.Base;
using Clean.Architecture.Application.Mappings;
using Clean.Architecture.Domain.Entities.Common;
using Clean.Architecture.Domain.Exeptions;
using Clean.Architecture.Domain.Exeptions.NotFount;
using Clean.Architecture.Domain.Interfaces.Consts;
using Clean.Architecture.Domain.ValueObject.User;
using Clean.Architecture.Persistence.ApiDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Clean.Architecture.Infrastructure.Repositories.Consts
{
    public class ConstRepository : IConstRepository
    {
        private readonly ApiDbContexts _context;
        MappingsProfile map = new MappingsProfile();

        public ConstRepository(ApiDbContexts dbContexts)
        {
            this._context = dbContexts;
        }
        public async Task AddConstAsync(Const model, CancellationToken cancellationToken)
        {
            await _context.Const.AddAsync(model, cancellationToken);
            await _context.SaveChangesAsync();
        }

        public Task<List<Const>> GetAllConstAsync(CancellationToken cancellationToken)
           => _context.Const.ToListAsync(cancellationToken);


        public async Task<Const> GetConstByIdAsync(Guid id, CancellationToken cancellationToken)
      => _context.Const.Where(c => c.Id == id).FirstOrDefault();


        public async Task<List<TValue<Guid>>> GetConstByKeyAsync(string key, CancellationToken cancellationToken)
        {
            var result = await (
                from cnt in _context.Const
                join cntyp in _context.ConstType on cnt.ConstTypeId equals cntyp.TypeId
                where cntyp.Key == key
                select new TValue<Guid>
                {
                    Value = cnt.Id,
                    Title = cnt.Name,
                }
            ).ToListAsync(cancellationToken);

            return result;
        }



        public async Task UpdateConstAsync(Const model, CancellationToken cancellationToken)
        {
            _context.Const.Update(model);
            await _context.SaveChangesAsync(cancellationToken);
        }

       
    }
}
