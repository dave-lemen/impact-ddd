using Shared.DTOs;
namespace Modules.CaseManagers.Application.Facades
{
    public interface ICaseManagerFacade
    {
        Task<CaseManagerDto> GetCaseManager(int caseManagerId);
    }
}