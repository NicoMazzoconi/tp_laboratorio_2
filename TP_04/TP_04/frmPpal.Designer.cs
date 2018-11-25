namespace TP_04
{
	partial class FrmPpal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnMostrarTodos = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblEstadoEntregado = new System.Windows.Forms.Label();
			this.lblEstadoEnViaje = new System.Windows.Forms.Label();
			this.lblEstadoIngresado = new System.Windows.Forms.Label();
			this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
			this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblTrackingID = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
			this.rtbMostrar = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.groupBox1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(206, 29);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(102, 30);
			this.btnAgregar.TabIndex = 0;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnMostrarTodos
			// 
			this.btnMostrarTodos.Location = new System.Drawing.Point(206, 77);
			this.btnMostrarTodos.Name = "btnMostrarTodos";
			this.btnMostrarTodos.Size = new System.Drawing.Size(102, 30);
			this.btnMostrarTodos.TabIndex = 1;
			this.btnMostrarTodos.Text = "Mostrar Todos";
			this.btnMostrarTodos.UseVisualStyleBackColor = true;
			this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblEstadoEntregado);
			this.groupBox1.Controls.Add(this.lblEstadoEnViaje);
			this.groupBox1.Controls.Add(this.lblEstadoIngresado);
			this.groupBox1.Controls.Add(this.lstEstadoEntregado);
			this.groupBox1.Controls.Add(this.lstEstadoEnViaje);
			this.groupBox1.Controls.Add(this.lstEstadoIngresado);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 277);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Estados Paquetes";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// lblEstadoEntregado
			// 
			this.lblEstadoEntregado.AutoSize = true;
			this.lblEstadoEntregado.Location = new System.Drawing.Point(546, 26);
			this.lblEstadoEntregado.Name = "lblEstadoEntregado";
			this.lblEstadoEntregado.Size = new System.Drawing.Size(56, 13);
			this.lblEstadoEntregado.TabIndex = 5;
			this.lblEstadoEntregado.Text = "Entregado";
			// 
			// lblEstadoEnViaje
			// 
			this.lblEstadoEnViaje.AutoSize = true;
			this.lblEstadoEnViaje.Location = new System.Drawing.Point(279, 26);
			this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
			this.lblEstadoEnViaje.Size = new System.Drawing.Size(46, 13);
			this.lblEstadoEnViaje.TabIndex = 4;
			this.lblEstadoEnViaje.Text = "En Viaje";
			// 
			// lblEstadoIngresado
			// 
			this.lblEstadoIngresado.AutoSize = true;
			this.lblEstadoIngresado.Location = new System.Drawing.Point(6, 26);
			this.lblEstadoIngresado.Name = "lblEstadoIngresado";
			this.lblEstadoIngresado.Size = new System.Drawing.Size(54, 13);
			this.lblEstadoIngresado.TabIndex = 3;
			this.lblEstadoIngresado.Text = "Ingresado";
			// 
			// lstEstadoEntregado
			// 
			this.lstEstadoEntregado.ContextMenuStrip = this.contextMenuStrip1;
			this.lstEstadoEntregado.FormattingEnabled = true;
			this.lstEstadoEntregado.Location = new System.Drawing.Point(549, 46);
			this.lstEstadoEntregado.Name = "lstEstadoEntregado";
			this.lstEstadoEntregado.Size = new System.Drawing.Size(221, 225);
			this.lstEstadoEntregado.TabIndex = 2;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// mostrarToolStripMenuItem
			// 
			this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
			this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.mostrarToolStripMenuItem.Text = "Mostrar";
			this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
			// 
			// lstEstadoEnViaje
			// 
			this.lstEstadoEnViaje.FormattingEnabled = true;
			this.lstEstadoEnViaje.Location = new System.Drawing.Point(282, 46);
			this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
			this.lstEstadoEnViaje.Size = new System.Drawing.Size(221, 225);
			this.lstEstadoEnViaje.TabIndex = 1;
			// 
			// lstEstadoIngresado
			// 
			this.lstEstadoIngresado.FormattingEnabled = true;
			this.lstEstadoIngresado.Location = new System.Drawing.Point(6, 46);
			this.lstEstadoIngresado.Name = "lstEstadoIngresado";
			this.lstEstadoIngresado.Size = new System.Drawing.Size(221, 225);
			this.lstEstadoIngresado.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblDireccion);
			this.groupBox2.Controls.Add(this.lblTrackingID);
			this.groupBox2.Controls.Add(this.txtDireccion);
			this.groupBox2.Controls.Add(this.mtxtTrackingID);
			this.groupBox2.Controls.Add(this.btnAgregar);
			this.groupBox2.Controls.Add(this.btnMostrarTodos);
			this.groupBox2.Location = new System.Drawing.Point(474, 306);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(314, 132);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Paquete";
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(6, 71);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(52, 13);
			this.lblDireccion.TabIndex = 7;
			this.lblDireccion.Text = "Direccion";
			// 
			// lblTrackingID
			// 
			this.lblTrackingID.AutoSize = true;
			this.lblTrackingID.Location = new System.Drawing.Point(6, 23);
			this.lblTrackingID.Name = "lblTrackingID";
			this.lblTrackingID.Size = new System.Drawing.Size(63, 13);
			this.lblTrackingID.TabIndex = 6;
			this.lblTrackingID.Text = "Tracking ID";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(9, 87);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(191, 20);
			this.txtDireccion.TabIndex = 5;
			// 
			// mtxtTrackingID
			// 
			this.mtxtTrackingID.Location = new System.Drawing.Point(9, 39);
			this.mtxtTrackingID.Mask = "000-000-0000";
			this.mtxtTrackingID.Name = "mtxtTrackingID";
			this.mtxtTrackingID.Size = new System.Drawing.Size(191, 20);
			this.mtxtTrackingID.TabIndex = 4;
			this.mtxtTrackingID.Tag = "";
			// 
			// rtbMostrar
			// 
			this.rtbMostrar.Location = new System.Drawing.Point(12, 306);
			this.rtbMostrar.Name = "rtbMostrar";
			this.rtbMostrar.Size = new System.Drawing.Size(456, 132);
			this.rtbMostrar.TabIndex = 4;
			this.rtbMostrar.Text = "";
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
			// 
			// FrmPpal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rtbMostrar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmPpal";
			this.Text = "Correo UTN por Nicolas.Mazzoconi.2C";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnMostrarTodos;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblEstadoEntregado;
		private System.Windows.Forms.Label lblEstadoEnViaje;
		private System.Windows.Forms.Label lblEstadoIngresado;
		private System.Windows.Forms.ListBox lstEstadoEntregado;
		private System.Windows.Forms.ListBox lstEstadoEnViaje;
		private System.Windows.Forms.ListBox lstEstadoIngresado;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.Label lblTrackingID;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
		private System.Windows.Forms.RichTextBox rtbMostrar;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
	}
}

