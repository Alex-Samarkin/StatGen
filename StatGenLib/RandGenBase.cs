using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StatGenLib
{
    public class RandGenBase
    {
        public RandGenBase()
        {
            Seed = 0;
            Setup(Seed);

            Mean = 0;
            Sx = 1;

            MinLimit = -3;
            MaxLimit = 3;
        }

        [DisplayName("Seed")]
        [Description("Seed")]
        public int Seed { get; set; }

        public Random Random { get; set; }

        public void Setup(int seed)
        {
            Seed = seed;
            Random = new Random(Seed);
        }

        [DisplayName("Mean")]
        [Description("Mean")]
        public int Mean { get; set; }

        [DisplayName("Sx")]
        [Description("Sx")]
        public int Sx { get; set; }

        [DisplayName("MinLimit")]
        [Description("MinLimit")]
        public int MinLimit { get; set; }

        [DisplayName("MaxLimit")]
        [Description("MaxLimit")]
        public int MaxLimit { get; set; }

        public double GetNormal(bool reset = false)
        {
            if(reset) Random = new Random(Seed);

            int N = 5;
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += (Random.NextDouble() - 0.5)*2.0;
            }

            return sum / N*3.0;
        }

        public int Next(bool reset = false)
        {
            int res = (int) Math.Round(GetNormal(reset) * Sx);
            if (res<MinLimit)
            {
                res = MinLimit;
            }

            if (res>MaxLimit)
            {
                res = MaxLimit;
            }

            return res;
        }

    }
}
