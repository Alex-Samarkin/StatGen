using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StatGenLib;

namespace StatGen
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

  
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        //this.personControl1.radPropertyGrid1.BeginEdit();
                        ((Person) this.personControl1.radPropertyGrid1.SelectedObject).Group = "4155";
                        this.personControl1.Person.Name = "gdjhjkdhgjdhdkjhdgdkjghdkj";
                        //bool res = this.personControl1.radPropertyGrid1.EndEdit();
                        //this.personControl1.radPropertyGrid1.Refresh();

        }
    }
}
