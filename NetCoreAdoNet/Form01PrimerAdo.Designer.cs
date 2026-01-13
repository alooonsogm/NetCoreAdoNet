namespace NetCoreAdoNet
{
    partial class Form01PrimerAdo
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
            btnConectar = new Button();
            btnDeconectar = new Button();
            btnRead = new Button();
            label1 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            label2 = new Label();
            lstTipos = new ListBox();
            label3 = new Label();
            lblConexion = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(36, 134);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(109, 40);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDeconectar
            // 
            btnDeconectar.Location = new Point(36, 207);
            btnDeconectar.Name = "btnDeconectar";
            btnDeconectar.Size = new Size(109, 38);
            btnDeconectar.TabIndex = 1;
            btnDeconectar.Text = "Desconectar";
            btnDeconectar.UseVisualStyleBackColor = true;
            btnDeconectar.Click += btnDeconectar_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(36, 278);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(109, 39);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 107);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(210, 125);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(159, 229);
            lstApellidos.TabIndex = 4;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(412, 125);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(162, 229);
            lstColumnas.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 107);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Columnas";
            // 
            // lstTipos
            // 
            lstTipos.FormattingEnabled = true;
            lstTipos.Location = new Point(602, 125);
            lstTipos.Name = "lstTipos";
            lstTipos.Size = new Size(165, 229);
            lstTipos.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 107);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Tipos dato";
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Location = new Point(50, 387);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(71, 15);
            lblConexion.TabIndex = 9;
            lblConexion.Text = "lblConexion";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblConexion);
            Controls.Add(lstTipos);
            Controls.Add(label3);
            Controls.Add(lstColumnas);
            Controls.Add(label2);
            Controls.Add(lstApellidos);
            Controls.Add(label1);
            Controls.Add(btnRead);
            Controls.Add(btnDeconectar);
            Controls.Add(btnConectar);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDeconectar;
        private Button btnRead;
        private Label label1;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private Label label2;
        private ListBox lstTipos;
        private Label label3;
        private Label lblConexion;
    }
}