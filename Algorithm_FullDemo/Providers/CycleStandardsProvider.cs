using System.Collections.Generic;

namespace Algorithm_FullDemo.Providers
{
    internal class CycleStandardsProvider
    {
        static FrequencyStandard aFS = new FrequencyStandard(serviceVariant: 'A', minDays: 2, maxDays: 4);
        //Mock
        //TODO: char -> ServiceVariant struct
        private Dictionary<char, FrequencyStandard> standards = new Dictionary<char, FrequencyStandard>()
        {
            { 'A', new FrequencyStandard(serviceVariant: 'A', minDays: 2, maxDays: 4) },
            { 'B', new FrequencyStandard(serviceVariant: 'B', minDays: 2, maxDays: 4) },
            { 'C', new FrequencyStandard(serviceVariant: 'C', minDays: 2, maxDays: 4) },
            { 'D', new FrequencyStandard(serviceVariant: 'D', minDays: 2, maxDays: 4) },
            { 'E', new FrequencyStandard(serviceVariant: 'E', minDays: 2, maxDays: 4) },
            { 'F', new FrequencyStandard(serviceVariant: 'F', minDays: 2, maxDays: 4) },
            { 'G', new FrequencyStandard(serviceVariant: 'G', minDays: 2, maxDays: 4) },
            { 'H', new FrequencyStandard(serviceVariant: 'H', minDays: 2, maxDays: 4) },
        };
    
        internal FrequencyStandard ProvideFor(char serviceVariant)
        {
            return standards[serviceVariant];

            //calculation of intersection of frequency standard for block services is outside this scope
            //and shall be considered in Cycle algorithm leter
            //uninportant for now
        }

    }
}
