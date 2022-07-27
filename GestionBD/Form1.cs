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
        DataSet ds = new DataSet();
        private void btnConsultarEspacio_Click(object sender, EventArgs e)
        {
            int espLibre = 0, espeOcupado = 0;

            if (lg.consultarEspacio(ref espLibre, ref espeOcupado) != 0)
            {
                dgvEspacioBD.Rows.Add(new string[] { espLibre.ToString(), espeOcupado.ToString() });
                ArrayList espNombres = new ArrayList();
                ArrayList espValores = new ArrayList();
                espNombres.Add("Libre");
                espNombres.Add("Ocupado");
                espValores.Add(espLibre.ToString());
                espValores.Add(espeOcupado.ToString());

                chtAlmacenamiento.Series[0].Points.DataBindXY(espNombres, espValores);
            }
        }

        private void btnConsultarRestric_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds = lg.consultarRestricciones(txtConsultaRest.Text);
            dgvRestricciones.DataSource = ds;
            dgvRestricciones.DataMember = "DTRestricciones";

        }

        private void btnConsultarParticionado_Click(object sender, EventArgs e)
        {
            int numPart = 0, numNoPart = 0;
            if (lg.consultarnumTabPartYNoPart(ref numPart, ref numNoPart) != 0)
            {                           
                ArrayList tabNombres = new ArrayList();
                ArrayList tabValores = new ArrayList();
                tabNombres.Add("Particionadas");
                tabNombres.Add("No Particionas");
                tabValores.Add(numPart.ToString());
                tabValores.Add(numNoPart.ToString());

                chtParticionado.Series[0].Points.DataBindXY(tabNombres, tabValores);
            }
        }

        private void btnConsultaParticiones_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds = lg.consultarTabParticionadas(txtConsultaParticiones.Text);
            dgvParticiones.DataSource = ds;
            dgvParticiones.DataMember = "DTParticionadas";
        }

        private void dgvParticiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nomParticion;
            nomParticion = dgvParticiones.CurrentRow.Cells[0].Value.ToString();

            dgvRestricciones.DataSource = ds;
            dgvRestricciones.DataMember = "DTParticionadas1";
            ArrayList nomSubParticiones = new ArrayList();
            ArrayList CantFilas = new ArrayList();
            foreach (DataRow drow in ds.Tables[1].Rows)
            {
                if (drow["PARTICIONES"].ToString() == nomParticion)
                {
                    nomSubParticiones.Add(drow["SUBPARTICIONES"].ToString());
                    CantFilas.Add(drow["NUMFILAS"].ToString());
                }
            }
            chtParticiones.Series[0].Points.DataBindXY(nomSubParticiones, CantFilas);
        }
    }
}
