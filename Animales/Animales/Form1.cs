using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animales
{
    public partial class Form1 : Form
    {
        ArrayList lista = new ArrayList(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            lista.Add(new Gallo("Giro", Image.FromFile("Gallo.jpg")));
            lista.Add(new Oso("Teddy", Image.FromFile("Oso.jpg")));
            lista.Add(new Leon("Leo", Image.FromFile("Leon.jpg")));
            int i = 0;
            foreach (Animal item in lista) 
            {
                DataGr.Rows.Add();
                DataGr[0, i].Value = item.imagen;
                DataGr[1, i].Value = item.nombre;
                DataGr[2, i].Value = "Sonido";
                i++;
            }
        }

        private void DataGr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                Animal animal =(Animal)lista[e.RowIndex];
                animal.sonido();
            }
        }
    }
}
