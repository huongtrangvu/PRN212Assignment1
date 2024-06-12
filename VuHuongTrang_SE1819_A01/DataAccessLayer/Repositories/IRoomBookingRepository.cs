using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IRoomBookingRepository
    {
        public List<RoomBooking> GetRoomBookings();
        public List<RoomBooking> GetRoomBookingsByCustomerId(int customerId);
        public List<RoomBooking> GetRoomBookingsByDate(DateOnly beginDate, DateOnly endDate);
    }
}
