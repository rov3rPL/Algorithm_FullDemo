using System;
using System.Collections.Generic;
using System.Linq;
using Algorithm_FullDemo.DTO;
using Algorithm_FullDemo.ParsingInput;

namespace Algorithm_FullDemo.Providers
{
    internal class SlotProvider
    {
        private Dictionary<Day, ServiceVariantSlot[]> slotsDictionary;

        internal SlotProvider(List<CSVData> data)
        {
            this.slotsDictionary = data.Select(CSVDataToSlot).GroupBy(s => new Day(s.DayNo)).ToDictionary(g => g.Key, e => e.OrderBy(s=>s.StartTime).ToArray());
        }

        internal ServiceVariantSlot[] Provide(Day dayNo)
        {
            return this.slotsDictionary[dayNo];
        }

        #region Uninportant helpers

        private ServiceVariantSlot CSVDataToSlot(CSVData data)
        {
            return new ServiceVariantSlot()
            {
                DayNo = Convert.ToInt32(data.DayNo),
                ServiceVariant = data.ServiceVariant[0],
                StartTime = CalculateNumberOfMinutes(
                    Convert.ToInt32(data.StartTimeHour),
                    Convert.ToInt32(data.StartTimeMinutes)
                ),
                EndTime = CalculateNumberOfMinutes(
                    Convert.ToInt32(data.EndTimeHour),
                    Convert.ToInt32(data.EndTimeMinutes)
                )
            };
        }

        private int CalculateNumberOfMinutes(int hours, int minutes = 0)
        {
            return 60 * hours + minutes;
        }

        #endregion
    }
}
