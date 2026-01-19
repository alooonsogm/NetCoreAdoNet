namespace NetCoreAdoNet
{
    partial class Form11ProcedimientosHospitalPlantilla
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
            cmbHospitales = new ComboBox();
            label2 = new Label();
            btnModificarSalarios = new Button();
            txtIncremento = new TextBox();
            label3 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 46);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(88, 64);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(197, 23);
            cmbHospitales.TabIndex = 1;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 46);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Incremento";
            // 
            // btnModificarSalarios
            // 
            btnModificarSalarios.Location = new Point(290, 123);
            btnModificarSalarios.Name = "btnModificarSalarios";
            btnModificarSalarios.Size = new Size(159, 40);
            btnModificarSalarios.TabIndex = 3;
            btnModificarSalarios.Text = "Modificar Salarios";
            btnModificarSalarios.UseVisualStyleBackColor = true;
            btnModificarSalarios.Click += btnModificarSalarios_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(433, 64);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(193, 23);
            txtIncremento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 216);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(106, 234);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(542, 139);
            lstPlantilla.TabIndex = 6;
            // 
            // Form11ProcedimientosHospitalPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPlantilla);
            Controls.Add(label3);
            Controls.Add(txtIncremento);
            Controls.Add(btnModificarSalarios);
            Controls.Add(label2);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Name = "Form11ProcedimientosHospitalPlantilla";
            Text = "Form11ProcedimientosHospitalPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Label label2;
        private Button btnModificarSalarios;
        private TextBox txtIncremento;
        private Label label3;
        private ListBox lstPlantilla;
    }
}