﻿namespace MVC_Vista_
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
            this.dtpaises = new System.Windows.Forms.DataGridView();
            this.idpais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrepais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombrepais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnguardarcambios = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtpaises)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpaises
            // 
            this.dtpaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpais,
            this.nombrepais});
            this.dtpaises.Location = new System.Drawing.Point(31, 327);
            this.dtpaises.Name = "dtpaises";
            this.dtpaises.Size = new System.Drawing.Size(446, 150);
            this.dtpaises.TabIndex = 0;
            this.dtpaises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtpaises_CellClick);
            // 
            // idpais
            // 
            this.idpais.DataPropertyName = "idpais";
            this.idpais.HeaderText = "Código";
            this.idpais.Name = "idpais";
            // 
            // nombrepais
            // 
            this.nombrepais.DataPropertyName = "nombrepais";
            this.nombrepais.HeaderText = "Nombre país";
            this.nombrepais.Name = "nombrepais";
            this.nombrepais.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paises:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gestión Países";
            // 
            // txtnombrepais
            // 
            this.txtnombrepais.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrepais.Location = new System.Drawing.Point(198, 129);
            this.txtnombrepais.MaxLength = 50;
            this.txtnombrepais.Name = "txtnombrepais";
            this.txtnombrepais.Size = new System.Drawing.Size(279, 47);
            this.txtnombrepais.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre país:";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(39, 214);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(101, 44);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Location = new System.Drawing.Point(146, 214);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(101, 44);
            this.btnguardarcambios.TabIndex = 6;
            this.btnguardarcambios.Text = "Guardar cambios";
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(253, 214);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(101, 44);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(360, 214);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(101, 44);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código:";
            this.label4.Visible = false;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(198, 65);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(144, 47);
            this.txtcodigo.TabIndex = 10;
            this.txtcodigo.Visible = false;
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(360, 264);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(101, 44);
            this.btnregresar.TabIndex = 11;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 500);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardarcambios);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombrepais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpaises);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtpaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtpaises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpais;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombrepais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnguardarcambios;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnregresar;
    }
}

