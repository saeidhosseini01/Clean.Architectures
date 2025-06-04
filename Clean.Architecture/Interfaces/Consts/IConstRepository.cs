using Clean.Architecture.Application.Dtos.Base;
using Clean.Architecture.Domain.Entities.Common;
using Clean.Architecture.Domain.ValueObject.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Interfaces.Consts
{
    public interface IConstRepository
    {
        Task<List<Const>> GetAllConstAsync(CancellationToken cancellationToken);
        Task<Const> GetConstByIdAsync(Guid id,CancellationToken cancellationToken);
        Task<List<TValue<Guid>>> GetConstByKeyAsync(string key,CancellationToken cancellationToken);
       
        Task AddConstAsync(Const model,CancellationToken cancellationToken);
        Task UpdateConstAsync(Const model,CancellationToken cancellationToken);
    }
}
