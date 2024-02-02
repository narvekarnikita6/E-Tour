using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETourProject1.Repository
{
    public interface IBookingHeaderRepository
    {
        Task<ActionResult<IEnumerable<Booking_Header>>> GetAllBookings();
        Task<ActionResult<Booking_Header>?> GetBooking(int Id);
        Task<ActionResult<Booking_Header>> Add(Booking_Header booking);

    }
}
