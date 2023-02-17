using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioDeFixação2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OSA0625215W10-1;Initial Catalog=FIXACAO_000;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
            CarregarLista();
        }
        private void CarregarLista()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();

            conn.Open();
            comando.CommandText = "select * from EXERCICIO2";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[1].ToString());
                    listBox2.Items.Add(dr[2].ToString());
                    listBox3.Items.Add(dr[3].ToString());
                    listBox4.Items.Add(dr[4].ToString());
                    listBox5.Items.Add(dr[5].ToString());
                    listBox6.Items.Add(dr[6].ToString());
                    listBox7.Items.Add(dr[7].ToString());
                    listBox8.Items.Add(dr[8].ToString());
                    listBox9.Items.Add(dr[8].ToString());

                }
            }
            conn.Close();
        }

        private void Alinhar(object sender)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
                listBox6.SelectedIndex = l.SelectedIndex;
                listBox7.SelectedIndex = l.SelectedIndex;
                listBox8.SelectedIndex = l.SelectedIndex;
                listBox9.SelectedIndex = l.SelectedIndex;

                textBox1.Text = listBox1.SelectedItem.ToString();
                textBox2.Text = listBox2.SelectedItem.ToString();
                textBox3.Text = listBox3.SelectedItem.ToString();
                textBox4.Text = listBox4.SelectedItem.ToString();
                textBox5.Text = listBox5.SelectedItem.ToString();
                textBox6.Text = listBox6.SelectedItem.ToString();
                textBox7.Text = listBox7.SelectedItem.ToString();
                textBox8.Text = listBox8.SelectedItem.ToString();
                textBox9.Text = listBox9.SelectedItem.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }
    }
}

