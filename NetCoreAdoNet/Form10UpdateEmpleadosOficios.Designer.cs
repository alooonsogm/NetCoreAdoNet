namespace NetCoreAdoNet
{
    partial class Form10UpdateEmpleadosOficios
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
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            label2 = new Label();
            lblSumaSalarial = new Label();
            lblMaximoSalario = new Label();
            lblMediaSalarial = new Label();
            label6 = new Label();
            txtIncrementoSalarial = new TextBox();
            btnSubirSalario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 49);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(77, 67);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(191, 274);
            lstOficios.TabIndex = 1;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(310, 67);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(191, 274);
            lstEmpleados.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 49);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleados";
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(77, 353);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(87, 15);
            lblSumaSalarial.TabIndex = 4;
            lblSumaSalarial.Text = "lblSumaSalarial";
            // 
            // lblMaximoSalario
            // 
            lblMaximoSalario.AutoSize = true;
            lblMaximoSalario.Location = new Point(77, 409);
            lblMaximoSalario.Name = "lblMaximoSalario";
            lblMaximoSalario.Size = new Size(99, 15);
            lblMaximoSalario.TabIndex = 5;
            lblMaximoSalario.Text = "lblMaximoSalario";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(77, 382);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(90, 15);
            lblMediaSalarial.TabIndex = 6;
            lblMediaSalarial.Text = "lblMediaSalarial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(581, 49);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 7;
            label6.Text = "Incremento salarial";
            // 
            // txtIncrementoSalarial
            // 
            txtIncrementoSalarial.Location = new Point(581, 67);
            txtIncrementoSalarial.Name = "txtIncrementoSalarial";
            txtIncrementoSalarial.Size = new Size(187, 23);
            txtIncrementoSalarial.TabIndex = 8;
            // 
            // btnSubirSalario
            // 
            btnSubirSalario.Location = new Point(609, 112);
            btnSubirSalario.Name = "btnSubirSalario";
            btnSubirSalario.Size = new Size(119, 32);
            btnSubirSalario.TabIndex = 9;
            btnSubirSalario.Text = "Subir salarios";
            btnSubirSalario.UseVisualStyleBackColor = true;
            btnSubirSalario.Click += btnSubirSalario_Click;
            // 
            // Form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubirSalario);
            Controls.Add(txtIncrementoSalarial);
            Controls.Add(label6);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblMaximoSalario);
            Controls.Add(lblSumaSalarial);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstOficios);
            Controls.Add(label1);
            Name = "Form10UpdateEmpleadosOficios";
            Text = "Form10UpdateEmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private Label label2;
        private Label lblSumaSalarial;
        private Label lblMaximoSalario;
        private Label lblMediaSalarial;
        private Label label6;
        private TextBox txtIncrementoSalarial;
        private Button btnSubirSalario;
    }
}