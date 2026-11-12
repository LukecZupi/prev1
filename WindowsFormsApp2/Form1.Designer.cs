namespace WindowsFormsApp2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajNovZapisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.povprečnaMasaIgralcevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shraniVDatotekoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priimek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRojstva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obarvaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priimek,
            this.ime,
            this.klub,
            this.datumRojstva,
            this.kg,
            this.pozicija,
            this.obarvaj,
            this.brisi});
            this.dGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGV.Location = new System.Drawing.Point(0, 74);
            this.dGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.RowHeadersWidth = 51;
            this.dGV.Size = new System.Drawing.Size(774, 193);
            this.dGV.TabIndex = 0;
            this.dGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovZapisToolStripMenuItem,
            this.izpisiToolStripMenuItem,
            this.shraniVDatotekoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajNovZapisToolStripMenuItem
            // 
            this.dodajNovZapisToolStripMenuItem.Name = "dodajNovZapisToolStripMenuItem";
            this.dodajNovZapisToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.dodajNovZapisToolStripMenuItem.Text = "Dodaj nov zapis";
            this.dodajNovZapisToolStripMenuItem.Click += new System.EventHandler(this.dodajNovZapisToolStripMenuItem_Click);
            // 
            // izpisiToolStripMenuItem
            // 
            this.izpisiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.povprečnaMasaIgralcevToolStripMenuItem});
            this.izpisiToolStripMenuItem.Name = "izpisiToolStripMenuItem";
            this.izpisiToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.izpisiToolStripMenuItem.Text = "Izpisi";
            // 
            // povprečnaMasaIgralcevToolStripMenuItem
            // 
            this.povprečnaMasaIgralcevToolStripMenuItem.Name = "povprečnaMasaIgralcevToolStripMenuItem";
            this.povprečnaMasaIgralcevToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.povprečnaMasaIgralcevToolStripMenuItem.Text = "Povprečna masa igralcev";
            this.povprečnaMasaIgralcevToolStripMenuItem.Click += new System.EventHandler(this.povprečnaMasaIgralcevToolStripMenuItem_Click);
            // 
            // shraniVDatotekoToolStripMenuItem
            // 
            this.shraniVDatotekoToolStripMenuItem.Name = "shraniVDatotekoToolStripMenuItem";
            this.shraniVDatotekoToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.shraniVDatotekoToolStripMenuItem.Text = "Shrani v datoteko";
            this.shraniVDatotekoToolStripMenuItem.Click += new System.EventHandler(this.shraniVDatotekoToolStripMenuItem_Click);
            // 
            // priimek
            // 
            this.priimek.HeaderText = "Priimek";
            this.priimek.MinimumWidth = 6;
            this.priimek.Name = "priimek";
            this.priimek.ReadOnly = true;
            this.priimek.Width = 125;
            // 
            // ime
            // 
            this.ime.HeaderText = "Ime";
            this.ime.MinimumWidth = 6;
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            this.ime.Width = 90;
            // 
            // klub
            // 
            this.klub.HeaderText = "Klub";
            this.klub.MinimumWidth = 6;
            this.klub.Name = "klub";
            this.klub.ReadOnly = true;
            this.klub.Width = 125;
            // 
            // datumRojstva
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.datumRojstva.DefaultCellStyle = dataGridViewCellStyle5;
            this.datumRojstva.HeaderText = "Datum rojstva";
            this.datumRojstva.MinimumWidth = 6;
            this.datumRojstva.Name = "datumRojstva";
            this.datumRojstva.ReadOnly = true;
            this.datumRojstva.Width = 80;
            // 
            // kg
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.kg.DefaultCellStyle = dataGridViewCellStyle6;
            this.kg.HeaderText = "Kg";
            this.kg.MinimumWidth = 6;
            this.kg.Name = "kg";
            this.kg.ReadOnly = true;
            this.kg.Width = 40;
            // 
            // pozicija
            // 
            this.pozicija.HeaderText = "Pozicija";
            this.pozicija.MinimumWidth = 6;
            this.pozicija.Name = "pozicija";
            this.pozicija.ReadOnly = true;
            this.pozicija.Width = 125;
            // 
            // obarvaj
            // 
            this.obarvaj.HeaderText = "Obarvaj";
            this.obarvaj.MinimumWidth = 6;
            this.obarvaj.Name = "obarvaj";
            this.obarvaj.ReadOnly = true;
            this.obarvaj.Text = "Obarvaj";
            this.obarvaj.UseColumnTextForButtonValue = true;
            this.obarvaj.Width = 70;
            // 
            // brisi
            // 
            this.brisi.HeaderText = "Briši";
            this.brisi.MinimumWidth = 6;
            this.brisi.Name = "brisi";
            this.brisi.ReadOnly = true;
            this.brisi.Text = "Briši";
            this.brisi.UseColumnTextForButtonValue = true;
            this.brisi.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 267);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajNovZapisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem povprečnaMasaIgralcevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shraniVDatotekoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn priimek;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn klub;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRojstva;
        private System.Windows.Forms.DataGridViewTextBoxColumn kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozicija;
        private System.Windows.Forms.DataGridViewButtonColumn obarvaj;
        private System.Windows.Forms.DataGridViewButtonColumn brisi;
    }
}

