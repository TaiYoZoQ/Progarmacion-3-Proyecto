
namespace Proyecto_Prog_3
{
    partial class AltaEvento
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
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbCosto = new System.Windows.Forms.TextBox();
            this.CBAulas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextoTipo = new System.Windows.Forms.Label();
            this.TBOrador = new System.Windows.Forms.TextBox();
            this.TBComision = new System.Windows.Forms.TextBox();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(100, 50);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(250, 23);
            this.TbNombre.TabIndex = 0;
            // 
            // TbCosto
            // 
            this.TbCosto.Location = new System.Drawing.Point(100, 97);
            this.TbCosto.Name = "TbCosto";
            this.TbCosto.Size = new System.Drawing.Size(100, 23);
            this.TbCosto.TabIndex = 1;
            // 
            // CBAulas
            // 
            this.CBAulas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBAulas.FormattingEnabled = true;
            this.CBAulas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CBAulas.Location = new System.Drawing.Point(100, 144);
            this.CBAulas.Name = "CBAulas";
            this.CBAulas.Size = new System.Drawing.Size(32, 29);
            this.CBAulas.TabIndex = 2;
            this.CBAulas.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Costo:";
            // 
            // TextoTipo
            // 
            this.TextoTipo.AutoSize = true;
            this.TextoTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoTipo.Location = new System.Drawing.Point(12, 144);
            this.TextoTipo.Name = "TextoTipo";
            this.TextoTipo.Size = new System.Drawing.Size(0, 21);
            this.TextoTipo.TabIndex = 5;
            // 
            // TBOrador
            // 
            this.TBOrador.Location = new System.Drawing.Point(100, 146);
            this.TBOrador.Name = "TBOrador";
            this.TBOrador.Size = new System.Drawing.Size(250, 23);
            this.TBOrador.TabIndex = 8;
            this.TBOrador.Visible = false;
            // 
            // TBComision
            // 
            this.TBComision.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TBComision.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBComision.Location = new System.Drawing.Point(100, 141);
            this.TBComision.Name = "TBComision";
            this.TBComision.Size = new System.Drawing.Size(46, 29);
            this.TBComision.TabIndex = 9;
            this.TBComision.Text = "0";
            this.TBComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBComision.Visible = false;
            // 
            // BtnAlta
            // 
            this.BtnAlta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAlta.Location = new System.Drawing.Point(354, 182);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(75, 36);
            this.BtnAlta.TabIndex = 10;
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // AltaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 230);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.TBComision);
            this.Controls.Add(this.TBOrador);
            this.Controls.Add(this.TextoTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBAulas);
            this.Controls.Add(this.TbCosto);
            this.Controls.Add(this.TbNombre);
            this.Name = "AltaEvento";
            this.Text = "Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbCosto;
        private System.Windows.Forms.ComboBox CBAulas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TextoTipo;
        private System.Windows.Forms.TextBox TBOrador;
        private System.Windows.Forms.TextBox TBComision;
        private System.Windows.Forms.Button BtnAlta;
    }
}