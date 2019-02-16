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
        public string Name { get; set; } = "";

        [DisplayName("Отчество")]
        [Description("Отчество")]
        public string SurName { get; set; } = "";

        [DisplayName("Фамилия")]
        [Description("Фамилия")]
        public string LastName { get; set; } = "Иванов";



    }
}
