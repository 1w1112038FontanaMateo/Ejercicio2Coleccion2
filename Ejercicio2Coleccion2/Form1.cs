using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2Coleccion2
{
    public partial class Form1 : Form
    {
        int count = 0;
        string[] ubicacion = new string[12];
        string[] meses = new string[12];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //{"Enero","Febrero","Marzo","Abril",
            //"Mayo","Junio","Julio","Agosto","septiembre","Octubre","noviembre","Diciembre"};


            for (int i = 0; i < 12; i++)
            {
                ubicacion[i] = "";
            }

            meses[0] = "Enero";
            meses[1] = "Febrero";
            meses[2] = "Marzo";
            meses[3] = "Abril";
            meses[4] = "Mayo";
            meses[5] = "Junio";
            meses[6] = "Julio";
            meses[7] = "Agosto";
            meses[8] = "Septiembre";
            meses[9] = "Octubre";
            meses[10] = "Noviembre";
            meses[11] = "Diciembre";

            for (int suma = 0; suma < 12; suma++)
            {
                this.lst1.Items.Add(meses[suma].ToString());
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            this.lst2.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                if (meses[i] == this.lst1.SelectedItem.ToString())
                {
                    ubicacion[i] = this.lst1.SelectedItem.ToString();
                }
                if (ubicacion[i] != "")
                {
                    this.lst2.Items.Add(ubicacion[i]);
                }
                this.lst1.Items.RemoveAt(this.lst1.SelectedIndex);
                lbl1.Text = this.lst2.Items.Count.ToString();

            }
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {
            this.lst1.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                if (ubicacion[i] == this.lst2.SelectedItem.ToString())
                {
                    ubicacion[i] = "";
                }
                if (ubicacion[i] == "")
                {
                    this.lst1.Items.Add(meses[i].ToString());
                }
                this.lst2.Items.RemoveAt(this.lst2.SelectedIndex);
            }
        }

        private void btnAllIzq_Click(object sender, EventArgs e)
        {
            this.lst2.Items.Clear();
            this.lst1.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                ubicacion[i] = "";
                this.lst1.Items.Add(meses[i].ToString());
            }
        }

        private void btnAllDerecha_Click(object sender, EventArgs e)
        {
            this.lst1.Items.Clear();
            this.lst2.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                ubicacion[i] = meses[i];
                this.lst2.Items.Add(meses[i].ToString());
            }
        }
    }
}
