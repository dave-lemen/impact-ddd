using Shared.DTOs;
using Modules.Appointments.Infrastructure;

namespace Modules.Appointments.Application.Services
{
    internal class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task<List<AppointmentDto>> GetTodayAppointmentsAsync(int officeId)
        {
            return await _appointmentRepository.GetTodayAppointmentsAsync(officeId);
        }
    }
}