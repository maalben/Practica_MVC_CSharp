﻿namespace MVC_Vista_
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpaises = new System.Windows.Forms.Button();
            this.btnparticipantes = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Olimpiadas";
            // 
            // btnpaises
            // 
            this.btnpaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaises.Location = new System.Drawing.Point(87, 162);
            this.btnpaises.Name = "btnpaises";
            this.btnpaises.Size = new System.Drawing.Size(356, 54);
            this.btnpaises.TabIndex = 2;
            this.btnpaises.Text = "Países";
            this.btnpaises.UseVisualStyleBackColor = true;
            this.btnpaises.Click += new System.EventHandler(this.btnpaises_Click);
            // 
            // btnparticipantes
            // 
            this.btnparticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparticipantes.Location = new System.Drawing.Point(87, 242);
            this.btnparticipantes.Name = "btnparticipantes";
            this.btnparticipantes.Size = new System.Drawing.Size(356, 54);
            this.btnparticipantes.TabIndex = 3;
            this.btnparticipantes.Text = "Participantes";
            this.btnparticipantes.UseVisualStyleBackColor = true;
            this.btnparticipantes.Click += new System.EventHandler(this.btnparticipantes_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(414, 384);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(117, 54);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnparticipantes);
            this.Controls.Add(this.btnpaises);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnpaises;
        private System.Windows.Forms.Button btnparticipantes;
        private System.Windows.Forms.Button btnsalir;
    }
}