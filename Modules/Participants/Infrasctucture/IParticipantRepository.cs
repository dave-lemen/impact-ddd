using Shared.DTOs;
namespace Modules.Participants.Infrastructure
{
    public interface IParticipantRepository
    {
        Task<ParticipantDto> GetParticipantAsync(int participantId);
    }
}