
namespace Proyecto_Prog_3
{
    partial class FormularioPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEventos = new System.Windows.Forms.Button();
            this.BtnTesoreria = new System.Windows.Forms.Button();
            this.BtnAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEventos
            // 
            this.BtnEventos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnEventos.Location = new System.Drawing.Point(54, 22);
            this.BtnEventos.Name = "BtnEventos";
            this.BtnEventos.Size = new System.Drawing.Size(109, 59);
            this.BtnEventos.TabIndex = 0;
            this.BtnEventos.Text = "Eventos";
            this.BtnEventos.UseVisualStyleBackColor = false;
            this.BtnEventos.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTesoreria
            // 
            this.BtnTesoreria.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnTesoreria.Location = new System.Drawing.Point(54, 186);
            this.BtnTesoreria.Name = "BtnTesoreria";
            this.BtnTesoreria.Size = new System.Drawing.Size(109, 59);
            this.BtnTesoreria.TabIndex = 1;
            this.BtnTesoreria.Text = "Tesoreria";
            this.BtnTesoreria.UseVisualStyleBackColor = false;
            this.BtnTesoreria.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnAlumnos.Location = new System.Drawing.Point(54, 103);
            this.BtnAlumnos.Name = "BtnAlumnos";
            this.BtnAlumnos.Size = new System.Drawing.Size(109, 59);
            this.BtnAlumnos.TabIndex = 2;
            this.BtnAlumnos.Text = "Alumnos";
            this.BtnAlumnos.UseVisualStyleBackColor = false;
            this.BtnAlumnos.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 278);
            this.Controls.Add(this.BtnAlumnos);
            this.Controls.Add(this.BtnTesoreria);
            this.Controls.Add(this.BtnEventos);
            this.Name = "FormularioPrincipal";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEventos;
        private System.Windows.Forms.Button BtnTesoreria;
        private System.Windows.Forms.Button BtnAlumnos;
    }
}

