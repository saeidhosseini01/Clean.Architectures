using AutoMapper;
using Clean.Architecture.Application.Mappings;
using Clean.Architecture.Domain.Entities.Common;
using Clean.Architecture.Domain.Exeptions;
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


        public async Task<Const> GetConstByKeyAsync(string key, CancellationToken cancellationToken)
        => _context.Const.Where(c => c.Key == key).FirstOrDefault();

        

        public async Task UpdateConstAsync(Const model, CancellationToken cancellationToken)
        {
            var res = _context.Const.Where(c => c.Id == model.Id).FirstOrDefault();
            if (res == null) throw new NotFountUserExeption();
            res.Description = model.Description;
            res.ConstTypeIds = model.ConstTypeIds;
            res.Order = model.Order;
            res.Key = model.Key;
            res.Name = model.Name;

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
