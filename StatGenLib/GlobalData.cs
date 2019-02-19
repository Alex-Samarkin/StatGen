using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatGenLib
{
    public static class GlobalData
    {
        static GlobalData()
        {
            Setup_AbsPlod();
        }
        public static BindingList<AbsPlod> AbsPlods { get; set; }

        private static void Setup_AbsPlod()
        {
            AbsPlod item = new AbsPlod()
            {
                Year = 2003,
                MaxLevel = 588,
                MidLevel = 235,
                Plod = 5250,
                TimeTo = 80
            };
            AbsPlods.Add(item);
            item = new AbsPlod()
            {
                Year = 2004,
                MaxLevel = 766,
                MidLevel = 320,
                Plod = 3355,
                TimeTo = 88
            };
            AbsPlods.Add(item);
            item = new AbsPlod()
            {
                Year = 2005,
                MaxLevel = 633,
                MidLevel = 178,
                Plod = 6106,
                TimeTo = 72
            };
            AbsPlods.Add(item);
            item = new AbsPlod()
            {
                Year = 2006,
                MaxLevel = 708,
                MidLevel = 309,
                Plod = 4191,
                TimeTo = 96
            };
            AbsPlods.Add(item);
            item = new AbsPlod()
            {
                Year = 2007,
                MaxLevel = 681,
                MidLevel = 374,
                Plod = 6402,
                TimeTo = 88
            };
            AbsPlods.Add(item);
            item = new AbsPlod()
            {
                Year = 2008,
                MaxLevel = 623,
                MidLevel = 184,
                Plod = 5663,
                TimeTo = 64
            };
            AbsPlods.Add(item);

        }
    }
}
