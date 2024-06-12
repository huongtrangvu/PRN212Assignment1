using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IRoomRepository
    {
        public void AddRoom(RoomInfomation room);
        public void UpdateRoom(RoomInfomation room);
        public List<RoomInfomation> GetRooms();
        public void DeleteRoom(RoomInfomation room);
        public RoomInfomation GetRoomById(int id);
    }
}
