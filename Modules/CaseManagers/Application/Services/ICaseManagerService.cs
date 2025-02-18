using Shared.DTOs;
namespace Modules.CaseManagers.Application.Services
{
    public interface ICaseManagerService
    {
        Task<CaseManagerDto> GetCaseManagerByIdAsync(int caseManagerId);
    }
}