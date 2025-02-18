using Shared.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Modules.Appointments.Infrastructure
{
    internal class AppointmentRepository : IAppointmentRepository
    {
        public async Task<List<AppointmentDto>> GetTodayAppointmentsAsync(int officeId)
        {
            // Simulating a DB call
            await Task.Delay(100);

            return new List<AppointmentDto>
            {
                new AppointmentDto { Id = 1, OfficeId = officeId, ParticipantId = 101, CaseWorkerId = 201, Date = DateTime.UtcNow }
            };
        }
    }
}