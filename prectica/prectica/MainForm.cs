/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 5/5/2026
 * Hora: 2:34 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace prectica
{
	
	public partial class MainForm : Form
		
	{
		// Paso 1 --> crea una cadena de conexión
		private string cadenaConexion =  "Server=localhost;Database=practicas;Uid=root;Pwd='';";
		
			
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CargarUsuarios();
			
		}
		
		public void CargarUsuarios(){
		
			try {
				// Paso 2: Crear conexión (se libera automáticamente al salir del using)
				using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) 
				{
					// Paso 3: Consulta SQL
					string consulta = "SELECT    Id, name , last_name, password ,rol_user from User";
					//paso 4 Abre la conexión
					conexion.Open();
					// Paso 4: Adaptador ejecuta consulta y llena DataTable
					MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
					
					DataTable tabla = new DataTable(); // Tabla en memoria
					adaptador.Fill(tabla);
					
					// Paso 5: Mostrar datos
					dtvuser.DataSource = tabla;
					
					lblStatus.Text = string.Format("Cargados {0} usuarios.", tabla.Rows.Count);
					
				}
			} catch (Exception ex) {
				
				MessageBox.Show(string.Format("No se pudo realizar conexion por : {0}",ex.Message));
			}
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
		}
	}
}