using Shared.DTOs;
namespace Modules.CaseManagers.Infrastructure
{
    public interface ICaseManagerRepository
    {
        Task<CaseManagerDto> GetCaseManagerAsync(int caseManagerId);
    }
}