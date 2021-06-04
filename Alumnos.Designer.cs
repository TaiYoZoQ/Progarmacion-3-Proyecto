
namespace Proyecto_Prog_3
{
    partial class Alumnos
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
            this.label3 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.CbEsSocio = new System.Windows.Forms.CheckBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.CbEventos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Inscribir = new System.Windows.Forms.Button();
            this.BtnVerEventos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Socio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "I.D";
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(46, 9);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(44, 23);
            this.TbId.TabIndex = 3;
            // 
            // CbEsSocio
            // 
            this.CbEsSocio.AutoSize = true;
            this.CbEsSocio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CbEsSocio.Enabled = false;
            this.CbEsSocio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbEsSocio.Location = new System.Drawing.Point(86, 114);
            this.CbEsSocio.Name = "CbEsSocio";
            this.CbEsSocio.Size = new System.Drawing.Size(15, 14);
            this.CbEsSocio.TabIndex = 4;
            this.CbEsSocio.UseVisualStyleBackColor = false;
            // 
            // TbNombre
            // 
            this.TbNombre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TbNombre.Enabled = false;
            this.TbNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbNombre.Location = new System.Drawing.Point(86, 69);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(211, 29);
            this.TbNombre.TabIndex = 5;
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Buscar.Location = new System.Drawing.Point(96, 9);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(58, 23);
            this.Buscar.TabIndex = 10;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAtras.Location = new System.Drawing.Point(284, 286);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(62, 30);
            this.BtnAtras.TabIndex = 11;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // CbEventos
            // 
            this.CbEventos.Enabled = false;
            this.CbEventos.FormattingEnabled = true;
            this.CbEventos.Location = new System.Drawing.Point(12, 182);
            this.CbEventos.Name = "CbEventos";
            this.CbEventos.Size = new System.Drawing.Size(211, 23);
            this.CbEventos.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Inscribir a Evento/Combo:";
            // 
            // Inscribir
            // 
            this.Inscribir.Enabled = false;
            this.Inscribir.Location = new System.Drawing.Point(230, 182);
            this.Inscribir.Name = "Inscribir";
            this.Inscribir.Size = new System.Drawing.Size(23, 23);
            this.Inscribir.TabIndex = 14;
            this.Inscribir.Text = ">";
            this.Inscribir.UseVisualStyleBackColor = true;
            this.Inscribir.Click += new System.EventHandler(this.Inscribir_Click);
            // 
            // BtnVerEventos
            // 
            this.BtnVerEventos.Enabled = false;
            this.BtnVerEventos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVerEventos.Location = new System.Drawing.Point(12, 228);
            this.BtnVerEventos.Name = "BtnVerEventos";
            this.BtnVerEventos.Size = new System.Drawing.Size(129, 30);
            this.BtnVerEventos.TabIndex = 15;
            this.BtnVerEventos.Text = "Ver Eventos";
            this.BtnVerEventos.UseVisualStyleBackColor = true;
            this.BtnVerEventos.Click += new System.EventHandler(this.BtnVerEventos_Click);
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 328);
            this.Controls.Add(this.BtnVerEventos);
            this.Controls.Add(this.Inscribir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbEventos);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.CbEsSocio);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.CheckBox CbEsSocio;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.ComboBox CbEventos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Inscribir;
        private System.Windows.Forms.Button BtnVerEventos;
    }
}