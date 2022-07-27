using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBD.logica;
using System.Collections;

namespace GestionBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BDlogica lg = new BDlogica();

        private void btnConsultarEspacio_Click(object sender, EventArgs e)
        {
            int espLibre = 0, espeOcupado = 0;

            if (lg.consultarEspacio(ref espLibre, ref espeOcupado) != 0)
            {
                //dgvEspacioBD.Rows.Add(new string[] { "Espacio Libre", "Espacio Ocupado"});
                dgvEspacioBD.Rows.Add(new string[] { espLibre.ToString(), espeOcupado.ToString() });
            }
        }

        private void btnConsultarRestric_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = lg.consultarRestricciones(txtConsultaRest.Text);
            dgvRestricciones.DataSource = ds;
            dgvRestricciones.DataMember = "DTRestricciones";

        }

        private void btnConsultarParticionado_Click(object sender, EventArgs e)
        {
            int numPart = 0, numNoPart = 0;
            DataSet ds = new DataSet();
            ds = lg.consultarnumTabPartYNoPart(ref numPart, ref numNoPart);
            dgvRestricciones.DataSource = ds;
            dgvRestricciones.DataMember = "DTParticiones";
            ArrayList tabParticionadas = new ArrayList();
            ArrayList tabNoParticionadas = new ArrayList();
            string valor1, valor2;
            foreach (DataRow drow in ds.Tables[0].Rows)
            {
                valor1 = drow["Particionadas"].ToString();
                tabParticionadas.Add(valor1);
                valor2 = drow["No particionadas"].ToString();
                tabNoParticionadas.Add(valor2);
            }
            chtParticionado.Series[0].Points.DataBindXY(tabParticionadas, tabNoParticionadas);
        }
    }
}
