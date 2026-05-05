/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 5/5/2026
 * Hora: 2:34 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace prectica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnconsultar = new System.Windows.Forms.Button();
			this.dtvuser = new System.Windows.Forms.DataGridView();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtvuser)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(83, 314);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(93, 41);
			this.btnAgregar.TabIndex = 1;
			this.btnAgregar.Text = "agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			// 
			// btnconsultar
			// 
			this.btnconsultar.Location = new System.Drawing.Point(304, 314);
			this.btnconsultar.Name = "btnconsultar";
			this.btnconsultar.Size = new System.Drawing.Size(93, 41);
			this.btnconsultar.TabIndex = 3;
			this.btnconsultar.Text = "Consultar";
			this.btnconsultar.UseVisualStyleBackColor = true;
			// 
			// dtvuser
			// 
			this.dtvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtvuser.Location = new System.Drawing.Point(18, 12);
			this.dtvuser.Name = "dtvuser";
			this.dtvuser.Size = new System.Drawing.Size(562, 274);
			this.dtvuser.TabIndex = 9;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(419, 314);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(93, 41);
			this.btnEliminar.TabIndex = 10;
			this.btnEliminar.Text = "limpiar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(193, 314);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(93, 41);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "actualizar";
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// lblStatus
			// 
			this.lblStatus.Location = new System.Drawing.Point(235, 376);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(103, 34);
			this.lblStatus.TabIndex = 11;
			this.lblStatus.Text = "Listo";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 419);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dtvuser);
			this.Controls.Add(this.btnconsultar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Name = "MainForm";
			this.Text = "prectica";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtvuser)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.DataGridView dtvuser;
		private System.Windows.Forms.Button btnconsultar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
	}
}
