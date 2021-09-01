
namespace Practica2
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
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.Salarios = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtSalarios = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.btnSmaximo = new System.Windows.Forms.Button();
            this.btnSminimo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNivelAcademico = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblNAcademico = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(11, 42);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(11, 83);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(11, 124);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // Salarios
            // 
            this.Salarios.AutoSize = true;
            this.Salarios.Location = new System.Drawing.Point(11, 154);
            this.Salarios.Name = "Salarios";
            this.Salarios.Size = new System.Drawing.Size(47, 13);
            this.Salarios.TabIndex = 3;
            this.Salarios.Text = "Salarios:";
            this.Salarios.Click += new System.EventHandler(this.Salarios_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(99, 35);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 4;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(99, 76);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(99, 117);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtSalarios
            // 
            this.txtSalarios.Location = new System.Drawing.Point(99, 147);
            this.txtSalarios.Name = "txtSalarios";
            this.txtSalarios.Size = new System.Drawing.Size(100, 20);
            this.txtSalarios.TabIndex = 7;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(489, 33);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 8;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // btnSmaximo
            // 
            this.btnSmaximo.Location = new System.Drawing.Point(322, 33);
            this.btnSmaximo.Name = "btnSmaximo";
            this.btnSmaximo.Size = new System.Drawing.Size(107, 23);
            this.btnSmaximo.TabIndex = 9;
            this.btnSmaximo.Text = "Salario Maximo";
            this.btnSmaximo.UseVisualStyleBackColor = true;
            this.btnSmaximo.Click += new System.EventHandler(this.btnSmaximo_Click);
            // 
            // btnSminimo
            // 
            this.btnSminimo.Location = new System.Drawing.Point(166, 33);
            this.btnSminimo.Name = "btnSminimo";
            this.btnSminimo.Size = new System.Drawing.Size(113, 23);
            this.btnSminimo.TabIndex = 10;
            this.btnSminimo.Text = "Salario Minimo";
            this.btnSminimo.UseVisualStyleBackColor = true;
            this.btnSminimo.Click += new System.EventHandler(this.btnSminimo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ok);
            this.groupBox1.Controls.Add(this.btnSmaximo);
            this.groupBox1.Controls.Add(this.btnSminimo);
            this.groupBox1.Location = new System.Drawing.Point(37, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGenero);
            this.groupBox2.Controls.Add(this.lblNAcademico);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.cmbNivelAcademico);
            this.groupBox2.Controls.Add(this.lblDNI);
            this.groupBox2.Controls.Add(this.lblNombres);
            this.groupBox2.Controls.Add(this.txtSalarios);
            this.groupBox2.Controls.Add(this.lblApellidos);
            this.groupBox2.Controls.Add(this.txtApellidos);
            this.groupBox2.Controls.Add(this.Salarios);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Controls.Add(this.txtDNI);
            this.groupBox2.Location = new System.Drawing.Point(37, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 195);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Empleado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbNivelAcademico
            // 
            this.cmbNivelAcademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelAcademico.FormattingEnabled = true;
            this.cmbNivelAcademico.Items.AddRange(new object[] {
            "Primaria",
            "Secundaria",
            "Universidad",
            "Doctorado"});
            this.cmbNivelAcademico.Location = new System.Drawing.Point(461, 35);
            this.cmbNivelAcademico.Name = "cmbNivelAcademico";
            this.cmbNivelAcademico.Size = new System.Drawing.Size(121, 21);
            this.cmbNivelAcademico.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox2.Location = new System.Drawing.Point(461, 117);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // lblNAcademico
            // 
            this.lblNAcademico.AutoSize = true;
            this.lblNAcademico.Location = new System.Drawing.Point(354, 38);
            this.lblNAcademico.Name = "lblNAcademico";
            this.lblNAcademico.Size = new System.Drawing.Size(90, 13);
            this.lblNAcademico.TabIndex = 10;
            this.lblNAcademico.Text = "Nivel Academico:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(357, 117);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "Genero:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label Salarios;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtSalarios;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button btnSmaximo;
        private System.Windows.Forms.Button btnSminimo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNAcademico;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbNivelAcademico;
    }
}

