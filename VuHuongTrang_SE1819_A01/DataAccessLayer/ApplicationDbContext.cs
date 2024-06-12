using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal static class ApplicationDbContext
    {
        public static List<Customer> Customers = new List<Customer>()
        {
            new Customer()
            {
                CustomerId = 1,
                CustomerFullName = "Nguyen Van A",
                TelePhone = "0123456789",
                CustomerBirthday = new DateOnly(1999, 1, 1),
                CustomerStatus = true,
                CustomerAddress = "Ha Noi",
                Password = "123456",
                EmailAddress = "vana@gmail.com"
            },
            new Customer()
            {
                CustomerId = 2,
                CustomerFullName = "Nguyen Van B",
                TelePhone ="0123456289",
                CustomerBirthday = new DateOnly(1999, 1, 1),
                CustomerStatus = true,
                CustomerAddress = "Ha Noi",
                Password = "123456",
                EmailAddress = "vanb@gmail.com"
            },
            new Customer()
            {
                CustomerId = 3,
                CustomerFullName = "Nguyen Van C",
                TelePhone = "0123456789",
                CustomerBirthday = new DateOnly(1999, 1, 1),
                CustomerStatus = true,
                CustomerAddress = "Ha Noi",
                Password = "123456",
                EmailAddress = "vanc@gmail.com"
            },

        };
        public static List<RoomInfomation> RoomInfomations = new List<RoomInfomation>()
        {
            new RoomInfomation()
            {
                RoomId = 1,
                RoomNumber = "101",
                RoomDescription = "Phong 1",
                RoomMaxCapacity = 2,
                RoomStatus = true,
                RoomPricePerDate = 100,
                RoomTypeId = 1
            },
            new RoomInfomation()
            {
                RoomId = 2,
                RoomNumber = "102",
                RoomDescription = "Phong 2",
                RoomMaxCapacity = 2,
                RoomStatus = true,
                RoomPricePerDate = 100,
                RoomTypeId = 1
            },
            new RoomInfomation()
            {
                RoomId = 3,
                RoomNumber = "103",
                RoomDescription = "Phong 3",
                RoomMaxCapacity = 2,
                RoomStatus = true,
                RoomPricePerDate = 200,
                RoomTypeId = 2
            },
        };
        public static List<RoomType> RoomTypes = new List<RoomType>()
        {
            new RoomType()
            {
                RoomTypeId = 1,
                RoomTypeName = "Standard",
                TypeDescription = "Phong thuong",
                TypeNote = "Gia re"
            },
            new RoomType()
            {
                RoomTypeId = 2,
                RoomTypeName = "Superior",
                TypeDescription = "Phong cao cap",
                TypeNote = "Gia cao"
            },
        };
        public static List<RoomBooking> RoomBookings = new List<RoomBooking>()
        {
            new RoomBooking()
            {
                RoomId = 1,
                CustomerId = 1,
                CheckInDate = new DateOnly(2021, 1, 1),
                CheckOutDate = new DateOnly(2021, 1, 3)
            },
            new RoomBooking()
            {
                RoomId = 2,
                CustomerId = 2,
                CheckInDate = new DateOnly(2021, 1, 1),
                CheckOutDate = new DateOnly(2021, 1, 3)
            },
            new RoomBooking()
            {
                RoomId = 3,
                CustomerId = 3,
                CheckInDate = new DateOnly(2021, 1, 1),
                CheckOutDate = new DateOnly(2021, 1, 3)
            },
        };
    }
}
