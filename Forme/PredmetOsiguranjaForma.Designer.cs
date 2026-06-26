namespace Osiguranje.Forme
{
    partial class PredmetOsiguranjaForma
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
            this.listViewPredmetiOsiguranja = new System.Windows.Forms.ListView();
            this.btnDODAJ = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPredmetiOsiguranja
            // 
            this.listViewPredmetiOsiguranja.FullRowSelect = true;
            this.listViewPredmetiOsiguranja.GridLines = true;
            this.listViewPredmetiOsiguranja.HideSelection = false;
            this.listViewPredmetiOsiguranja.Location = new System.Drawing.Point(12, 12);
            this.listViewPredmetiOsiguranja.Name = "listViewPredmetiOsiguranja";
            this.listViewPredmetiOsiguranja.Size = new System.Drawing.Size(808, 233);
            this.listViewPredmetiOsiguranja.TabIndex = 0;
            this.listViewPredmetiOsiguranja.UseCompatibleStateImageBehavior = false;
            this.listViewPredmetiOsiguranja.View = System.Windows.Forms.View.Details;
            this.listViewPredmetiOsiguranja.SelectedIndexChanged += new System.EventHandler(this.listViewPredmetiOsiguranja_SelectedIndexChanged);
            // 
            // btnDODAJ
            // 
            this.btnDODAJ.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDODAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDODAJ.Location = new System.Drawing.Point(96, 260);
            this.btnDODAJ.Name = "btnDODAJ";
            this.btnDODAJ.Size = new System.Drawing.Size(222, 52);
            this.btnDODAJ.TabIndex = 1;
            this.btnDODAJ.Text = "DODAJ";
            this.btnDODAJ.UseVisualStyleBackColor = false;
            this.btnDODAJ.Click += new System.EventHandler(this.btnDODAJ_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.CadetBlue;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(504, 260);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(222, 52);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "OBRIŠI";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // PredmetOsiguranjaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(832, 333);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDODAJ);
            this.Controls.Add(this.listViewPredmetiOsiguranja);
            this.Name = "PredmetOsiguranjaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Predmeti osiguranja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPredmetiOsiguranja;
        private System.Windows.Forms.Button btnDODAJ;
        private System.Windows.Forms.Button btnObrisi;
    }
}