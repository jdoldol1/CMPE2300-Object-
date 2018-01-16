namespace _2300_ICA01_JohnDoldol
{
    partial class tlabel
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
            this.components = new System.ComponentModel.Container();
            this.casio = new System.Windows.Forms.Timer(this.components);
            this.flabel = new System.Windows.Forms.Label();
            this.clabel = new System.Windows.Forms.Label();
            this.labelt = new System.Windows.Forms.Label();
            this.labelv = new System.Windows.Forms.Label();
            this.labela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // casio
            // 
            this.casio.Interval = 20;
            this.casio.Tick += new System.EventHandler(this.casio_Tick);
            // 
            // flabel
            // 
            this.flabel.AutoSize = true;
            this.flabel.Location = new System.Drawing.Point(15, 13);
            this.flabel.Name = "flabel";
            this.flabel.Size = new System.Drawing.Size(130, 13);
            this.flabel.TabIndex = 0;
            this.flabel.Text = "Welcome to Circle Drawer";
            // 
            // clabel
            // 
            this.clabel.AutoSize = true;
            this.clabel.Location = new System.Drawing.Point(15, 85);
            this.clabel.Name = "clabel";
            this.clabel.Size = new System.Drawing.Size(71, 13);
            this.clabel.TabIndex = 1;
            this.clabel.Text = "Total Circles: ";
            // 
            // labelt
            // 
            this.labelt.AutoSize = true;
            this.labelt.Location = new System.Drawing.Point(260, 90);
            this.labelt.Name = "labelt";
            this.labelt.Size = new System.Drawing.Size(13, 13);
            this.labelt.TabIndex = 2;
            this.labelt.Text = "0";
            // 
            // labelv
            // 
            this.labelv.AutoSize = true;
            this.labelv.Location = new System.Drawing.Point(15, 157);
            this.labelv.Name = "labelv";
            this.labelv.Size = new System.Drawing.Size(107, 13);
            this.labelv.TabIndex = 3;
            this.labelv.Text = "Average Ball Speed: ";
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(260, 157);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(13, 13);
            this.labela.TabIndex = 4;
            this.labela.Text = "0";
            // 
            // tlabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 223);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.labelv);
            this.Controls.Add(this.labelt);
            this.Controls.Add(this.clabel);
            this.Controls.Add(this.flabel);
            this.Name = "tlabel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer casio;
        private System.Windows.Forms.Label flabel;
        private System.Windows.Forms.Label clabel;
        private System.Windows.Forms.Label labelt;
        private System.Windows.Forms.Label labelv;
        private System.Windows.Forms.Label labela;
    }
}

