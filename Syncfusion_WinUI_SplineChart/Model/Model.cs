using System;

namespace WinUI_SplineChart
{
    public class Model
    {
        public string Year { get; set; }

        public double Counts { get; set; }

        public Model(string name, double count)
        {
            Year = name;
            Counts = count;
        }
    }
}
