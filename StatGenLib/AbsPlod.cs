using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatGenLib
{
    public class AbsPlod
    {
        private static readonly Dictionary<int,int> DataDictionary = new Dictionary<int, int>()
        {
            {2003, 5200},
            {2004, 3355},
            {2005, 6106},
            {2006, 4191},
            {2007, 6402},
            {2008, 5663}
        };

        [DisplayName("Год")]
        [Description("Год")]
        public int Year{ get; set; }

        [DisplayName("Макс уровень паводка см")]
        [Description("Макс уровень паводка см")]
        public int MaxLevel { get; set; }

        [DisplayName("Длительность паводка, дни")]
        [Description("Длительность паводка, дни")]
        public int TimeTo { get; set; }

        [DisplayName("Средний уровень паводка см")]
        [Description("Средний уровень паводка см")]
        public int MidLevel { get; set; }

        [DisplayName("Плодовитость, тыс. икринок")]
        [Description("Плодовитость, тыс. икринок")]
        public int Plod { get; set; }

        public AbsPlod()
        {
            Year = 2003;
            MaxLevel = 588;
            TimeTo = 80;
            MidLevel = 235;
            Plod = 5200;
        }

        public int GenerateAbsPod()
        {
            if (AbsPlod.DataDictionary.ContainsKey(Year))
            {
                Plod = AbsPlod.DataDictionary[Year];
            }
            else
            {
                Plod = (int)(11842 - 12.57 * MaxLevel + 270.85 * (Year - 1000));
            }
            return Plod;
        }
    }

  
}

