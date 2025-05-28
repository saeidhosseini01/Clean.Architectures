using Clean.Architecture.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Domain.Interfaces.Consts
{
    public interface IConstTypeRepository
    {
        Task<List<ConstType>> GetAllConstTypeAsync(CancellationToken cancellationToken);
        Task<ConstType> GetConstTypeByIdAsync(string id, CancellationToken cancellationToken);
        Task AddConstTypeAsync(ConstType constType, CancellationToken cancellationToken);
        Task UpdateConstTypeAsync(ConstType constType, CancellationToken cancellationToken);


    }
}
