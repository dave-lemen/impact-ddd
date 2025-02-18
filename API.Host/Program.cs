using Modules.Appointments.Application.Facades;
using Modules.Appointments.Application.Services;
using Modules.Appointments.Infrastructure;
using Modules.CaseManagers.Application.Facades;
using Modules.CaseManagers.Application.Services;
using Modules.CaseManagers.Infrastructure;
using Modules.Participants.Application.Facades;
using Modules.Participants.Application.Services;
using Modules.Participants.Infrastructure;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Register Dependencies
builder.Services.AddScoped<IAppointmentFacade, AppointmentFacade>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();
builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();

builder.Services.AddScoped<ICaseManagerFacade, CaseManagerFacade>();
builder.Services.AddScoped<ICaseManagerService, CaseManagerService>();
builder.Services.AddScoped<ICaseManagerRepository, CaseManagerRepository>();

builder.Services.AddScoped<IParticipantFacade, ParticipantFacade>();
builder.Services.AddScoped<IParticipantService, ParticipantService>();
builder.Services.AddScoped<IParticipantRepository, ParticipantRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseRouting();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
