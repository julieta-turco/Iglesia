﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iglesia
{
    public partial class PostulacionesRevisar : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public PostulacionesRevisar()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void PostulacionesRevisar_Load(object sender, EventArgs e)

        {
            
            cargarDGV();        
            
        }
        private void cargarDGV()
        {


            // Consulta SQL
            string consulta = "SELECT p.id_postulacion AS Nro_Postulacion, p.id_mentor AS Nro_Mentor, p.id_miembro AS Nro_Miembro_Postulado, m.nombre AS Nombre, m.apellido AS Apellido, m.id_etapaespiritual AS Codigo_etapa_actual, m.fecha_alta AS Desde_fecha, ee.etapaEspiritual AS Proxima_Etapa,  p.aprobado " +
                              "FROM (postulaciones p " +
                              "INNER JOIN Miembros m ON p.id_miembro = m.id_miembro) " +
                              "INNER JOIN EtapaEspiritual ee ON p.id_etapaespiritual = ee.id_etapaespiritual " +
                              //"INNER JOIN EtapaEspiritual ee ON m.id_etapaespiritual = ee.id_etapaespiritual " +
                              "WHERE aprobado = false";


            using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
            {
               

                try
                {
                    conexion.Open();
                    DataTable dataTable = new DataTable();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(dataTable);
                    DGV1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelIDPostulacion.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells[0].Value.ToString();
            labelIDMiembro.Text = DGV1.Rows[DGV1.CurrentRow.Index].Cells[2].Value.ToString();
            labelIDProxEtapa.Text= DGV1.Rows[DGV1.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void buttonAprobar_Click(object sender, EventArgs e)
        {
            if (labelIDPostulacion.Text=="")
            {
                MessageBox.Show("Por favor, haga click en la celda de la postulación que quiere aprobar");
            }
            else
            {
                string cadenaUpdate= "UPDATE Postulaciones SET aprobado = true WHERE Id_postulacion = @IdPostulacion";


                OleDbCommand comando = new OleDbCommand(cadenaUpdate, conexion);
                conexion.Open();
               
                comando.Parameters.AddWithValue("@IdPostulacion", labelIDPostulacion.Text);

                int cantidad = comando.ExecuteNonQuery();


                if (cantidad < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se aprobo la postulación con exito!");
                }
            }

           if (labelIDProxEtapa.Text =="1")
            {
                string cadena2 = "UPDATE MIEMBROS SET id_etapaespiritual = 2 WHERE id_miembro = @IdMiembro";
                OleDbCommand comando = new OleDbCommand(cadena2, conexion);
                conexion.Open();

                comando.Parameters.AddWithValue("@IdMiembro", labelIDMiembro.Text);
                int cantidad = comando.ExecuteNonQuery();


                if (cantidad < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se aprobo la postulación con exito!");
                }

            }

            if (labelIDProxEtapa.Text == "2")
            {
                string cadena3 = "UPDATE MIEMBROS SET id_etapaespiritual = 3 WHERE id_miembro =@IdMiembro";
                OleDbCommand comando = new OleDbCommand(cadena3, conexion);
                conexion.Open();

                comando.Parameters.AddWithValue("@IdMiembro", labelIDMiembro.Text);

                int cantidad = comando.ExecuteNonQuery();


                if (cantidad < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }

                else
                {
                    MessageBox.Show("Se aprobo la postulación con exito!");
                }

            }
        }
    }
}
