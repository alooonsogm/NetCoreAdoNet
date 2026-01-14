namespace NetCoreAdoNet
{
    partial class Form07DepartamentosEmpleados
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
            lstDepartamentos = new ListBox();
            btnEliminar = new Button();
            lstEmpleados = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 57);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(93, 75);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(200, 274);
            lstDepartamentos.TabIndex = 1;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(601, 191);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 39);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(375, 75);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(160, 274);
            lstEmpleados.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 57);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // Form07DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Name = "Form07DepartamentosEmpleados";
            Text = "Form07DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Button btnEliminar;
        private ListBox lstEmpleados;
        private Label label2;
    }
}