using CsvHelper.Configuration.Attributes;
using System;
using System.Linq;

namespace MS1
{
    public class ResultLine
    {
        [Ignore]
        public int Id { get; set; }

        [Name("t3")]
        public int T3 { get; set; }

        [Name("n3")]
        public int N3 { get; set; }

        [Name("Время простоя")]
        public double Seconds_of_downtime { get; set; }

        [Name("Средняя производительность")]
        public double AveragePerf { get; set; }

        [Name("Очередь досок")]
        public double WoodQueue { get; set; }

        [Name("Очередь веревок")]
        public double RopeQueue { get; set; }


        public int CompareTo(ResultLine resultLine)
        {
            var R = new int[4];
            R[0] = Seconds_of_downtime == resultLine.Seconds_of_downtime
                ? 0 : Seconds_of_downtime < resultLine.Seconds_of_downtime ? 1 : -1;
            R[1] = AveragePerf == resultLine.AveragePerf
                ? 0 : AveragePerf > resultLine.AveragePerf ? 1 : -1;
            R[2] = WoodQueue == resultLine.WoodQueue
                ? 0 : WoodQueue < resultLine.WoodQueue ? 1 : -1;
            R[3] = RopeQueue == resultLine.RopeQueue
                ? 0 : RopeQueue < resultLine.RopeQueue ? 1 : -1;

            return R.All(x => x == 0)
                ? 0 : R.All(x => x == 1 || x == 0)
                    ? 1 : R.All(x => x == -1 || x == 0) ? -1 : 0;
        }
        

    }
}
