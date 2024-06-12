using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class RoomBookingService : IRoomBookingService
    {
        private readonly IRoomBookingRepository _roomBookingRepository;
        public RoomBookingService()
        {
            _roomBookingRepository = new RoomBookingRepository();
        }
        public List<RoomBooking> GetRoomBookings()
        {
            return _roomBookingRepository.GetRoomBookings();
        }

        public List<RoomBooking> GetRoomBookingsByCustomerId(int customerId)
        {
            return _roomBookingRepository.GetRoomBookingsByCustomerId(customerId);
        }

        public List<RoomBooking> GetRoomBookingsByDate(DateOnly beginDate, DateOnly endDate)
        {
            return _roomBookingRepository.GetRoomBookingsByDate(beginDate, endDate);
        }
    }
}
