
namespace RoomBookingApp.Core
{
    internal class RoomBookingRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}