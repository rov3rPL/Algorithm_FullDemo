namespace Algorithm_FullDemo.Providers
{
    struct FrequencyStandard
    {
        //private default in structs
        char ServiceVariant;
        int MinDays;
        int MaxDays;

        internal FrequencyStandard(char serviceVariant, int minDays, int maxDays)
        {
            ServiceVariant = serviceVariant;
            MinDays = minDays;
            MaxDays = maxDays;
        }
    }
}
