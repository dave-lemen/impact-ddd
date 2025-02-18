using Shared.DTOs;
namespace Modules.Participants.Application.Services
{
    public interface IParticipantService
    {
        Task<ParticipantDto> GetParticipantByIdAsync(int ParticipantId);
    }
}