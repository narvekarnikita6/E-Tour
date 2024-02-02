using ETourProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETourProject1.Repository
{
    public class BookingHeaderRepository : IBookingHeaderRepository
    {
        private readonly Appdbcontext context;

        public BookingHeaderRepository(Appdbcontext context)
        {
            this.context = context;
        }
        public async Task<ActionResult<Booking_Header>> Add(Booking_Header booking)
        {
            context.BookingHeaders.Add(booking);
            await context.SaveChangesAsync();
            return booking;
        }


        public async Task<ActionResult<IEnumerable<Booking_Header>>> GetAllBookings()
        {
            if (context.BookingHeaders == null)
                return null;

            return await context.BookingHeaders.ToListAsync();
        }

        public async Task<ActionResult<Booking_Header>?> GetBooking(int Id)
        {
            if (context.BookingHeaders == null)
                return null;
            Booking_Header booking = await context.BookingHeaders.FindAsync(Id);

            if (booking == null)
                return null;
            return booking;
        }

        public bool BookingExists(int id)
        {
            return (context.BookingHeaders?.Any(e => e.BookingId == id)).GetValueOrDefault();
        }
    }
}
