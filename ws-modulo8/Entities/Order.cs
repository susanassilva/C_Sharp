using System;
using ws_modulo8.Entities.Enums;

namespace ws_modulo8.Entities
{
    class Order
    {
        public int Id { get; set; }

        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id 
                   + ", " 
                   + Moment 
                   + ", " 
                   + Status;
        }
    }

    
}
