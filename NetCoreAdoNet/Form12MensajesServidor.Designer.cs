namespace NetCoreAdoNet
{
    partial class Form12MensajesServidor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblServidor = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            btnNuevoDepart = new Button();
            lstDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 56);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 114);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 176);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Localidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 56);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Departamentos";
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.ForeColor = Color.DarkCyan;
            lblServidor.Location = new Point(73, 328);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(63, 15);
            lblServidor.TabIndex = 4;
            lblServidor.Text = "lblServidor";
            // 
            // txtId
            // 
            txtId.Location = new Point(73, 74);
            txtId.Name = "txtId";
            txtId.Size = new Size(179, 23);
            txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(73, 132);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(73, 194);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(179, 23);
            txtLocalidad.TabIndex = 7;
            // 
            // btnNuevoDepart
            // 
            btnNuevoDepart.Location = new Point(73, 236);
            btnNuevoDepart.Name = "btnNuevoDepart";
            btnNuevoDepart.Size = new Size(158, 32);
            btnNuevoDepart.TabIndex = 8;
            btnNuevoDepart.Text = "Nuevo departamento";
            btnNuevoDepart.UseVisualStyleBackColor = true;
            btnNuevoDepart.Click += btnNuevoDepart_Click;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(334, 84);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(398, 259);
            lstDepartamentos.TabIndex = 9;
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDepartamentos);
            Controls.Add(btnNuevoDepart);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lblServidor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12MensajesServidor";
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblServidor;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private Button btnNuevoDepart;
        private ListBox lstDepartamentos;
    }
}