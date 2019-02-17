using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatGenLib
{
    public class Person
    {
        [DisplayName("Имя")]
        [Description("Имя")]
        public string Name { get; set; } = "Михаил";

        [DisplayName("Отчество")]
        [Description("Отчество")]
        public string SurName { get; set; } = "Петрович";

        [DisplayName("Фамилия")]
        [Description("Фамилия")]
        public string LastName { get; set; } = "Иванов";

        [DisplayName("Группа")]
        [Description("Группа")]
        public string Group { get; set; } = "025-012";

        [DisplayName("Факультет")]
        [Description("Факультет")]
        public string Fac { get; set; } = "ФИиСТ";

        [DisplayName("Хэшкод (для чтения)")]
        [Description("Хэшкод (только для чтения")]
        [ReadOnly(true)]
        [RefreshProperties(RefreshProperties.All)]
        public string HCode => GetHashCode().ToString();
    }
}
