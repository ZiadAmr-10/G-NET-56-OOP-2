namespace Assignment02
{
    internal struct SeatLocation
    {                   
        public Char row;
        public int number;
        public SeatLocation(char row, int number)
        {
            this.row = row;
            this.number = number;
        }
        public override string ToString()
        {
            return $"{row}-{number}";
        }
    }
}
