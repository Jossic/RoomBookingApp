using System;
namespace RoomBookingApp.Core
{
	public class RoomBookingRequestProcessorTest
	{
		[Fact]
		public void Should_return_room_booking_response_with_request_value()
        {
			var BookingRequest = new RoomBookingRequest
			{
				FullName = "Test Name",
				Email = "test@mqil.com",
				Date = new DateTimeOffset(DateTime.Now)
			};

			var processor = new RoomBookingRequestProcessor();

			RoomBookingResult result = processor.BookRoom(BookingRequest);
        }
	}
}

