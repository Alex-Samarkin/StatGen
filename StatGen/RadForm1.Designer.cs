namespace StatGen
{
    partial class RadForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StatGenLib.Person person1 = new StatGenLib.Person();
            this.personControl1 = new StatGenLib.PersonControl();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // personControl1
            // 
            this.personControl1.Location = new System.Drawing.Point(14, 14);
            this.personControl1.Margin = new System.Windows.Forms.Padding(5);
            this.personControl1.Name = "personControl1";
            this.personControl1.Padding = new System.Windows.Forms.Padding(2);
            person1.LastName = "Иванов";
            person1.Name = "";
            person1.SurName = "";
            this.personControl1.Person = person1;
            this.personControl1.Size = new System.Drawing.Size(769, 532);
            this.personControl1.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 560);
            this.Controls.Add(this.personControl1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private StatGenLib.PersonControl personControl1;
    }
}