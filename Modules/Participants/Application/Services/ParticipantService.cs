using Shared.DTOs;
using Modules.Participants.Infrastructure;

namespace Modules.Participants.Application.Services
{
    internal class ParticipantService : IParticipantService
    {
        private readonly IParticipantRepository _participantRepository;

        public ParticipantService(IParticipantRepository participantRepository)
        {
            _participantRepository = participantRepository;
        }

        public async Task<ParticipantDto> GetParticipantByIdAsync(int participantId)
        {
            return await _participantRepository.GetParticipantAsync(participantId);
        }
    }
}