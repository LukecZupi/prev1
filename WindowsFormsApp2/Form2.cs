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

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bPotrdi_Click(object sender, EventArgs e)
        {
           if(tBPriimek.Text == "" || tBIme.Text == "" || comboBox1.Text == ""
                || (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked
                && !radioButton4.Checked)) 
            {
                MessageBox.Show("Dopolni podatke");
                DialogResult = DialogResult.None;

        
            }
            else
            { 
                if (DateTime.Today.Year - dateTimePicker1.Value.Year < 17 )
                {
                    MessageBox.Show("Nogometaš ne sme biti mlajši od 17 let.");
                    DialogResult = DialogResult.None;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = File.ReadAllLines("klubi.txt");
            tbKlub.Hide();
            button2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbKlub.Show();
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbKlub.Text.Length > 2)
            {

                //dodamo klub v datoteko
                File.AppendAllText("klubi.txt", "\r\n" + tbKlub.Text);
                MessageBox.Show("Klub dodan");
                //dodamo klub v combobox
                //comboBox1.Items.Add(tbKlub.Text);
                comboBox1.DataSource = File.ReadAllLines("klubi.txt");
                tbKlub.Hide();
                button2.Hide();
            }
            else
            {
                MessageBox.Show("Vnesi klub");
            }
        }
    }
}
