namespace MyRoadToOne
{
    partial class Hilfe
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
            this.Hilfetxt = new System.Windows.Forms.Label();
            this.Schliessenhilfe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hilfetxt
            // 
            this.Hilfetxt.AutoSize = true;
            this.Hilfetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hilfetxt.Location = new System.Drawing.Point(13, 13);
            this.Hilfetxt.Name = "Hilfetxt";
            this.Hilfetxt.Size = new System.Drawing.Size(64, 25);
            this.Hilfetxt.TabIndex = 0;
            this.Hilfetxt.Text = "label1";
            // 
            // Schliessenhilfe
            // 
            this.Schliessenhilfe.Location = new System.Drawing.Point(18, 239);
            this.Schliessenhilfe.Name = "Schliessenhilfe";
            this.Schliessenhilfe.Size = new System.Drawing.Size(590, 44);
            this.Schliessenhilfe.TabIndex = 1;
            this.Schliessenhilfe.Text = "Schliessen";
            this.Schliessenhilfe.UseVisualStyleBackColor = true;
            this.Schliessenhilfe.Click += new System.EventHandler(this.Schliessenhilfe_Click);
            // 
            // Hilfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 295);
            this.Controls.Add(this.Schliessenhilfe);
            this.Controls.Add(this.Hilfetxt);
            this.Name = "Hilfe";
            this.Text = "Hilfe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hilfetxt;
        private System.Windows.Forms.Button Schliessenhilfe;
    }
}