using Microsoft.AspNetCore.Mvc;
using Modules.Appointments.Application.Facades;

[ApiController]
[Route("api/[controller]")]
public class AppointmentController : ControllerBase
{
    private readonly IAppointmentFacade _appointmentFacade;

    public AppointmentController(IAppointmentFacade appointmentFacade)
    {
        _appointmentFacade = appointmentFacade;
    }

    /// <summary>
    /// Gets all appointments for the provided Office ID
    /// </summary>
    /// <param name="officeId">ID of office to provide</param>
    /// <returns>JSON of appointments</returns>
    [HttpGet("get-today-appts/{officeId}")]
    public async Task<IActionResult> GetTodayAppointments(int officeId)
    {
        var result = await _appointmentFacade.GetTodayAppointmentsAsync(officeId);
        return Ok(result);
    }
}