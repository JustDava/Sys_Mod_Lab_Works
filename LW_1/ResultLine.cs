using CsvHelper.Configuration.Attributes;

namespace MS1
{
    public class ResultLine
    {
        [Name("X1")]
        public int X1 { get; set; }

        [Name("X2")]
        public int X2 { get; set; }

        [Name("X3")]
        public int X3 { get; set; }

        [Name("X4")]
        public int X4 { get; set; }

        [Name("X5")]
        public int X5 { get; set; }

        [Name("X6")]
        public int X6 { get; set; }

        [Name("Y")]
        public int Y { get; set; }

        public ResultLine(
            double x1,
            double x2,
            double x3,
            double x4,
            double x5,
            double x6,
            double y)
        {
            Y = (int)y;
            X1 = (int)x1;
            X2 = (int)x2;
            X3 = (int)x3;
            X4 = (int)x4;
            X5 = (int)x5;
            X6 = (int)x6;
        }
    }
}
