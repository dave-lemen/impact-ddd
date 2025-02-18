using Shared.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Modules.CaseManagers.Infrastructure
{
    internal class CaseManagerRepository : ICaseManagerRepository
    {
        public async Task<CaseManagerDto> GetCaseManagerAsync(int officeId)
        {
            // Simulating a DB call
            await Task.Delay(100);

            return new CaseManagerDto { Id = 1, OfficeId = officeId, Name = "Dave" };
        }
    }
}