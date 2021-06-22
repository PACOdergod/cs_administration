using System;

namespace coWorking.Models
{
    public class Reservation{
        public Guid ReservationId {get;set;}
        public DateTime ReservationDate {get;set;}
        public Guid DeskId {get;set;}
        public Guid UserId {get;set;}

    }
}