using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader beri = File.OpenText("Nogometasi.txt");
            string vrstica=beri.ReadLine();
            //pripravimo 1D tabelo
            string[] tabelca;
            while (vrstica!=null)
            { //razbijemo vrstico v tabelo
                tabelca = vrstica.Split('|');
                //dodamo vrstico v dgv
                dGV.Rows.Add(tabelca);
                //preberemo naslednjo vrstico iz datoteke
                vrstica = beri.ReadLine();
            }
            //zapremo datoteko
            beri.Close();


        }

        private void dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)//gumb Obarvaj
            { 
                ColorDialog CD=new ColorDialog();
                if (CD.ShowDialog()==DialogResult.OK)//izbrali smo barvo
                { 
                    //zapomnimo si klub izbranega nogometaša
                    string club = dGV.CurrentRow.Cells[2].Value.ToString();
                    for (int i = 0; i < dGV.Rows.Count; i++)
                    {
                        if (dGV.Rows[i].Cells[2].Value.ToString() == club)
                        { //našli smo nogometaša, ki igra v istem klubu
                            //pobarvamo vrstico z izbrano barvo
                            dGV.Rows[i].DefaultCellStyle.BackColor=CD.Color;
                        }
                    }
                }
            }
            if (e.ColumnIndex == 7) // gumb briši
            {
                if (MessageBox.Show("Ali potrjuješ brisanje nogometaša "+ dGV.CurrentRow.Cells[0].Value + " " + dGV.CurrentRow.Cells[1].Value + "?", " POZOR Brisanje", MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    dGV.Rows.RemoveAt(e.RowIndex);
                }
            }
            
        }

        private void dodajNovZapisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 podobrazec = new Form2();
            if (podobrazec.ShowDialog() == DialogResult.OK) //gumb Potrdi
            {
                string poz="";
                if (podobrazec.radioButton1.Checked)//1. radijski gumb je izbran
                {
                    poz = podobrazec.radioButton1.Text;
                }
                if (podobrazec.radioButton2.Checked)//2. radijski gumb je izbran
                {
                    poz = podobrazec.radioButton2.Text;
                }
                if (podobrazec.radioButton3.Checked)//3. radijski gumb je izbran
                {
                    poz = podobrazec.radioButton3.Text;
                }
                if (podobrazec.radioButton4.Checked)//4. radijski gumb je izbran
                {
                    poz = podobrazec.radioButton4.Text;
                }

                //DODAMO vrstico v dgv
                dGV.Rows.Add(podobrazec.tBPriimek.Text,
                    podobrazec.tBIme.Text,
                    podobrazec.comboBox1.Text,
                    podobrazec.dateTimePicker1.Value.ToShortDateString(),
                    podobrazec.numericUpDown1.Value,poz);
                // Dodamo nogometaša še v dadoteko
                string nov_nogometas = "\r\n" + podobrazec.tBPriimek.Text + "|" +
                    podobrazec.tBIme.Text + "|" +
                    podobrazec.comboBox1.Text + "|" +
                    podobrazec.dateTimePicker1.Value.ToShortDateString() + "|" +
                    podobrazec.numericUpDown1.Value + "|" +  poz;
                File.AppendAllText("nogometasi.txt",nov_nogometas);
            }
        }
        private void povprečnaMasaIgralcevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double vsota = 0;
            for (int i = 0; i < dGV.Rows.Count; i++)
            {
                vsota += Convert.ToInt16(dGV.Rows[i].Cells[4].Value);
            }
            MessageBox.Show("Povprečna masa igralcev je " + Math.Round(vsota / dGV.RowCount, 1) + "kg");
        }

        private void shraniVDatotekoToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }
    }
}
