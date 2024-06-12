using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        public void AddRoom(RoomInfomation room)
        {
            ApplicationDbContext.RoomInfomations.Add(room);
        }

        public void DeleteRoom(RoomInfomation room)
        {
            var roomToDelete = ApplicationDbContext.RoomInfomations.FirstOrDefault(r => r.RoomId == room.RoomId);
            if (roomToDelete != null)
            {
                roomToDelete.RoomStatus = false;
            }
        }

        public RoomInfomation? GetRoomById(int id)
        {
            return ApplicationDbContext.RoomInfomations.FirstOrDefault(r => r.RoomId == id);
        }

        public List<RoomInfomation> GetRooms()
        {
            return ApplicationDbContext.RoomInfomations;
        }

        public void UpdateRoom(RoomInfomation room)
        {
            var roomToUpdate = ApplicationDbContext.RoomInfomations.FirstOrDefault(r => r.RoomId == room.RoomId);
            if (roomToUpdate != null)
            {
                roomToUpdate.RoomNumber = room.RoomNumber;
                roomToUpdate.RoomDescription = room.RoomDescription;
                roomToUpdate.RoomMaxCapacity = room.RoomMaxCapacity;
                roomToUpdate.RoomStatus = room.RoomStatus;
                roomToUpdate.RoomPricePerDate = room.RoomPricePerDate;
                roomToUpdate.RoomTypeId = room.RoomTypeId;
            }
        }
    }
}
