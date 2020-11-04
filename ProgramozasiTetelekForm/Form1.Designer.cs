namespace ProgramozasiTetelekForm
{
    partial class frmKezdo
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
            this.btnkiiras = new System.Windows.Forms.Button();
            this.btnosszeg = new System.Windows.Forms.Button();
            this.btnmegszamol = new System.Windows.Forms.Button();
            this.btneldontes = new System.Windows.Forms.Button();
            this.btnkivalaszt = new System.Windows.Forms.Button();
            this.btnkeres = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnkiiras
            // 
            this.btnkiiras.Location = new System.Drawing.Point(34, 26);
            this.btnkiiras.Name = "btnkiiras";
            this.btnkiiras.Size = new System.Drawing.Size(101, 38);
            this.btnkiiras.TabIndex = 0;
            this.btnkiiras.Text = "Kiíratás";
            this.btnkiiras.UseVisualStyleBackColor = true;
            this.btnkiiras.Click += new System.EventHandler(this.btnkiiras_Click);
            // 
            // btnosszeg
            // 
            this.btnosszeg.Location = new System.Drawing.Point(34, 71);
            this.btnosszeg.Name = "btnosszeg";
            this.btnosszeg.Size = new System.Drawing.Size(101, 38);
            this.btnosszeg.TabIndex = 1;
            this.btnosszeg.Text = "Átlag";
            this.btnosszeg.UseVisualStyleBackColor = true;
            this.btnosszeg.Click += new System.EventHandler(this.btnosszeg_Click);
            // 
            // btnmegszamol
            // 
            this.btnmegszamol.Location = new System.Drawing.Point(34, 116);
            this.btnmegszamol.Name = "btnmegszamol";
            this.btnmegszamol.Size = new System.Drawing.Size(101, 38);
            this.btnmegszamol.TabIndex = 2;
            this.btnmegszamol.Text = "Megszámlálás";
            this.btnmegszamol.UseVisualStyleBackColor = true;
            this.btnmegszamol.Click += new System.EventHandler(this.btnmegszamol_Click);
            // 
            // btneldontes
            // 
            this.btneldontes.Location = new System.Drawing.Point(34, 161);
            this.btneldontes.Name = "btneldontes";
            this.btneldontes.Size = new System.Drawing.Size(101, 38);
            this.btneldontes.TabIndex = 3;
            this.btneldontes.Text = "Eldöntés";
            this.btneldontes.UseVisualStyleBackColor = true;
            this.btneldontes.Click += new System.EventHandler(this.btneldontes_Click);
            // 
            // btnkivalaszt
            // 
            this.btnkivalaszt.Location = new System.Drawing.Point(34, 206);
            this.btnkivalaszt.Name = "btnkivalaszt";
            this.btnkivalaszt.Size = new System.Drawing.Size(101, 38);
            this.btnkivalaszt.TabIndex = 4;
            this.btnkivalaszt.Text = "Kiválasztás";
            this.btnkivalaszt.UseVisualStyleBackColor = true;
            this.btnkivalaszt.Click += new System.EventHandler(this.btnkivalaszt_Click);
            // 
            // btnkeres
            // 
            this.btnkeres.Location = new System.Drawing.Point(34, 251);
            this.btnkeres.Name = "btnkeres";
            this.btnkeres.Size = new System.Drawing.Size(101, 38);
            this.btnkeres.TabIndex = 5;
            this.btnkeres.Text = "Keresés";
            this.btnkeres.UseVisualStyleBackColor = true;
            this.btnkeres.Click += new System.EventHandler(this.btnkeres_Click);
            // 
            // btnmin
            // 
            this.btnmin.Location = new System.Drawing.Point(34, 296);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(101, 38);
            this.btnmin.TabIndex = 6;
            this.btnmin.Text = "Minimum";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmax
            // 
            this.btnmax.Location = new System.Drawing.Point(34, 341);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(101, 38);
            this.btnmax.TabIndex = 7;
            this.btnmax.Text = "Maximum";
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // lbText
            // 
            this.lbText.FormattingEnabled = true;
            this.lbText.Location = new System.Drawing.Point(23, 24);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(262, 355);
            this.lbText.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnmax);
            this.panel1.Controls.Add(this.btnmin);
            this.panel1.Controls.Add(this.btnkeres);
            this.panel1.Controls.Add(this.btnkivalaszt);
            this.panel1.Controls.Add(this.btneldontes);
            this.panel1.Controls.Add(this.btnmegszamol);
            this.panel1.Controls.Add(this.btnosszeg);
            this.panel1.Controls.Add(this.btnkiiras);
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 406);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.lbText);
            this.panel2.Location = new System.Drawing.Point(244, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 406);
            this.panel2.TabIndex = 10;
            // 
            // frmKezdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKezdo";
            this.Text = "Tételek";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkiiras;
        private System.Windows.Forms.Button btnosszeg;
        private System.Windows.Forms.Button btnmegszamol;
        private System.Windows.Forms.Button btneldontes;
        private System.Windows.Forms.Button btnkivalaszt;
        private System.Windows.Forms.Button btnkeres;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.ListBox lbText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

