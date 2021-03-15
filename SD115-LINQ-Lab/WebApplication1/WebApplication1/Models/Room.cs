using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Room
    {
        public string Number { get; set; }
        public int Capacity { get; set; }
        public bool Occupied { get; set; }
        public double Price { get; }
        public List<Reservation> Reservations { get; }

        public Room(string roomNumber, int capacity)
        {
            this.Number = roomNumber;
            this.Capacity = capacity;
        }
    }
}
