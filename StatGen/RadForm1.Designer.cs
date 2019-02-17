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
            this.button1 = new System.Windows.Forms.Button();
            this.radPropertyGrid1 = new Telerik.WinControls.UI.RadPropertyGrid();
            this.personControl1 = new StatGenLib.PersonControl();
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radPropertyGrid1
            // 
            this.radPropertyGrid1.Location = new System.Drawing.Point(12, 124);
            this.radPropertyGrid1.Name = "radPropertyGrid1";
            this.radPropertyGrid1.SelectedObject = this.button1;
            this.radPropertyGrid1.Size = new System.Drawing.Size(200, 300);
            this.radPropertyGrid1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.radPropertyGrid1.TabIndex = 3;
            // 
            // personControl1
            // 
            this.personControl1.Location = new System.Drawing.Point(268, 57);
            this.personControl1.Margin = new System.Windows.Forms.Padding(5);
            this.personControl1.Name = "personControl1";
            this.personControl1.Padding = new System.Windows.Forms.Padding(2);
            this.personControl1.Size = new System.Drawing.Size(270, 450);
            this.personControl1.TabIndex = 4;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 560);
            this.Controls.Add(this.personControl1);
            this.Controls.Add(this.radPropertyGrid1);
            this.Controls.Add(this.button1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.UI.RadPropertyGrid radPropertyGrid1;
        private StatGenLib.PersonControl personControl1;
    }
}