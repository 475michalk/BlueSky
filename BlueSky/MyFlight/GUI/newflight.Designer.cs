namespace MyFlight.GUI
{
    partial class newflight
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newflight));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_from = new System.Windows.Forms.ComboBox();
            this.cmb_to = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(20, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // cmb_from
            // 
            this.cmb_from.FormattingEnabled = true;
            this.cmb_from.Items.AddRange(new object[] {
            "ישראל, בן גוריון תל אביב",
            "יון,כרתיים",
            "יון,אתונה",
            "יון,פאפוס"});
            this.cmb_from.Location = new System.Drawing.Point(459, 53);
            this.cmb_from.Name = "cmb_from";
            this.cmb_from.Size = new System.Drawing.Size(121, 21);
            this.cmb_from.TabIndex = 1;
            this.cmb_from.SelectedIndexChanged += new System.EventHandler(this.cmb_from_SelectedIndexChanged);
            // 
            // cmb_to
            // 
            this.cmb_to.FormattingEnabled = true;
            this.cmb_to.Items.AddRange(new object[] {
            "ישראל, בן גוריון תל אביב",
            "יון,כרתיים",
            "יון,אתונה",
            "יון,פאפוס"});
            this.cmb_to.Location = new System.Drawing.Point(459, 95);
            this.cmb_to.Name = "cmb_to";
            this.cmb_to.Size = new System.Drawing.Size(121, 21);
            this.cmb_to.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.Location = new System.Drawing.Point(459, 131);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 83);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "שמירת טיסה";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_delete.Location = new System.Drawing.Point(459, 220);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(121, 83);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "מחיקת טיסה";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // newflight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(685, 376);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_to);
            this.Controls.Add(this.cmb_from);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newflight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newflight";
            this.Load += new System.EventHandler(this.newflight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_from;
        private System.Windows.Forms.ComboBox cmb_to;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_delete;
    }
}