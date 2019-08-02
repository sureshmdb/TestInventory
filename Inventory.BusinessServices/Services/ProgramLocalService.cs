using Inventory.BusinessServices.Interfaces;
using Inventory.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BusinessServices.Services
{
    public class ProgramLocalService : IProgramLocalService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;
        public Task<List<ProgramLocalDto>> GetProgramLocals(ProgramLocalDto programLocalRequest)
        {
            throw new NotImplementedException();
        }
    }
}
