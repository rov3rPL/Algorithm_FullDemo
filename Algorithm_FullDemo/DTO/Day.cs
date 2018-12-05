namespace Algorithm_FullDemo.DTO
{
    internal struct Day
    {
        internal Day(int value)
        {
            this.Value = value;
        }

        internal int Value { private set; get; }
    }
}
