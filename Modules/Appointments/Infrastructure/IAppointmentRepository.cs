using Shared.DTOs;
namespace Modules.Appointments.Infrastructure
{
    public interface IAppointmentRepository
    {
        Task<List<AppointmentDto>> GetTodayAppointmentsAsync(int officeId);
    }
}