
namespace practica230921
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
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtdocumento = new System.Windows.Forms.Label();
            this.txtDocumentoId = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(483, 235);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 0;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtdocumento
            // 
            this.txtdocumento.AutoSize = true;
            this.txtdocumento.BackColor = System.Drawing.Color.Aqua;
            this.txtdocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtdocumento.Location = new System.Drawing.Point(12, 103);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(50, 15);
            this.txtdocumento.TabIndex = 1;
            this.txtdocumento.Text = "Mascota";
            this.txtdocumento.Click += new System.EventHandler(this.txtdocumento_Click);
            // 
            // txtDocumentoId
            // 
            this.txtDocumentoId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDocumentoId.ForeColor = System.Drawing.Color.Black;
            this.txtDocumentoId.Location = new System.Drawing.Point(113, 98);
            this.txtDocumentoId.Name = "txtDocumentoId";
            this.txtDocumentoId.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentoId.TabIndex = 2;
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.Silver;
            this.Datos.FormattingEnabled = true;
            this.Datos.Location = new System.Drawing.Point(230, 88);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(669, 108);
            this.Datos.TabIndex = 3;
            this.Datos.SelectedIndexChanged += new System.EventHandler(this.Datos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "color";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTitulo.Location = new System.Drawing.Point(113, 132);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 8;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtdescripcion.Location = new System.Drawing.Point(113, 169);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(374, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 38);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mascota";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.txtDocumentoId);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.btnAñadir);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label txtdocumento;
        private System.Windows.Forms.TextBox txtDocumentoId;
        private System.Windows.Forms.ListBox Datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label6;
    }
}

