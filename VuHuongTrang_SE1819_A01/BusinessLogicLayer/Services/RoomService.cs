using BusinessLogicLayer.Services;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService()
        {
            _roomRepository = new RoomRepository();
        }
        public void AddRoom(RoomInfomation room)
        {
            _roomRepository.AddRoom(room);
        }

        public void DeleteRoom(RoomInfomation room)
        {
            _roomRepository.DeleteRoom(room);
        }

        public RoomInfomation GetRoomById(int id)
        {
            return _roomRepository.GetRoomById(id);
        }

        public List<RoomInfomation> GetRooms()
        {
            return _roomRepository.GetRooms();
        }

        public void UpdateRoom(RoomInfomation room)
        {
            _roomRepository.UpdateRoom(room);
        }
    }
}
