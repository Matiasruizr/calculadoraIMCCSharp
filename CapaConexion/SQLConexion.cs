using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaConexion
{
    class SQLConexion
    {
        // Variables necesarias para realizar conexion
        private string nombreBaseDatos;
        private string nombreTabla;
        private string cadenaConexion;
        private string cadenaSQL;
        private Boolean esSelect;
        private SqlConnection sqlConnection;
        private DataSet dbDataSet; // Estructura para guardar los datos al hacer una consulta
        private SqlDataAdapter dbDataAdapter;


        // Creamos estas propiedades Seleccionando todas las variables y clickeando en "Acciones rapidas y refactorizacion para crear todos sus getters and setters
        public string NombreBaseDatos { get => nombreBaseDatos; set => nombreBaseDatos = value; }
        public string NombreTabla { get => nombreTabla; set => nombreTabla = value; }
        public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        public string CadenaSQL { get => cadenaSQL; set => cadenaSQL = value; }
        public bool EsSelect { get => esSelect; set => esSelect = value; }
        public SqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = value; }
        public DataSet DbDataSet { get => dbDataSet; set => dbDataSet = value; }
        public SqlDataAdapter DbDataAdapter { get => dbDataAdapter; set => dbDataAdapter = value; }


        // Abrir conexion
        public void abrir()
        {
            try
            {
                this.SqlConnection.Open();
            }
            catch (Exception ex)
            {
                // Inicialmente no reconocera el MessageBox
                // Debemos referenciar el package de Windows Form, "Agregar referencia / Ensamblado / Sistem windows form"
                MessageBox.Show("Error al abrir la Conexion" + ex.Message, "Sistema");
            }
        } // Fin metodo abrir



        // Cerrar conexion
        public void cerrar()
        {
            try
            {
                this.SqlConnection.Close();
            }
            catch (Exception ex)
            {
                // Inicialmente no reconocera el MessageBox
                // Debemos referenciar el package de Windows Form, "Agregar referencia / Ensamblado / Sistem windows form"
                MessageBox.Show("Error al cerrar la Conexion" + ex.Message, "Sistema");
            }
        } // Fin metodo Cerrar


        public void conectar()
        {
            if (this.NombreBaseDatos.Length == 0)
            {
                MessageBox.Show("Error nombre base de datos", "Sistema");
                return;
            }
            if (this.NombreTabla.Length == 0)
            {
                MessageBox.Show("Error nombre tabla", "Sistema");
                return;
            }
            if (this.CadenaConexion.Length == 0)
            {
                MessageBox.Show("Error Cadena conexion", "Sistema");
                return;
            }
            if (this.CadenaSQL.Length == 0)
            {
                MessageBox.Show("Error CadenaSQL", "Sistema");
                return;
            }



            // Generamos instancia de la conexion

            try
            {
                this.SqlConnection = new SqlConnection(this.CadenaConexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexion " + ex.Message, "Sistema");
                return;
            }

            this.abrir();

            // Instrucciones SQL

            if (this.EsSelect) // Select, aca debemos retornar datos
            {
                this.DbDataSet = new DataSet();
                try
                {
                    this.DbDataAdapter = new SqlDataAdapter(this.CadenaSQL, this.SqlConnection);
                    this.DbDataAdapter.Fill(this.DbDataSet, this.NombreTabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar dataset " + ex.Message, "Sistema");
                    return;
                }
            }
            else // Insert - Update - Delete, aca no retornamos nada
            {
                try
                {
                    SqlCommand variableSQL = new SqlCommand(this.CadenaSQL, this.SqlConnection);
                    variableSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error con la intrucción SQL  " + ex.Message, "Sistema");
                    return;
                }
            }

            this.cerrar();

        } // Fin conectar


        public static void Main(String[] args)
        {
            SQLConexion auxConexion = new SQLConexion();
            auxConexion.NombreBaseDatos = "TRESCHANCHITOS";
            auxConexion.NombreTabla = "transaccion";
            auxConexion.CadenaConexion = @"Data Source=LAPTOP-9Q5GB3MU\SQLEXPRESS;Initial Catalog=TRESCHANCHITOS;Integrated Security=True";
            auxConexion.CadenaSQL = "SELECT * FROM transaccion;";
            auxConexion.EsSelect = true;
            auxConexion.conectar();

            foreach (DataRow dr in auxConexion.DbDataSet.Tables[auxConexion.NombreTabla].Rows)
            {
                Console.WriteLine(dr["cod_producto"] + " " + dr["nom_producto"]);
            }
            Console.ReadKey();
        }


    } // Fin Clase

} // FIN Namespace