using Shared.DTOs;
namespace Modules.Participants.Application.Facades
{
    public interface IParticipantFacade
    {
        Task<ParticipantDto> GetParticipant(int ParticipantId);
    }
}