using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatGenLib
{
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();

            this.radPropertyGrid1.SelectedObject = Person;
        }

        public Person Person { get; set; } = new Person();
    }
}
