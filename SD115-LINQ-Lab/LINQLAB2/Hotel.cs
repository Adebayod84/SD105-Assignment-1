using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQLAB2.Models
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
            try
            {
                return Rooms.FirstOrDefault(r => r.Number == roomNumber);
            }

            catch (Exception)
            {

                throw new Exception($"Multiple Ids are having {roomNumber}");
            }

        }

        public Client getClient(int ID)
        {
            try
            {
                return Clients.SingleOrDefault(c => c.Id == ID);
            }
            catch
            {
                throw new Exception($"This {ID} belongs to more than one client");
            }
           
        }


        public Reservation getReservation(int ID)
        {
            try
            {
                return Reservations.SingleOrDefault(rs => rs.Id == ID);
            }
            catch
            {
                throw new Exception($"Id {ID} is attached to multiple resewrvation");
            }
            
        }

        public List<Room> GetVacantRooms()
        {
            var voidRoom = Rooms.Where(r => r.Occupied == false).ToList();
            return voidRoom;
        }

    

    public List<Client> TopThreeClients(int y)
    {
            var topNClients = Clients.OrderByDescending(c => c.Reservations).Take(y).ToList();
                if (topNClients.Count == 0)
                throw new Exception("Top clients doesnt exist");
            return topNClients;

    }


    public Reservation AutomaticReservation(int id, int occupants)
    {
            var result = Rooms.Where(r => r.Occupied == false && r.Capacity <= occupants).FirstOrDefault();
            var newClient = Clients.Where(c => c.Id == id).FirstOrDefault();

            var newReservation = new Reservation(result, newClient, occupants, true, id);
            return newReservation;
    }


        public void Checkin(string clientName)
        {
            return 
        }

        public void CheckoutRoom(int roomNumber)
        {
             Clients.Select(c => c.Id == roomNumber);
        }

        public void CkeckoutRoom(string clientName)
        {
            if ()
        }

        public int TotalCapacityRemaining(int capacity, int occupant)
        {
            var capRoom = Rooms.Select(r => r.Capacity == capacity - occupant && r.Occupied == true);
            return capRoom;
        }

        public int AverageOccupancyPercentage(double rate)
        {
            return Clients.Select(c => c.Id == rate).Count();
        }
    }
}

