
namespace Practica_s9
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
            this.components = new System.ComponentModel.Container();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDUI = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.bttAFP = new System.Windows.Forms.Button();
            this.bttISSS = new System.Windows.Forms.Button();
            this.bttNeto = new System.Windows.Forms.Button();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNeto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(75, 54);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(75, 87);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.Location = new System.Drawing.Point(75, 120);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(29, 13);
            this.labelDUI.TabIndex = 2;
            this.labelDUI.Text = "DUI";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(75, 150);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(46, 13);
            this.labelSalario.TabIndex = 3;
            this.labelSalario.Text = "Salario";
            // 
            // bttAFP
            // 
            this.bttAFP.Location = new System.Drawing.Point(467, 45);
            this.bttAFP.Name = "bttAFP";
            this.bttAFP.Size = new System.Drawing.Size(75, 23);
            this.bttAFP.TabIndex = 5;
            this.bttAFP.Text = "AFP";
            this.bttAFP.UseVisualStyleBackColor = true;
            this.bttAFP.Click += new System.EventHandler(this.bttAFP_Click);
            // 
            // bttISSS
            // 
            this.bttISSS.Location = new System.Drawing.Point(467, 87);
            this.bttISSS.Name = "bttISSS";
            this.bttISSS.Size = new System.Drawing.Size(75, 23);
            this.bttISSS.TabIndex = 6;
            this.bttISSS.Text = "ISSS";
            this.bttISSS.UseVisualStyleBackColor = true;
            this.bttISSS.Click += new System.EventHandler(this.bttISSS_Click);
            // 
            // bttNeto
            // 
            this.bttNeto.Location = new System.Drawing.Point(467, 120);
            this.bttNeto.Name = "bttNeto";
            this.bttNeto.Size = new System.Drawing.Size(75, 23);
            this.bttNeto.TabIndex = 7;
            this.bttNeto.Text = "Neto";
            this.bttNeto.UseVisualStyleBackColor = true;
            this.bttNeto.Click += new System.EventHandler(this.bttNeto_Click);
            // 
            // bttGuardar
            // 
            this.bttGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttGuardar.Location = new System.Drawing.Point(78, 240);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttGuardar.TabIndex = 4;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(143, 51);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(143, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtDUI
            // 
            this.txtDUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDUI.Location = new System.Drawing.Point(143, 117);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 10;
            this.txtDUI.TextChanged += new System.EventHandler(this.txtDUI_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalario.Location = new System.Drawing.Point(143, 147);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 11;
            // 
            // txtAFP
            // 
            this.txtAFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAFP.Location = new System.Drawing.Point(577, 48);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 12;
            // 
            // txtISSS
            // 
            this.txtISSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISSS.Location = new System.Drawing.Point(577, 84);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(100, 20);
            this.txtISSS.TabIndex = 13;
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(125, 200);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 13);
            this.labelRegistro.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtNeto
            // 
            this.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNeto.Location = new System.Drawing.Point(577, 120);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(100, 20);
            this.txtNeto.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::Practica_s9.Properties.Resources.stitch;
            this.ClientSize = new System.Drawing.Size(760, 303);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.bttNeto);
            this.Controls.Add(this.bttISSS);
            this.Controls.Add(this.bttAFP);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelID);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Registro de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Button bttAFP;
        private System.Windows.Forms.Button bttISSS;
        private System.Windows.Forms.Button bttNeto;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtNeto;
    }
}

