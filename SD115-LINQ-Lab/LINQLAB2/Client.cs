using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQLAB2.Models
{
    public class Client
    {
       
            public string Name { get; set; }
            public List<Reservation> Reservations { get; set; }
            public long CreditCard;
            public int Id { get; set; }

            public Client(string name, long creditCard, int ID)
            {
                this.Name = name;
                this.Id = ID;
                this.CreditCard = creditCard;
            }
        

    }
}
