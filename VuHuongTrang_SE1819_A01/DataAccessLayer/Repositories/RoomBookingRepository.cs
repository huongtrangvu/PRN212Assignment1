using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RoomBookingRepository : IRoomBookingRepository
    {
        public List<RoomBooking> GetRoomBookings()
        {
            return ApplicationDbContext.RoomBookings;
        }

        public List<RoomBooking> GetRoomBookingsByCustomerId(int customerId)
        {
            return ApplicationDbContext.RoomBookings.Where(rb => rb.CustomerId == customerId).ToList();
        }

        public List<RoomBooking> GetRoomBookingsByDate(DateOnly beginDate, DateOnly endDate)
        {
            return ApplicationDbContext.RoomBookings.Where(rb => rb.CheckInDate >= beginDate || rb.CheckOutDate <= endDate).ToList();
        }
    }
}
