using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatGenLib
{
    class AbsPlod
    {
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
    }

    
}

