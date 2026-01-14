namespace NetCoreAdoNet
{
    partial class Form04EliminarPlantilla
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
            lstEmpleados = new ListBox();
            btnEliminarEmpleado = new Button();
            txtEmpleado = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(390, 82);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(200, 244);
            lstEmpleados.TabIndex = 9;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(111, 127);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(140, 32);
            btnEliminarEmpleado.TabIndex = 8;
            btnEliminarEmpleado.Text = "Eliminar empleado";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(95, 84);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(179, 23);
            txtEmpleado.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 64);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 6;
            label2.Text = "Empleados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 66);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Empleado";
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEmpleados);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(txtEmpleado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmpleados;
        private Button btnEliminarEmpleado;
        private TextBox txtEmpleado;
        private Label label2;
        private Label label1;
    }
}