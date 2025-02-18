using Shared.DTOs;
using Modules.Appointments.Application.Services;

namespace Modules.Appointments.Application.Facades
{
    internal class AppointmentFacade : IAppointmentFacade
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentFacade(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public async Task<List<AppointmentDto>> GetTodayAppointmentsAsync(int officeId)
        {
            return await _appointmentService.GetTodayAppointmentsAsync(officeId);
        }
    }
}