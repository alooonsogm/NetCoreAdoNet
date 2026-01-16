namespace NetCoreAdoNet
{
    partial class Form08CrudDepartamentos
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
            lstDepartamentos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLocalidad = new TextBox();
            label4 = new Label();
            btnEliminar = new Button();
            btnInsertar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(60, 60);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(200, 274);
            lstDepartamentos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 42);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 2;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 69);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(427, 87);
            txtId.Name = "txtId";
            txtId.Size = new Size(260, 23);
            txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(427, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 23);
            txtNombre.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 131);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(427, 207);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(260, 23);
            txtLocalidad.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 189);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 8;
            label4.Text = "Localidad";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(73, 357);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 39);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(476, 264);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(161, 36);
            btnInsertar.TabIndex = 11;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(476, 320);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(161, 32);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form08CrudDepartamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(btnEliminar);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Name = "Form08CrudDepartamentos";
            Text = "Form08CrudDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDepartamentos;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLocalidad;
        private Label label4;
        private Button btnEliminar;
        private Button btnInsertar;
        private Button btnModificar;
    }
}