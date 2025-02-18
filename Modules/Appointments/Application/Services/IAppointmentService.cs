using Shared.DTOs;
namespace Modules.Appointments.Application.Services
{
    public interface IAppointmentService
    {
        Task<List<AppointmentDto>> GetTodayAppointmentsAsync(int officeId);
    }
}