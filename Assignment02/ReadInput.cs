namespace Assignment02
{
    internal static class ReadInput
    {

        public static string ReadMovieName()
        {
            string MovieName;
            while (true)
            {
                Console.WriteLine("Enter a Movie Name : ");
                MovieName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(MovieName))
                    return MovieName;
                Console.WriteLine("Invalid! Try again :");
            }
        }
        public static TicketType ReadTicketType()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Enter Ticket Type From (Standard=0,Vip=1,IMAX=2)");
                bool isValid = int.TryParse(Console.ReadLine(), out choice);
                if (isValid && choice >= 0 && choice <= 2)
                    return (TicketType)choice;
                Console.WriteLine("Invalid Number ! Try Again : ");
            }
        }
        public static char ReadSeatRow()
        {
            char row;
            while (true)
            {
                Console.WriteLine("Enter a seat Row : ");
                bool isValid = char.TryParse(Console.ReadLine(), out row);
                if (isValid)
                {
                    row = char.ToUpper(row);
                    if (row >= 'A' && row <= 'Z')
                    {
                        return row;
                    }
                }
                Console.WriteLine("InValid Row! TryAgain :");
            }
        }
        public static int ReadSeatNumber()
        {
            int num;
            while (true)
            {
                Console.WriteLine("Enter SeatNumber : ");
                bool isValid = int.TryParse(Console.ReadLine(), out num);
                if (isValid && num > 0)
                    return num;
                Console.WriteLine("InValid Number ! TryAgain : ");
            }
        }
        public static double ReadPrice()
        {
            double price;
            while (true)
            {
                Console.WriteLine("Enter Price : ");
                bool isValid = double.TryParse(Console.ReadLine(), out price);
                if (isValid && price > 0)
                    return price;
                Console.WriteLine("InValid Price! TryAgain:");
            }
        }
        public static Ticket ReadTicket()
        {
            string moviename=ReadMovieName();
            TicketType type=ReadTicketType();
            char row=ReadSeatRow();
            int seatNum=ReadSeatNumber();
            SeatLocation Seat=new SeatLocation(row,seatNum);
            double price = ReadPrice();
            return new Ticket(moviename, type,Seat,price);
        }
    }
}


    

