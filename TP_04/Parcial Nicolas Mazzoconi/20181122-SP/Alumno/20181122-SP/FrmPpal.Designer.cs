﻿namespace _20181122_SP
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
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnSql = new System.Windows.Forms.Button();
            this.vistaPatente3 = new Patentes.VistaPatente();
            this.vistaPatente4 = new Patentes.VistaPatente();
            this.SuspendLayout();
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(146, 148);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(128, 74);
            this.btnTxt.TabIndex = 2;
            this.btnTxt.Text = "TXT";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(12, 148);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(128, 74);
            this.btnXml.TabIndex = 3;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnSql
            // 
            this.btnSql.Location = new System.Drawing.Point(12, 100);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(262, 42);
            this.btnSql.TabIndex = 4;
            this.btnSql.Text = "SQL";
            this.btnSql.UseVisualStyleBackColor = true;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // vistaPatente3
            // 
            this.vistaPatente3.Location = new System.Drawing.Point(12, 12);
            this.vistaPatente3.Name = "vistaPatente3";
            this.vistaPatente3.Size = new System.Drawing.Size(128, 48);
            this.vistaPatente3.TabIndex = 5;
            // 
            // vistaPatente4
            // 
            this.vistaPatente4.Location = new System.Drawing.Point(149, 12);
            this.vistaPatente4.Name = "vistaPatente4";
            this.vistaPatente4.Size = new System.Drawing.Size(128, 48);
            this.vistaPatente4.TabIndex = 6;
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 234);
            this.Controls.Add(this.vistaPatente4);
            this.Controls.Add(this.vistaPatente3);
            this.Controls.Add(this.btnSql);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnSql;
        private Patentes.VistaPatente vistaPatente3;
        private Patentes.VistaPatente vistaPatente4;
    }
}
