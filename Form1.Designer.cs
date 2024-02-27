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
            this.edieni = new System.Windows.Forms.DomainUpDown();
            this.kalorijas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.kalorijas)).BeginInit();
            this.SuspendLayout();
            // 
            // edieni
            // 
            this.edieni.Location = new System.Drawing.Point(30, 73);
            this.edieni.Name = "edieni";
            this.edieni.Size = new System.Drawing.Size(120, 20);
            this.edieni.TabIndex = 0;
            this.edieni.Text = "ēdieni";
            // 
            // kalorijas
            // 
            this.kalorijas.Location = new System.Drawing.Point(173, 73);
            this.kalorijas.Name = "kalorijas";
            this.kalorijas.Size = new System.Drawing.Size(120, 20);
            this.kalorijas.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kalorijas);
            this.Controls.Add(this.edieni);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kalorijas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown edieni;
        private System.Windows.Forms.NumericUpDown kalorijas;
    }
}

