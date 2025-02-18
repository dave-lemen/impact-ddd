using Shared.DTOs;
namespace Modules.Appointments.Application.Facades
{
    public interface IAppointmentFacade
    {
        Task<List<AppointmentDto>> GetTodayAppointmentsAsync(int officeId);
    }
}