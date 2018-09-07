namespace TP_01
{
	partial class Form1
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
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonConvToDecim = new System.Windows.Forms.Button();
			this.buttonConvToBin = new System.Windows.Forms.Button();
			this.textNum1 = new System.Windows.Forms.TextBox();
			this.textNum2 = new System.Windows.Forms.TextBox();
			this.comboBoxOperator = new System.Windows.Forms.ComboBox();
			this.labelResult = new System.Windows.Forms.Label();
			this.buttonOperar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.Location = new System.Drawing.Point(165, 97);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(84, 40);
			this.buttonLimpiar.TabIndex = 1;
			this.buttonLimpiar.Text = "Limpiar";
			this.buttonLimpiar.UseVisualStyleBackColor = true;
			this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(285, 97);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(84, 40);
			this.buttonClose.TabIndex = 2;
			this.buttonClose.Text = "Cerrar";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonConvToDecim
			// 
			this.buttonConvToDecim.Location = new System.Drawing.Point(230, 143);
			this.buttonConvToDecim.Name = "buttonConvToDecim";
			this.buttonConvToDecim.Size = new System.Drawing.Size(176, 35);
			this.buttonConvToDecim.TabIndex = 3;
			this.buttonConvToDecim.Text = "Convertir a Decimal";
			this.buttonConvToDecim.UseVisualStyleBackColor = true;
			this.buttonConvToDecim.Click += new System.EventHandler(this.buttonConvToDecim_Click);
			// 
			// buttonConvToBin
			// 
			this.buttonConvToBin.Location = new System.Drawing.Point(12, 143);
			this.buttonConvToBin.Name = "buttonConvToBin";
			this.buttonConvToBin.Size = new System.Drawing.Size(176, 35);
			this.buttonConvToBin.TabIndex = 4;
			this.buttonConvToBin.Text = "Convertir a Binario";
			this.buttonConvToBin.UseVisualStyleBackColor = true;
			this.buttonConvToBin.Click += new System.EventHandler(this.buttonConvToBin_Click);
			// 
			// textNum1
			// 
			this.textNum1.Location = new System.Drawing.Point(53, 38);
			this.textNum1.Name = "textNum1";
			this.textNum1.Size = new System.Drawing.Size(84, 20);
			this.textNum1.TabIndex = 5;
			// 
			// textNum2
			// 
			this.textNum2.Location = new System.Drawing.Point(285, 38);
			this.textNum2.Name = "textNum2";
			this.textNum2.Size = new System.Drawing.Size(84, 20);
			this.textNum2.TabIndex = 6;
			// 
			// comboBoxOperator
			// 
			this.comboBoxOperator.FormattingEnabled = true;
			this.comboBoxOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
			this.comboBoxOperator.Location = new System.Drawing.Point(165, 37);
			this.comboBoxOperator.Name = "comboBoxOperator";
			this.comboBoxOperator.Size = new System.Drawing.Size(84, 21);
			this.comboBoxOperator.TabIndex = 7;
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(282, 9);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(0, 13);
			this.labelResult.TabIndex = 8;
			// 
			// buttonOperar
			// 
			this.buttonOperar.Location = new System.Drawing.Point(53, 97);
			this.buttonOperar.Name = "buttonOperar";
			this.buttonOperar.Size = new System.Drawing.Size(84, 40);
			this.buttonOperar.TabIndex = 9;
			this.buttonOperar.Text = "Operar";
			this.buttonOperar.UseVisualStyleBackColor = true;
			this.buttonOperar.Click += new System.EventHandler(this.buttonOperar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 190);
			this.Controls.Add(this.buttonOperar);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.comboBoxOperator);
			this.Controls.Add(this.textNum2);
			this.Controls.Add(this.textNum1);
			this.Controls.Add(this.buttonConvToBin);
			this.Controls.Add(this.buttonConvToDecim);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonLimpiar);
			this.Name = "Form1";
			this.Text = "Calculadora de Nicolas Mazzoconi del curso 2ºC";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonConvToDecim;
		private System.Windows.Forms.Button buttonConvToBin;
		private System.Windows.Forms.TextBox textNum1;
		private System.Windows.Forms.TextBox textNum2;
		private System.Windows.Forms.ComboBox comboBoxOperator;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Button buttonOperar;
	}
}

