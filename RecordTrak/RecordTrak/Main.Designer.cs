namespace RecordTrak
{
    partial class Main
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
            this.SignInbtn = new System.Windows.Forms.Button();
            this.SignOutbtn = new System.Windows.Forms.Button();
            this.Alertsbtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Holidaybtn = new System.Windows.Forms.Button();
            this.timelbl = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timetickerlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Datelbl = new System.Windows.Forms.Label();
            this.IAmHappylbl = new System.Windows.Forms.Label();
            this.mileagebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignInbtn
            // 
            this.SignInbtn.Location = new System.Drawing.Point(183, 169);
            this.SignInbtn.Name = "SignInbtn";
            this.SignInbtn.Size = new System.Drawing.Size(75, 23);
            this.SignInbtn.TabIndex = 0;
            this.SignInbtn.Text = "Sign In";
            this.SignInbtn.UseVisualStyleBackColor = true;
            this.SignInbtn.Click += new System.EventHandler(this.SignInbtn_Click);
            // 
            // SignOutbtn
            // 
            this.SignOutbtn.Location = new System.Drawing.Point(298, 169);
            this.SignOutbtn.Name = "SignOutbtn";
            this.SignOutbtn.Size = new System.Drawing.Size(75, 23);
            this.SignOutbtn.TabIndex = 1;
            this.SignOutbtn.Text = "Sign Out";
            this.SignOutbtn.UseVisualStyleBackColor = true;
            // 
            // Alertsbtn
            // 
            this.Alertsbtn.Location = new System.Drawing.Point(183, 265);
            this.Alertsbtn.Name = "Alertsbtn";
            this.Alertsbtn.Size = new System.Drawing.Size(98, 23);
            this.Alertsbtn.TabIndex = 2;
            this.Alertsbtn.Text = "Alerts";
            this.Alertsbtn.UseVisualStyleBackColor = true;
            this.Alertsbtn.Click += new System.EventHandler(this.Alertsbtn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Holidaybtn
            // 
            this.Holidaybtn.Location = new System.Drawing.Point(298, 265);
            this.Holidaybtn.Name = "Holidaybtn";
            this.Holidaybtn.Size = new System.Drawing.Size(98, 23);
            this.Holidaybtn.TabIndex = 7;
            this.Holidaybtn.Text = "Holidays";
            this.Holidaybtn.UseVisualStyleBackColor = true;
            this.Holidaybtn.Click += new System.EventHandler(this.Holidaybtn_Click);
            // 
            // timelbl
            // 
            this.timelbl.Location = new System.Drawing.Point(0, 0);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(100, 23);
            this.timelbl.TabIndex = 1;
            // 
            // timelabel
            // 
            this.timelabel.Location = new System.Drawing.Point(0, 0);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(100, 23);
            this.timelabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // timetickerlbl
            // 
            this.timetickerlbl.AutoSize = true;
            this.timetickerlbl.Location = new System.Drawing.Point(183, 220);
            this.timetickerlbl.Name = "timetickerlbl";
            this.timetickerlbl.Size = new System.Drawing.Size(26, 13);
            this.timetickerlbl.TabIndex = 8;
            this.timetickerlbl.Text = "time";
            this.timetickerlbl.Click += new System.EventHandler(this.timetickerlbl_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Location = new System.Drawing.Point(186, 370);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(30, 13);
            this.Datelbl.TabIndex = 9;
            this.Datelbl.Text = "Date";
            this.Datelbl.Click += new System.EventHandler(this.Datelbl_Click);
            // 
            // IAmHappylbl
            // 
            this.IAmHappylbl.AutoSize = true;
            this.IAmHappylbl.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IAmHappylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.IAmHappylbl.Location = new System.Drawing.Point(172, 9);
            this.IAmHappylbl.Name = "IAmHappylbl";
            this.IAmHappylbl.Size = new System.Drawing.Size(224, 26);
            this.IAmHappylbl.TabIndex = 10;
            this.IAmHappylbl.Text = "I Am Happy";
            // 
            // mileagebtn
            // 
            this.mileagebtn.Location = new System.Drawing.Point(414, 265);
            this.mileagebtn.Name = "mileagebtn";
            this.mileagebtn.Size = new System.Drawing.Size(98, 23);
            this.mileagebtn.TabIndex = 11;
            this.mileagebtn.Text = "Mileage";
            this.mileagebtn.UseVisualStyleBackColor = true;
            this.mileagebtn.Click += new System.EventHandler(this.mileagebtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(583, 440);
            this.Controls.Add(this.mileagebtn);
            this.Controls.Add(this.IAmHappylbl);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.timetickerlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.Holidaybtn);
            this.Controls.Add(this.Alertsbtn);
            this.Controls.Add(this.SignOutbtn);
            this.Controls.Add(this.SignInbtn);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignInbtn;
        private System.Windows.Forms.Button SignOutbtn;
        private System.Windows.Forms.Button Alertsbtn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Holidaybtn;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timetickerlbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label IAmHappylbl;
        private System.Windows.Forms.Button mileagebtn;
    }
}