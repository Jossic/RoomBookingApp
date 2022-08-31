using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;
using Shouldly;

namespace RoomBookingApp.Core;

public class RoomBookingRequestProcessorTest
{
    [Fact]
    public void Should_return_room_booking_response_with_request_value()
    {
        // Arrange
        var request = new RoomBookingRequest
        {
            FullName = "Test Name",
            Email = "test@mqil.com",
            Date = new DateTime(2022, 08, 31)
        };

        var processor = new RoomBookingRequestProcessor();

        // Act
        RoomBookingResult result = processor.BookRoom(request);

        // Assert
        result.ShouldNotBeNull();
        request.FullName.ShouldBe(result.FullName);
        request.Email.ShouldBe(result.Email);
        request.Date.ShouldBe(result.Date);
    }
}

