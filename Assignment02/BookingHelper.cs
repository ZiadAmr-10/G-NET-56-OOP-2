namespace Assignment02
{
    internal static class BookingHelper
    {
        private static int Counter =0;
        public static double CalcGroupDiscount(int NumberOfTickets, double PricePerTicket)
        {
            double TotalPrice = NumberOfTickets * PricePerTicket;
            if (NumberOfTickets >= 5)
                return TotalPrice -= TotalPrice * 0.10;
            return TotalPrice;
        }
        public static string GenerateBookingReference()
        {
            Counter++;
            return "BK-" + Counter;
        }
    }
}
