using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class RoomInfomation
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string RoomDescription { get; set; }
        public int RoomMaxCapacity { get; set; }   
        public bool RoomStatus { get; set; }
        public decimal RoomPricePerDate { get; set; }
        public int RoomTypeId { get; set; }
    }
}
