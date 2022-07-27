using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace GestionBD.datos
{
    class BDdatos
    {
        //establecer la cadena de conexion
        //creo uh objeto de tipo OracleConnection
        OracleConnection miConexion = new OracleConnection("Data Source = localhost; User ID = bases2; Password = oracle;");

        public int consultarEspacioBD(ref int espLibre, ref int espOcupado)
        {
            int respuesta = 0;
            //abrimos conexion
            miConexion.Open();
            //creo un objeto de tipo Comando
            OracleCommand miComando = new OracleCommand("pq_GestionBD.prcEspacioBD", miConexion);
            miComando.Parameters.Add("v_EspLibre", OracleDbType.Int32, espLibre, ParameterDirection.InputOutput);
            miComando.Parameters.Add("v_EspOcupado", OracleDbType.Int32, espOcupado, ParameterDirection.InputOutput);
            miComando.CommandType = CommandType.StoredProcedure;
            
            respuesta = miComando.ExecuteNonQuery();

            espLibre = Int32.Parse(miComando.Parameters["v_EspLibre"].Value.ToString());
            espOcupado = Int32.Parse(miComando.Parameters["v_EspOcupado"].Value.ToString());
            miConexion.Close();
            return respuesta;
        }

        public DataSet consultarRestriccionesBD(string nomTabla)
        {
            //abrimos conexion
            miConexion.Open();
            //creo un objeto de tipo Comando
            OracleCommand miComando = new OracleCommand("pq_GestionBD.prcinfoRestricciones", miConexion);
            miComando.Parameters.Add("curRest", OracleDbType.RefCursor, ParameterDirection.Output);
            miComando.Parameters.Add("v_tableName", OracleDbType.Varchar2, 30, nomTabla, ParameterDirection.Input);
            miComando.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "DTRestricciones");
            miConexion.Close();
            return ds;
        }

        public int consultarnumTabPartYNoPartBD(ref int numPart, ref int numNoPart)
        {
            int respuesta = 0;
            //abrimos conexion
            miConexion.Open();
            //creo un objeto de tipo Comando
            OracleCommand miComando = new OracleCommand("pq_GestionBD.prcnumTBPartYnoPart", miConexion);
            miComando.Parameters.Add("v_numPart", OracleDbType.Int32, numPart, ParameterDirection.Output);
            miComando.Parameters.Add("v_numNoPart", OracleDbType.Int32, numNoPart, ParameterDirection.Output);
            miComando.CommandType = CommandType.StoredProcedure;

            respuesta = miComando.ExecuteNonQuery();

            numPart = Int32.Parse(miComando.Parameters["v_numPart"].Value.ToString());
            numNoPart = Int32.Parse(miComando.Parameters["v_numNoPart"].Value.ToString());
            
            miConexion.Close();
            return respuesta;
        }

        public DataSet consultarTabParticionadasBD(string nomTabla)
        {
            //abrimos conexion
            miConexion.Open();
            //creo un objeto de tipo Comando
            OracleCommand miComando = new OracleCommand("pq_GestionBD.prcTablasParticionadas", miConexion);
            miComando.Parameters.Add("v_name", OracleDbType.Varchar2, 30, nomTabla, ParameterDirection.Input);
            miComando.Parameters.Add("curPart", OracleDbType.RefCursor, ParameterDirection.Output);
            miComando.Parameters.Add("curSubPart", OracleDbType.RefCursor, ParameterDirection.Output);
            miComando.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            DataSet ds = new DataSet();
            miAdaptador.Fill(ds, "DTParticionadas");
            miConexion.Close();
            return ds;
        }

    }
}
