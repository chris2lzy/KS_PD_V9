namespace KS_PD_V9
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
            this.kalorijas = new System.Windows.Forms.NumericUpDown();
            this.kalorijas3 = new System.Windows.Forms.NumericUpDown();
            this.kalorijas2 = new System.Windows.Forms.NumericUpDown();
            this.kopejas_kalorijas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kop_kalorijas = new System.Windows.Forms.Label();
            this.ediens = new System.Windows.Forms.TextBox();
            this.ediens2 = new System.Windows.Forms.TextBox();
            this.ediens3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kalorijas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalorijas3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalorijas2)).BeginInit();
            this.SuspendLayout();
            // 
            // kalorijas
            // 
            this.kalorijas.Location = new System.Drawing.Point(173, 73);
            this.kalorijas.Name = "kalorijas";
            this.kalorijas.Size = new System.Drawing.Size(120, 20);
            this.kalorijas.TabIndex = 1;
            // 
            // kalorijas3
            // 
            this.kalorijas3.Location = new System.Drawing.Point(173, 156);
            this.kalorijas3.Name = "kalorijas3";
            this.kalorijas3.Size = new System.Drawing.Size(120, 20);
            this.kalorijas3.TabIndex = 4;
            // 
            // kalorijas2
            // 
            this.kalorijas2.Location = new System.Drawing.Point(173, 114);
            this.kalorijas2.Name = "kalorijas2";
            this.kalorijas2.Size = new System.Drawing.Size(120, 20);
            this.kalorijas2.TabIndex = 5;
            // 
            // kopejas_kalorijas
            // 
            this.kopejas_kalorijas.Location = new System.Drawing.Point(89, 252);
            this.kopejas_kalorijas.Name = "kopejas_kalorijas";
            this.kopejas_kalorijas.Size = new System.Drawing.Size(75, 23);
            this.kopejas_kalorijas.TabIndex = 6;
            this.kopejas_kalorijas.Text = "kopējās kalorijas";
            this.kopejas_kalorijas.UseVisualStyleBackColor = true;
            this.kopejas_kalorijas.Click += new System.EventHandler(this.kopejas_kalorijas_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // kop_kalorijas
            // 
            this.kop_kalorijas.AutoSize = true;
            this.kop_kalorijas.Location = new System.Drawing.Point(44, 215);
            this.kop_kalorijas.Name = "kop_kalorijas";
            this.kop_kalorijas.Size = new System.Drawing.Size(85, 13);
            this.kop_kalorijas.TabIndex = 8;
            this.kop_kalorijas.Text = "kopējās kalorijas";
            // 
            // ediens
            // 
            this.ediens.Location = new System.Drawing.Point(47, 73);
            this.ediens.Name = "ediens";
            this.ediens.Size = new System.Drawing.Size(100, 20);
            this.ediens.TabIndex = 9;
            // 
            // ediens2
            // 
            this.ediens2.Location = new System.Drawing.Point(47, 113);
            this.ediens2.Name = "ediens2";
            this.ediens2.Size = new System.Drawing.Size(100, 20);
            this.ediens2.TabIndex = 10;
            // 
            // ediens3
            // 
            this.ediens3.Location = new System.Drawing.Point(47, 155);
            this.ediens3.Name = "ediens3";
            this.ediens3.Size = new System.Drawing.Size(100, 20);
            this.ediens3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ediens3);
            this.Controls.Add(this.ediens2);
            this.Controls.Add(this.ediens);
            this.Controls.Add(this.kop_kalorijas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kopejas_kalorijas);
            this.Controls.Add(this.kalorijas2);
            this.Controls.Add(this.kalorijas3);
            this.Controls.Add(this.kalorijas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kalorijas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalorijas3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalorijas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown kalorijas;
        private System.Windows.Forms.NumericUpDown kalorijas3;
        private System.Windows.Forms.NumericUpDown kalorijas2;
        private System.Windows.Forms.Button kopejas_kalorijas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label kop_kalorijas;
        private System.Windows.Forms.TextBox ediens;
        private System.Windows.Forms.TextBox ediens2;
        private System.Windows.Forms.TextBox ediens3;
    }
}

