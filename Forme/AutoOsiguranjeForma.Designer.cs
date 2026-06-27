namespace Osiguranje.Forme
{
    partial class AutoOsiguranjeForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVozaci = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtTeritorijalno = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bonus malus klasa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teritorijalno vazenje:";
            // 
            // txtVozaci
            // 
            this.txtVozaci.Location = new System.Drawing.Point(245, 24);
            this.txtVozaci.Name = "txtVozaci";
            this.txtVozaci.Size = new System.Drawing.Size(175, 30);
            this.txtVozaci.TabIndex = 3;
            this.txtVozaci.TextChanged += new System.EventHandler(this.txtVozaci_TextChanged);
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(245, 73);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(175, 30);
            this.txtBonus.TabIndex = 4;
            this.txtBonus.TextChanged += new System.EventHandler(this.txtBonus_TextChanged);
            // 
            // txtTeritorijalno
            // 
            this.txtTeritorijalno.Location = new System.Drawing.Point(245, 126);
            this.txtTeritorijalno.Name = "txtTeritorijalno";
            this.txtTeritorijalno.Size = new System.Drawing.Size(175, 30);
            this.txtTeritorijalno.TabIndex = 5;
            this.txtTeritorijalno.TextChanged += new System.EventHandler(this.txtTeritorijalno_TextChanged);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSacuvaj.Location = new System.Drawing.Point(133, 189);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(161, 57);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "SACUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vozaci:";
            // 
            // AutoOsiguranjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(458, 282);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtTeritorijalno);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.txtVozaci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AutoOsiguranjeForma";
            this.Text = "AutoOsiguranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVozaci;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtTeritorijalno;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
    }
}