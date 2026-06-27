namespace Osiguranje.Forme
{
    partial class PolisaForma
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisiPolisu = new System.Windows.Forms.Button();
            this.btnIstorijaIzmena = new System.Windows.Forms.Button();
            this.btnDodatnoPokrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(987, 247);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(25, 290);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(204, 73);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "DODAJ POLISU";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisiPolisu
            // 
            this.btnObrisiPolisu.BackColor = System.Drawing.Color.CadetBlue;
            this.btnObrisiPolisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiPolisu.Location = new System.Drawing.Point(250, 290);
            this.btnObrisiPolisu.Name = "btnObrisiPolisu";
            this.btnObrisiPolisu.Size = new System.Drawing.Size(204, 73);
            this.btnObrisiPolisu.TabIndex = 2;
            this.btnObrisiPolisu.Text = "OBRISI POLISU";
            this.btnObrisiPolisu.UseVisualStyleBackColor = false;
            this.btnObrisiPolisu.Click += new System.EventHandler(this.btnObrisiPolisu_Click);
            // 
            // btnIstorijaIzmena
            // 
            this.btnIstorijaIzmena.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIstorijaIzmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIstorijaIzmena.Location = new System.Drawing.Point(487, 290);
            this.btnIstorijaIzmena.Name = "btnIstorijaIzmena";
            this.btnIstorijaIzmena.Size = new System.Drawing.Size(226, 73);
            this.btnIstorijaIzmena.TabIndex = 18;
            this.btnIstorijaIzmena.Text = "ISTORIJA IZMENA POLISA";
            this.btnIstorijaIzmena.UseVisualStyleBackColor = false;
            this.btnIstorijaIzmena.Click += new System.EventHandler(this.btnIstorijaIzmena_Click);
            // 
            // btnDodatnoPokrice
            // 
            this.btnDodatnoPokrice.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDodatnoPokrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodatnoPokrice.Location = new System.Drawing.Point(747, 290);
            this.btnDodatnoPokrice.Name = "btnDodatnoPokrice";
            this.btnDodatnoPokrice.Size = new System.Drawing.Size(226, 73);
            this.btnDodatnoPokrice.TabIndex = 19;
            this.btnDodatnoPokrice.Text = "DODATNO POKRICE";
            this.btnDodatnoPokrice.UseVisualStyleBackColor = false;
            this.btnDodatnoPokrice.Click += new System.EventHandler(this.btnDodatnoPokrice_Click);
            // 
            // PolisaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1011, 375);
            this.Controls.Add(this.btnDodatnoPokrice);
            this.Controls.Add(this.btnIstorijaIzmena);
            this.Controls.Add(this.btnObrisiPolisu);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listView1);
            this.Name = "PolisaForma";
            this.Text = "PolisaForma";
            this.Load += new System.EventHandler(this.PolisaForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisiPolisu;
        private System.Windows.Forms.Button btnIstorijaIzmena;
        private System.Windows.Forms.Button btnDodatnoPokrice;
    }
}