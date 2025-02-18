using Shared.DTOs;
using Modules.Participants.Application.Services;

namespace Modules.Participants.Application.Facades
{
    internal class ParticipantFacade : IParticipantFacade
    {
        private readonly IParticipantService _participantService;

        public ParticipantFacade(IParticipantService participantService)
        {
            _participantService = participantService;
        }

        public async Task<ParticipantDto> GetParticipant(int participantId)
        {
            return await _participantService.GetParticipantByIdAsync(participantId);
        }
    }
}