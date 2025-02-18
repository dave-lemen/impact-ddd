using Shared.DTOs;
using Modules.CaseManagers.Application.Services;

namespace Modules.CaseManagers.Application.Facades
{
    internal class CaseManagerFacade : ICaseManagerFacade
    {
        private readonly ICaseManagerService _caseManagerService;

        public CaseManagerFacade(ICaseManagerService caseManagerService)
        {
            _caseManagerService = caseManagerService;
        }

        public async Task<CaseManagerDto> GetCaseManager(int caseManagerId)
        {
            return await _caseManagerService.GetCaseManagerByIdAsync(caseManagerId);
        }
    }
}