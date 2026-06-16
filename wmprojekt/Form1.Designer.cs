namespace wmprojekt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnErgebnis = new System.Windows.Forms.Button();
            this.numericUpDown1ToreHeim = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownToreGast = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTabelle = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmboxHeim = new System.Windows.Forms.ComboBox();
            this.cboxGast = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1ToreHeim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToreGast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "WM 2026 Gruppe E Tippwand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heimteam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gastteam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tore";
            // 
            // btnErgebnis
            // 
            this.btnErgebnis.Location = new System.Drawing.Point(29, 289);
            this.btnErgebnis.Name = "btnErgebnis";
            this.btnErgebnis.Size = new System.Drawing.Size(254, 43);
            this.btnErgebnis.TabIndex = 4;
            this.btnErgebnis.Text = "Ergebnis eintragen";
            this.btnErgebnis.UseVisualStyleBackColor = true;
            this.btnErgebnis.Click += new System.EventHandler(this.btnErgebnis_Click);
            // 
            // numericUpDown1ToreHeim
            // 
            this.numericUpDown1ToreHeim.Location = new System.Drawing.Point(109, 205);
            this.numericUpDown1ToreHeim.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1ToreHeim.Name = "numericUpDown1ToreHeim";
            this.numericUpDown1ToreHeim.Size = new System.Drawing.Size(63, 31);
            this.numericUpDown1ToreHeim.TabIndex = 5;
            // 
            // numericUpDownToreGast
            // 
            this.numericUpDownToreGast.Location = new System.Drawing.Point(209, 205);
            this.numericUpDownToreGast.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownToreGast.Name = "numericUpDownToreGast";
            this.numericUpDownToreGast.Size = new System.Drawing.Size(63, 31);
            this.numericUpDownToreGast.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // dgvTabelle
            // 
            this.dgvTabelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelle.Location = new System.Drawing.Point(20, 383);
            this.dgvTabelle.Name = "dgvTabelle";
            this.dgvTabelle.Size = new System.Drawing.Size(553, 150);
            this.dgvTabelle.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tabelle";
            // 
            // cmboxHeim
            // 
            this.cmboxHeim.FormattingEnabled = true;
            this.cmboxHeim.Location = new System.Drawing.Point(151, 80);
            this.cmboxHeim.Name = "cmboxHeim";
            this.cmboxHeim.Size = new System.Drawing.Size(189, 33);
            this.cmboxHeim.TabIndex = 10;
            // 
            // cboxGast
            // 
            this.cboxGast.FormattingEnabled = true;
            this.cboxGast.Location = new System.Drawing.Point(151, 139);
            this.cboxGast.Name = "cboxGast";
            this.cboxGast.Size = new System.Drawing.Size(189, 33);
            this.cboxGast.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 546);
            this.Controls.Add(this.cboxGast);
            this.Controls.Add(this.cmboxHeim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTabelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownToreGast);
            this.Controls.Add(this.numericUpDown1ToreHeim);
            this.Controls.Add(this.btnErgebnis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1ToreHeim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToreGast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnErgebnis;
        private System.Windows.Forms.NumericUpDown numericUpDown1ToreHeim;
        private System.Windows.Forms.NumericUpDown numericUpDownToreGast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTabelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmboxHeim;
        private System.Windows.Forms.ComboBox cboxGast;
    }
}

