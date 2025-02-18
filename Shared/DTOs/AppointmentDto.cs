namespace Shared.DTOs
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public int OfficeId { get; set; }
        public int ParticipantId { get; set; }
        public int CaseWorkerId { get; set; }
        public DateTime Date { get; set; }
    }
}
