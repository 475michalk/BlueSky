namespace MyFlight.GUI
{
    partial class timeflight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timeflight));
            this.txt_timeon = new System.Windows.Forms.TextBox();
            this.txt_timeoff = new System.Windows.Forms.TextBox();
            this.txt_numberhour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.CheckBox();
            this.btn_enternew = new System.Windows.Forms.Button();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmb_day = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_timeon
            // 
            this.txt_timeon.Location = new System.Drawing.Point(31, 70);
            this.txt_timeon.Name = "txt_timeon";
            this.txt_timeon.Size = new System.Drawing.Size(134, 20);
            this.txt_timeon.TabIndex = 1;
            // 
            // txt_timeoff
            // 
            this.txt_timeoff.Location = new System.Drawing.Point(31, 105);
            this.txt_timeoff.Name = "txt_timeoff";
            this.txt_timeoff.Size = new System.Drawing.Size(134, 20);
            this.txt_timeoff.TabIndex = 2;
            this.txt_timeoff.TextChanged += new System.EventHandler(this.txt_timeoff_TextChanged);
            // 
            // txt_numberhour
            // 
            this.txt_numberhour.Location = new System.Drawing.Point(31, 140);
            this.txt_numberhour.Name = "txt_numberhour";
            this.txt_numberhour.Size = new System.Drawing.Size(134, 20);
            this.txt_numberhour.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(209, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "יום בשבוע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(203, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "שעת המראה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(207, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "שעת נחיתה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(172, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "מספר שעות טיסה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(197, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "משדה תעופה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(197, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "לשדה תעופה";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.status.Location = new System.Drawing.Point(106, 325);
            this.status.Name = "status";
            this.status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.status.Size = new System.Drawing.Size(64, 17);
            this.status.TabIndex = 12;
            this.status.Text = "סטטוס";
            this.status.UseVisualStyleBackColor = true;
            // 
            // btn_enternew
            // 
            this.btn_enternew.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_enternew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_enternew.Location = new System.Drawing.Point(12, 352);
            this.btn_enternew.Name = "btn_enternew";
            this.btn_enternew.Size = new System.Drawing.Size(134, 80);
            this.btn_enternew.TabIndex = 13;
            this.btn_enternew.Text = "צרף טיסה זו לטיסות הפעילות";
            this.btn_enternew.UseVisualStyleBackColor = false;
            this.btn_enternew.Click += new System.EventHandler(this.btn_enternew_Click);
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(31, 174);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(134, 20);
            this.txt_from.TabIndex = 14;
            this.txt_from.TextChanged += new System.EventHandler(this.txt_from_TextChanged);
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(31, 211);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(134, 20);
            this.txt_to.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmb_day
            // 
            this.cmb_day.FormattingEnabled = true;
            this.cmb_day.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.cmb_day.Location = new System.Drawing.Point(31, 38);
            this.cmb_day.Name = "cmb_day";
            this.cmb_day.Size = new System.Drawing.Size(134, 21);
            this.cmb_day.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(203, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "מחיר בדולר";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 290);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(179, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "מחיר הלוך חזור";
            // 
            // timeflight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(314, 440);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmb_day);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.btn_enternew);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numberhour);
            this.Controls.Add(this.txt_timeoff);
            this.Controls.Add(this.txt_timeon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "timeflight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "timeflight";
            this.Load += new System.EventHandler(this.timeflight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_timeon;
        private System.Windows.Forms.TextBox txt_timeoff;
        private System.Windows.Forms.TextBox txt_numberhour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox status;
        private System.Windows.Forms.Button btn_enternew;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmb_day;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
    }
}