namespace Assignment02
{
    internal class Cinema
    {
        private Ticket[] tickets = new Ticket[20];
        public Ticket this[int index]
        {
            get
            {
                if (index < 0||index>=tickets.Length)
                    return null;
                else
                    return tickets[index];
            }
            set
            {
                if (index >=0 && index<tickets.Length)
                    tickets[index] = value;
            }
        }
        public Ticket this[string name]
        {
            get {
                for (int i = 0; i < tickets.Length; i++)
                {
                    if (tickets[i] != null&&name == tickets[i].MovieName)
                        return tickets[i];
                }
                return null;
                }
        }
        public bool AddTicket(Ticket T)
        {
            for (int i = 0;i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = T;
                    return true;
                }
            }
            return false;
        }


        }
    }

