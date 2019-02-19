using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatGenLib
{
    public class Fish
    {
        [DisplayName("Год")]
        [Description("Год 2003-2008")]
        public int Year { get; set; }

        [DisplayName("Возраст")]
        [Description("Возраст 3-8")]
        public int Age { get; set; }

        [DisplayName("Длина")]
        [Description("Средняя длина возрастной группы")]
        public int L { get; set; }

        [DisplayName("Sx Длина")]
        [Description("Sx Средняя длина возрастной группы")]
        public int SxL { get; set; }

        [DisplayName("Масса")]
        [Description("Средняя масса в группе")]
        public int M { get; set; }

        [DisplayName("Sx Масса")]
        [Description("Sx Средняя масса в группе")]
        public int SxM { get; set; }

        [DisplayName("Встречаемость")]
        [Description("Частота появления в улове, процент")]
        public int Freq { get; set; }
    }
}
