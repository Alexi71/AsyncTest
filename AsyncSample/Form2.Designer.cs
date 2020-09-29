namespace AsyncSample
{
    partial class Form2
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
            this.time = new System.Windows.Forms.Label();
            this.kommen = new System.Windows.Forms.Button();
            this.gehen = new System.Windows.Forms.Button();
            this.currentTime = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.DarkRed;
            this.time.Location = new System.Drawing.Point(46, 29);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(53, 24);
            this.time.TabIndex = 0;
            this.time.Text = "Time";
            // 
            // kommen
            // 
            this.kommen.BackColor = System.Drawing.Color.LawnGreen;
            this.kommen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kommen.Location = new System.Drawing.Point(50, 105);
            this.kommen.Name = "kommen";
            this.kommen.Size = new System.Drawing.Size(161, 38);
            this.kommen.TabIndex = 1;
            this.kommen.Text = "Kommen";
            this.kommen.UseVisualStyleBackColor = false;
            this.kommen.Click += new System.EventHandler(this.kommen_Click);
            // 
            // gehen
            // 
            this.gehen.BackColor = System.Drawing.Color.Crimson;
            this.gehen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gehen.Location = new System.Drawing.Point(50, 188);
            this.gehen.Name = "gehen";
            this.gehen.Size = new System.Drawing.Size(161, 38);
            this.gehen.TabIndex = 2;
            this.gehen.Text = "Gehen";
            this.gehen.UseVisualStyleBackColor = false;
            this.gehen.Click += new System.EventHandler(this.gehen_Click);
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.ForeColor = System.Drawing.Color.DarkRed;
            this.currentTime.Location = new System.Drawing.Point(380, 147);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(115, 24);
            this.currentTime.TabIndex = 3;
            this.currentTime.Text = "CurrentTime";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Turquoise;
            this.status.Location = new System.Drawing.Point(380, 59);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 24);
            this.status.TabIndex = 4;
            this.status.Text = "Status";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.status);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.gehen);
            this.Controls.Add(this.kommen);
            this.Controls.Add(this.time);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button kommen;
        private System.Windows.Forms.Button gehen;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label status;
    }
}