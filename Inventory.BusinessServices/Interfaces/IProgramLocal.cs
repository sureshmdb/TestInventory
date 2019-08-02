using Inventory.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BusinessServices.Interfaces
{
    public interface IProgramLocalService
    {
        Task<List<ProgramLocalDto>> GetProgramLocals(ProgramLocalDto programLocalRequest);
    }
}
