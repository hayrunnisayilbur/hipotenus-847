namespace hipotenus_847
{
    partial class Form1
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
            this.lblKenar1 = new System.Windows.Forms.Label();
            this.lblKenar2 = new System.Windows.Forms.Label();
            this.txtKenar1 = new System.Windows.Forms.TextBox();
            this.txtKenar2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblHipotenus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKenar1
            // 
            this.lblKenar1.AutoSize = true;
            this.lblKenar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKenar1.Location = new System.Drawing.Point(68, 81);
            this.lblKenar1.Name = "lblKenar1";
            this.lblKenar1.Size = new System.Drawing.Size(72, 24);
            this.lblKenar1.TabIndex = 0;
            this.lblKenar1.Text = "kenar 1";
            // 
            // lblKenar2
            // 
            this.lblKenar2.AutoSize = true;
            this.lblKenar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKenar2.Location = new System.Drawing.Point(68, 111);
            this.lblKenar2.Name = "lblKenar2";
            this.lblKenar2.Size = new System.Drawing.Size(72, 24);
            this.lblKenar2.TabIndex = 1;
            this.lblKenar2.Text = "kenar 2";
            // 
            // txtKenar1
            // 
            this.txtKenar1.Location = new System.Drawing.Point(155, 86);
            this.txtKenar1.Name = "txtKenar1";
            this.txtKenar1.Size = new System.Drawing.Size(100, 20);
            this.txtKenar1.TabIndex = 2;
            // 
            // txtKenar2
            // 
            this.txtKenar2.Location = new System.Drawing.Point(155, 115);
            this.txtKenar2.Name = "txtKenar2";
            this.txtKenar2.Size = new System.Drawing.Size(100, 20);
            this.txtKenar2.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(72, 141);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(183, 43);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblHipotenus
            // 
            this.lblHipotenus.AutoSize = true;
            this.lblHipotenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHipotenus.Location = new System.Drawing.Point(68, 196);
            this.lblHipotenus.Name = "lblHipotenus";
            this.lblHipotenus.Size = new System.Drawing.Size(62, 24);
            this.lblHipotenus.TabIndex = 5;
            this.lblHipotenus.Text = "sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHipotenus);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKenar2);
            this.Controls.Add(this.txtKenar1);
            this.Controls.Add(this.lblKenar2);
            this.Controls.Add(this.lblKenar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKenar1;
        private System.Windows.Forms.Label lblKenar2;
        private System.Windows.Forms.TextBox txtKenar1;
        private System.Windows.Forms.TextBox txtKenar2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblHipotenus;
    }
}

