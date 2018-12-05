using System;
using System.Collections.Generic;
using System.Linq;
using xline.IO;
using Algorithm_FullDemo.DTO;
using Algorithm_FullDemo.Algorithm;

namespace Algorithm_FullDemo.ParsingInput
{
    internal class InputParser
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static /*readonly*/ int MAX_OFFSET_BETWEEN_SERVICES
            = 30;
        //= 15;
        //= 60;

        internal InputParser()
        {

        }

        internal SlotProvider Parse(string[] args)
        {
            if (args.Length > 0)
            {
                var args_MAX_OFFSET_BETWEEN_SERVICES = Convert.ToInt32(args[0]);
                MAX_OFFSET_BETWEEN_SERVICES = args_MAX_OFFSET_BETWEEN_SERVICES;
            }
            log.Info("[START]");

            var reader = new DelimitedFileReader(@"Tests\input.csv", 0, 0, ',');
            reader.SkipEmptyRows = true;
            List<CSVData> list = reader.ToList<CSVData>();
            list.Remove(list.FindLast(x => true)); //trial thing?
            
            var slotProvider = new SlotProvider(list);
            //var someSlots = slotProvider.Provide(new Day(4));
            return slotProvider;
        }

        //private static ServiceVariantSlot CSVDataToSlot(CSVData data)
        //{
        //    return new ServiceVariantSlot()
        //    {
        //        DayNo = Convert.ToInt32(data.DayNo),
        //        Code = data.Code[0],
        //        StartTime = CalculateNumberOfMinutes(
        //            Convert.ToInt32(data.StartTimeHour),
        //            Convert.ToInt32(data.StartTimeMinutes)
        //        ),
        //        EndTime = CalculateNumberOfMinutes(
        //            Convert.ToInt32(data.EndTimeHour),
        //            Convert.ToInt32(data.EndTimeMinutes)
        //        )
        //    };
        //}

        //private static int CalculateNumberOfMinutes(int hours, int minutes = 0)
        //{
        //    return 60 * hours + minutes;
        //}
    }
}
