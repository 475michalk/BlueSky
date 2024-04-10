
namespace MyFlight.GUI
{
    partial class enerprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enerprincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cust = new System.Windows.Forms.Button();
            this.btn_fly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(317, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ניהול טיסות פעילות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(164, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "לקוחות";
            // 
            // btn_cust
            // 
            this.btn_cust.BackgroundImage = global::MyFlight.Properties.Resources.איקונים_06;
            this.btn_cust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cust.Location = new System.Drawing.Point(95, 89);
            this.btn_cust.Name = "btn_cust";
            this.btn_cust.Size = new System.Drawing.Size(183, 138);
            this.btn_cust.TabIndex = 1;
            this.btn_cust.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_cust.UseVisualStyleBackColor = true;
            this.btn_cust.Click += new System.EventHandler(this.btn_cust_Click);
            // 
            // btn_fly
            // 
            this.btn_fly.BackgroundImage = global::MyFlight.Properties.Resources.איקון_2_07;
            this.btn_fly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fly.Location = new System.Drawing.Point(284, 89);
            this.btn_fly.Name = "btn_fly";
            this.btn_fly.Size = new System.Drawing.Size(197, 138);
            this.btn_fly.TabIndex = 0;
            this.btn_fly.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_fly.UseVisualStyleBackColor = true;
            this.btn_fly.Click += new System.EventHandler(this.btn_fly_Click);
            // 
            // enerprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(558, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cust);
            this.Controls.Add(this.btn_fly);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "enerprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fly;
        private System.Windows.Forms.Button btn_cust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}