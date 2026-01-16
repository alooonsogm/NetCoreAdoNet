namespace NetCoreAdoNet
{
    partial class Form09CrudHospital
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
            btnModificar = new Button();
            btnInsertar = new Button();
            btnEliminar = new Button();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            lstHospitales = new ListBox();
            label1 = new Label();
            txtCamas = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(499, 389);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(161, 32);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(499, 333);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(161, 36);
            btnInsertar.TabIndex = 22;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(48, 362);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(313, 39);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(454, 185);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(260, 23);
            txtDireccion.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 167);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 19;
            label4.Text = "Direccion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(454, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 23);
            txtNombre.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 109);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 17;
            label3.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(454, 65);
            txtId.Name = "txtId";
            txtId.Size = new Size(260, 23);
            txtId.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 47);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 15;
            label2.Text = "ID";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(35, 65);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(361, 274);
            lstHospitales.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 47);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 13;
            label1.Text = "Hospitales";
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(454, 293);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(260, 23);
            txtCamas.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 275);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 26;
            label5.Text = "Numero de camas";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(454, 235);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(260, 23);
            txtTelefono.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 217);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 24;
            label6.Text = "Telefono";
            // 
            // Form09CrudHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCamas);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(btnEliminar);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Name = "Form09CrudHospital";
            Text = "Form09CrudHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Button btnInsertar;
        private Button btnEliminar;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private ListBox lstHospitales;
        private Label label1;
        private TextBox txtCamas;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
    }
}