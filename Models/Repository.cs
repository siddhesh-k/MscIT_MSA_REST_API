using REST_API.Models;

namespace REST_API.Models
{
    public class Repository : IRepository
    {
        // private Dictionary<int, Reservations> items;
        private ReservationContext context;

       // public Repository()
       // {
           // this.items = new Dictionary<int, Reservations>();
           //
            //List<Reservations> lstReservation = new List<Reservations>();
            //lstReservation.Add(new Reservations { Id = 1, Name = "Kirti", StartLocation = "Mumbai", EndLocation = "Pune" });
//            lstReservation.Add(new Reservations { Id = 2, Name = "Kirti", StartLocation = "Pune", EndLocation = "Mumbai" });

  //          foreach (var r in lstReservation)
    //        {
      //          AddReservation(r);
        //    }
       // }

        public Repository(ReservationContext ReservationContext)
        {
            this.context = ReservationContext;
        }

        public Reservations AddReservation(Reservations reservation)
        {
            //  if (reservation.Id == 0)
            //{
            //  int key = items.Count;
            //while (items.ContainsKey(key)) { key++; };
            //reservation.Id = key;
            // }
            //items[reservation.Id] = reservation;
            //return reservation;


            context.Reservations.Add(reservation);
            context.SaveChanges();
            return reservation;
        }

        public bool DeleteReservation(int id)
        {
            //return items.Remove(id);
            return true;
        }

        public Reservations? GetReservation(int id)
        {
            //return items.ContainsKey(id) ? items[id] : null;
            return null;
        }

        public IEnumerable<Reservations> GetReservations()
        {
            //return items.Values;
            return null;
        }

        public Reservations UpdateReservation(Reservations reservation)
        {
            //return AddReservation(reservation);
            return null;
        }
    }
}