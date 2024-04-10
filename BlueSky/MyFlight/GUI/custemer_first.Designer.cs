
namespace MyFlight.GUI
{
    partial class custemer_first
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(custemer_first));
            this.rad_two = new System.Windows.Forms.RadioButton();
            this.rad_one = new System.Windows.Forms.RadioButton();
            this.from = new System.Windows.Forms.ComboBox();
            this.to = new System.Windows.Forms.ComboBox();
            this.dtp_went = new System.Windows.Forms.DateTimePicker();
            this.dtp_return = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numd_boy = new System.Windows.Forms.NumericUpDown();
            this.numd_man = new System.Windows.Forms.NumericUpDown();
            this.btn_travler = new System.Windows.Forms.Button();
            this.btn_activity = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numd_boy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numd_man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rad_two
            // 
            this.rad_two.AutoSize = true;
            this.rad_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rad_two.Location = new System.Drawing.Point(651, 103);
            this.rad_two.Name = "rad_two";
            this.rad_two.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad_two.Size = new System.Drawing.Size(86, 17);
            this.rad_two.TabIndex = 1;
            this.rad_two.TabStop = true;
            this.rad_two.Text = "הלוך חזור";
            this.rad_two.UseVisualStyleBackColor = true;
            this.rad_two.CheckedChanged += new System.EventHandler(this.rad_two_CheckedChanged);
            this.rad_two.Click += new System.EventHandler(this.rad_two_Click);
            // 
            // rad_one
            // 
            this.rad_one.AutoSize = true;
            this.rad_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rad_one.Location = new System.Drawing.Point(555, 103);
            this.rad_one.Name = "rad_one";
            this.rad_one.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad_one.Size = new System.Drawing.Size(77, 17);
            this.rad_one.TabIndex = 2;
            this.rad_one.TabStop = true;
            this.rad_one.Text = "דרך אחת";
            this.rad_one.UseVisualStyleBackColor = true;
            this.rad_one.CheckedChanged += new System.EventHandler(this.rad_one_CheckedChanged);
            this.rad_one.Click += new System.EventHandler(this.rad_one_Click_1);
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.from.FormattingEnabled = true;
            this.from.Items.AddRange(new object[] {
            "ישראל, בן גוריון תל אביב",
            "יון,כרתיים",
            "יון,אתונה",
            "יון,פאפוס"});
            this.from.Location = new System.Drawing.Point(620, 133);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(121, 21);
            this.from.TabIndex = 3;
            this.from.Text = "מאיפה?";
            // 
            // to
            // 
            this.to.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.to.FormattingEnabled = true;
            this.to.Items.AddRange(new object[] {
            "ישראל, בן גוריון תל אביב",
            "יון,כרתיים",
            "יון,אתונה",
            "יון,פאפוס"});
            this.to.Location = new System.Drawing.Point(493, 133);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(121, 21);
            this.to.TabIndex = 4;
            this.to.Text = "לאן?";
            // 
            // dtp_went
            // 
            this.dtp_went.CustomFormat = "תאריך יציאה";
            this.dtp_went.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtp_went.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_went.Location = new System.Drawing.Point(306, 134);
            this.dtp_went.Name = "dtp_went";
            this.dtp_went.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_went.Size = new System.Drawing.Size(181, 20);
            this.dtp_went.TabIndex = 5;
            this.dtp_went.Value = new System.DateTime(2022, 2, 21, 0, 0, 0, 0);
            this.dtp_went.ValueChanged += new System.EventHandler(this.dtp_went_ValueChanged);
            // 
            // dtp_return
            // 
            this.dtp_return.CustomFormat = "תאריך חזרה";
            this.dtp_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtp_return.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_return.Location = new System.Drawing.Point(119, 134);
            this.dtp_return.Name = "dtp_return";
            this.dtp_return.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_return.Size = new System.Drawing.Size(181, 20);
            this.dtp_return.TabIndex = 6;
            this.dtp_return.Value = new System.DateTime(2022, 2, 21, 0, 0, 0, 0);
            this.dtp_return.ValueChanged += new System.EventHandler(this.dtp_return_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numd_boy);
            this.panel1.Controls.Add(this.numd_man);
            this.panel1.Location = new System.Drawing.Point(5, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 73);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(48, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ילד עד 12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(42, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "מבוגר מ-12";
            // 
            // numd_boy
            // 
            this.numd_boy.Location = new System.Drawing.Point(6, 37);
            this.numd_boy.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numd_boy.Name = "numd_boy";
            this.numd_boy.Size = new System.Drawing.Size(35, 20);
            this.numd_boy.TabIndex = 1;
            // 
            // numd_man
            // 
            this.numd_man.Location = new System.Drawing.Point(6, 11);
            this.numd_man.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numd_man.Name = "numd_man";
            this.numd_man.Size = new System.Drawing.Size(35, 20);
            this.numd_man.TabIndex = 0;
            // 
            // btn_travler
            // 
            this.btn_travler.BackColor = System.Drawing.Color.White;
            this.btn_travler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_travler.Location = new System.Drawing.Point(4, 132);
            this.btn_travler.Name = "btn_travler";
            this.btn_travler.Size = new System.Drawing.Size(112, 22);
            this.btn_travler.TabIndex = 9;
            this.btn_travler.Text = "מספר מטיילים";
            this.btn_travler.UseVisualStyleBackColor = false;
            this.btn_travler.Click += new System.EventHandler(this.btn_travler_Click);
            // 
            // btn_activity
            // 
            this.btn_activity.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_activity.Location = new System.Drawing.Point(2, 240);
            this.btn_activity.Name = "btn_activity";
            this.btn_activity.Size = new System.Drawing.Size(127, 74);
            this.btn_activity.TabIndex = 10;
            this.btn_activity.Text = "עבור לחיפוש טיסות";
            this.btn_activity.UseVisualStyleBackColor = false;
            this.btn_activity.Click += new System.EventHandler(this.btn_activity_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyFlight.Properties.Resources.המשך_07_06;
            this.pictureBox1.Location = new System.Drawing.Point(76, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // custemer_first
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(749, 322);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_activity);
            this.Controls.Add(this.btn_travler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_return);
            this.Controls.Add(this.dtp_went);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.rad_one);
            this.Controls.Add(this.rad_two);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "custemer_first";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "custemer_first";
            this.Load += new System.EventHandler(this.custemer_first_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numd_boy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numd_man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.DateTimePicker dtp_went;
        private System.Windows.Forms.DateTimePicker dtp_return;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numd_boy;
        private System.Windows.Forms.NumericUpDown numd_man;
        private System.Windows.Forms.Button btn_travler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_activity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.RadioButton rad_one;
        public System.Windows.Forms.RadioButton rad_two;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}