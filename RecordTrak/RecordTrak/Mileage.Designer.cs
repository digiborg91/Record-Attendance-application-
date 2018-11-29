namespace RecordTrak
{
    partial class Mileage
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
            this.IAmHappylbl = new System.Windows.Forms.Label();
            this.location_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.return_checkbox = new System.Windows.Forms.CheckBox();
            this.return_textbox = new System.Windows.Forms.TextBox();
            this.other_mileage_textBox = new System.Windows.Forms.TextBox();
            this.other_location_textBox = new System.Windows.Forms.TextBox();
            this.mileage_submit_btn = new System.Windows.Forms.Button();
            this.mileage_backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IAmHappylbl
            // 
            this.IAmHappylbl.AutoSize = true;
            this.IAmHappylbl.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IAmHappylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.IAmHappylbl.Location = new System.Drawing.Point(148, 9);
            this.IAmHappylbl.Name = "IAmHappylbl";
            this.IAmHappylbl.Size = new System.Drawing.Size(224, 26);
            this.IAmHappylbl.TabIndex = 8;
            this.IAmHappylbl.Text = "I Am Happy";
            // 
            // location_comboBox
            // 
            this.location_comboBox.FormattingEnabled = true;
            this.location_comboBox.Location = new System.Drawing.Point(251, 185);
            this.location_comboBox.Name = "location_comboBox";
            this.location_comboBox.Size = new System.Drawing.Size(121, 21);
            this.location_comboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Return :";
            // 
            // return_checkbox
            // 
            this.return_checkbox.AutoSize = true;
            this.return_checkbox.Location = new System.Drawing.Point(251, 249);
            this.return_checkbox.Name = "return_checkbox";
            this.return_checkbox.Size = new System.Drawing.Size(15, 14);
            this.return_checkbox.TabIndex = 12;
            this.return_checkbox.UseVisualStyleBackColor = true;
            // 
            // return_textbox
            // 
            this.return_textbox.Location = new System.Drawing.Point(282, 249);
            this.return_textbox.Name = "return_textbox";
            this.return_textbox.Size = new System.Drawing.Size(90, 20);
            this.return_textbox.TabIndex = 13;
            // 
            // other_mileage_textBox
            // 
            this.other_mileage_textBox.Location = new System.Drawing.Point(282, 294);
            this.other_mileage_textBox.Name = "other_mileage_textBox";
            this.other_mileage_textBox.Size = new System.Drawing.Size(90, 20);
            this.other_mileage_textBox.TabIndex = 14;
            // 
            // other_location_textBox
            // 
            this.other_location_textBox.Location = new System.Drawing.Point(127, 294);
            this.other_location_textBox.Name = "other_location_textBox";
            this.other_location_textBox.Size = new System.Drawing.Size(123, 20);
            this.other_location_textBox.TabIndex = 15;
            // 
            // mileage_submit_btn
            // 
            this.mileage_submit_btn.Location = new System.Drawing.Point(297, 343);
            this.mileage_submit_btn.Name = "mileage_submit_btn";
            this.mileage_submit_btn.Size = new System.Drawing.Size(75, 23);
            this.mileage_submit_btn.TabIndex = 16;
            this.mileage_submit_btn.Text = "Submit";
            this.mileage_submit_btn.UseVisualStyleBackColor = true;
            // 
            // mileage_backbtn
            // 
            this.mileage_backbtn.Location = new System.Drawing.Point(67, 11);
            this.mileage_backbtn.Name = "mileage_backbtn";
            this.mileage_backbtn.Size = new System.Drawing.Size(75, 23);
            this.mileage_backbtn.TabIndex = 17;
            this.mileage_backbtn.Text = "Back";
            this.mileage_backbtn.UseVisualStyleBackColor = true;
            this.mileage_backbtn.Click += new System.EventHandler(this.mileage_backbtn_Click);
            // 
            // Mileage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(577, 456);
            this.Controls.Add(this.mileage_backbtn);
            this.Controls.Add(this.mileage_submit_btn);
            this.Controls.Add(this.other_location_textBox);
            this.Controls.Add(this.other_mileage_textBox);
            this.Controls.Add(this.return_textbox);
            this.Controls.Add(this.return_checkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location_comboBox);
            this.Controls.Add(this.IAmHappylbl);
            this.Name = "Mileage";
            this.Text = "Mileage";
            this.Load += new System.EventHandler(this.Mileage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IAmHappylbl;
        private System.Windows.Forms.ComboBox location_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox return_checkbox;
        private System.Windows.Forms.TextBox return_textbox;
        private System.Windows.Forms.TextBox other_mileage_textBox;
        private System.Windows.Forms.TextBox other_location_textBox;
        private System.Windows.Forms.Button mileage_submit_btn;
        private System.Windows.Forms.Button mileage_backbtn;
    }
}