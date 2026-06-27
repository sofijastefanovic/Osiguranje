namespace Osiguranje.Forme
{
    partial class ZdravstvenaStetaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDokumenta = new System.Windows.Forms.TextBox();
            this.txtUstanova = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(168, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "SACUVAJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zdravstvena dokumenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zdravstvena ustanova:";
            // 
            // txtDokumenta
            // 
            this.txtDokumenta.Location = new System.Drawing.Point(282, 43);
            this.txtDokumenta.Name = "txtDokumenta";
            this.txtDokumenta.Size = new System.Drawing.Size(189, 30);
            this.txtDokumenta.TabIndex = 3;
            this.txtDokumenta.TextChanged += new System.EventHandler(this.txtDokumenta_TextChanged);
            // 
            // txtUstanova
            // 
            this.txtUstanova.Location = new System.Drawing.Point(282, 106);
            this.txtUstanova.Name = "txtUstanova";
            this.txtUstanova.Size = new System.Drawing.Size(189, 30);
            this.txtUstanova.TabIndex = 4;
            this.txtUstanova.TextChanged += new System.EventHandler(this.txtUstanova_TextChanged);
            // 
            // ZdravstvenaStetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(537, 240);
            this.Controls.Add(this.txtUstanova);
            this.Controls.Add(this.txtDokumenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ZdravstvenaStetaForm";
            this.Text = "ZdravstvenaSteta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDokumenta;
        private System.Windows.Forms.TextBox txtUstanova;
    }
}