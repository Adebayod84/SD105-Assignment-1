using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Models
{
        public class Hotel
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public List<Room> Rooms { get; set; }
            public List<Client> Clients { get; set; }
            public List<Reservation> Reservations { get; set; }

            public Hotel(string name, string address)
            {
                this.Name = name;
                this.Address = address;
                this.Rooms = new List<Room>();
                this.Clients = new List<Client>();
                this.Reservations = new List<Reservation>();
            }

        public Room GetRoom(string roomNumber)
        {
            return Rooms.FirstOrDefault(r => r.Number == roomNumber);
        }


        public Client getClient(int ID)
        {
            return Clients.SingleOrDefault(c => c.Id == ID);
        }


        public Reservation getReservation(int ID)
        {
            return Reservations.SingleOrDefault(rs => rs.Id == ID);
        }

        public List<Room> GetVacantRooms()
        {
            var voidRoom = Rooms.Where(r => r.Occupied == false).ToList();
            return voidRoom;
            
        }

        public List<Client> TopThreeClients(int y)
        {
            var topNClients = Clients.OrderByDescending(c => c.Reservations).Take(y).ToList();
            return topNClients;
        }


        public Reservation AutomaticReservation(int id, int occupants)
        {
            return;
        }

    }

}

