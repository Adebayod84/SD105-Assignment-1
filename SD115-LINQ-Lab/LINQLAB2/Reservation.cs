using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQLAB2.Models
{
    public class Reservation
    {
        public DateTime Date { get; set; }
        public int Occupants { get; set; }
        public bool Current { get; set; }
        public Client Client { get; }
        public Room Room { get; }
        public bool IsVIP { get; set; }
        public int Id { get; set; }
        
      

        public Reservation(Room room, Client client, int occupants, bool current, int id, , DateTime timeStamp)
        {
            Room = room;
            Client = client;
            Current = current;
            Id = id;
            Occupants = occupants;
            Date = timeStamp;
        }
    }
}
