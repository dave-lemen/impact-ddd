using Shared.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Modules.Participants.Infrastructure
{
    internal class ParticipantRepository : IParticipantRepository
    {
        public async Task<ParticipantDto> GetParticipantAsync(int participantId)
        {
            // Simulating a DB call
            await Task.Delay(100);

            return new ParticipantDto { Id = participantId, RID = "123456789099", Name = "Dave" };
        }
    }
}