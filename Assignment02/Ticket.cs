namespace Assignment02
{
    internal class Ticket
    { 
        private string movieName;
        public TicketType Type { get; set; }
        public SeatLocation Seat {  get; set; }
        private double price;
        public double PriceAfterTax => Price + (Price * 0.14);
        private static int TicketCounter = 0;
        public int TicketId { get; }
        public string MovieName
        {
            get => movieName;  
            set
            {
                if (!string.IsNullOrEmpty(value))
                    movieName = value;
            }
        }
        public double Price
        {
            get => price;
         set
            {
                if(value>0)
                    price = value;   
            }      
        }
        public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
        {
            MovieName = movieName;
            Type = type;
            this.Seat = seat;
            Price = price;
            TicketCounter++;
            TicketId = TicketCounter;
        }
        public static int GetTotalSold() => TicketCounter;
        public void Print()
        {
            Console.WriteLine($"Ticket#{TicketId}|MovieName:{MovieName}|Type:{Type}|Seat:{Seat}|Price:{price}|After Tax(14%){PriceAfterTax}");
        }
        public override string ToString()
        {
            return $"Ticket#{TicketId}|MovieName:{MovieName}|Type:{Type}|Seat:{Seat}|Price:{price}|After Tax(14%){PriceAfterTax}";
        }
    }
    }

