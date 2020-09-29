namespace AsyncSample
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.AnzahlLoops = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(129, 237);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(135, 73);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.ForeColor = System.Drawing.Color.Red;
            this.counter.Location = new System.Drawing.Point(360, 156);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(88, 25);
            this.counter.TabIndex = 1;
            this.counter.Text = "Counter";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.OliveDrab;
            this.time.Location = new System.Drawing.Point(124, 63);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(52, 25);
            this.time.TabIndex = 2;
            this.time.Text = "time";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Sienna;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(412, 237);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(113, 73);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // AnzahlLoops
            // 
            this.AnzahlLoops.Location = new System.Drawing.Point(365, 123);
            this.AnzahlLoops.Name = "AnzahlLoops";
            this.AnzahlLoops.Size = new System.Drawing.Size(100, 20);
            this.AnzahlLoops.TabIndex = 4;
            this.AnzahlLoops.TextChanged += new System.EventHandler(this.AnzahlLoops_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnzahlLoops);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.time);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox AnzahlLoops;
    }
}

