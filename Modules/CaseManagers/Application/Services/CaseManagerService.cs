using Shared.DTOs;
using Modules.CaseManagers.Infrastructure;

namespace Modules.CaseManagers.Application.Services
{
    internal class CaseManagerService : ICaseManagerService
    {
        private readonly ICaseManagerRepository _caseManagerRepository;

        public CaseManagerService(ICaseManagerRepository caseManagerRepository)
        {
            _caseManagerRepository = caseManagerRepository;
        }

        public async Task<CaseManagerDto> GetCaseManagerByIdAsync(int caseManagerId)
        {
            return await _caseManagerRepository.GetCaseManagerAsync(caseManagerId);
        }
    }
}