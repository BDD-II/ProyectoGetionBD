using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBD.datos;
using System.Data;

namespace GestionBD.logica
{
    
    class BDlogica
    {
        BDdatos dt = new BDdatos();
        public int consultarEspacio(ref int espLibre, ref int espOcupado)
        {
            return dt.consultarEspacioBD(ref espLibre, ref espOcupado);
        }
        public DataSet consultarRestricciones(string nomTabla)
        {
            return dt.consultarRestriccionesBD(nomTabla);
        }
        public int consultarnumTabPartYNoPart(ref int numPart, ref int numNoPart)
        {
            return dt.consultarnumTabPartYNoPartBD(ref numPart, ref numNoPart);
        }
        public DataSet consultarTabParticionadas(string nomTabla)
        {
            return dt.consultarTabParticionadasBD(nomTabla);
        }
    }
}
